using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAssistant
{
	internal class VoiceRecognition
	{
		public static SpeechRecognitionEngine sEngine = new SpeechRecognitionEngine();
		public static List<ActionItem> actions = JsonManipulation.LoadJsonItems<ActionItem>("tasks.json");

		public static SpeechSynthesizer synthesizer = new SpeechSynthesizer();

		private static ManualResetEvent stopRecognitionEvent = new ManualResetEvent(false);

		static Preferences preferences = new Preferences();
		public static bool isListening = true;//preferences.userPreferences[0].StartListeningAtStartup;

		private static readonly Regex wordBoundaryRegex = new Regex(@"\b{0}\b", RegexOptions.IgnoreCase | RegexOptions.Compiled);
		private static readonly Regex sanitizeRegex = new Regex("[^a-zA-Z0-9 ]");

		public void StartRecognizing()
		{
			try
			{
				// Load keywords from tasks.json
				Choices choices = new Choices();
				foreach (ActionItem item in actions)
				{
					choices.Add(item.Keywords);
				}

				// Build grammar and load it into the recognition engine
				GrammarBuilder grammarBuilder = new GrammarBuilder(choices);
				Grammar grammar = new Grammar(grammarBuilder);
				sEngine.LoadGrammar(grammar);

				sEngine.SetInputToDefaultAudioDevice();
				sEngine.RecognizeAsync(RecognizeMode.Multiple);

				// Set up recognition engine events
				sEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(ProcessRecognizedSpeech);

				// Wait for the stopRecognitionEvent to be signaled
				stopRecognitionEvent.WaitOne();
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while starting speech recognition:  \n\n" + ex.Message);
			}
		}

		public static void StopRecognizing()
		{
			try
			{
				// Signal the stopRecognitionEvent to stop speech recognition
				stopRecognitionEvent.Set();

				// Check if sEngine is null before attempting to unload its grammars and dispose of it
				if (sEngine != null)
				{
					// Unload the speech recognition engine
					sEngine.UnloadAllGrammars();
					sEngine.Dispose();
					sEngine = null;
				}

				// Close the application
				Environment.Exit(0);
			}
			catch (Exception ex)
			{
				// Handle the exception
				MessageBox.Show("Error stopping speech recognition:  \n\n" + ex.Message);
			}
		}

		private void ProcessRecognizedSpeech(object sender, SpeechRecognizedEventArgs e)
		{
			if (e.Result == null || string.IsNullOrEmpty(e.Result.Text))
			{
				return;
			}

			var speechResult = sanitizeRegex.Replace(e.Result.Text.ToLower(), "");

			try
			{
				foreach (var item in actions)
				{
					var isExactMatch = item.ExactMatch;
					var keywords = item.Keywords.ToLower();
					var regex = new Regex(string.Format(wordBoundaryRegex.ToString(), Regex.Escape(keywords)));

					if ((isExactMatch && speechResult.Equals(keywords)) || (!isExactMatch && regex.IsMatch(speechResult)))
					{
						Task.Run(() => HandleAction(item));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while processing speech #1:  \n\n" + ex.Message);
			}
		}

		private void HandleAction(ActionItem item)
		{
			try
			{
				switch (item.Type)
				{
					case 0:
						var startInfo = new ProcessStartInfo
						{
							FileName = item.Action,
							Arguments = item.Parameters,
							UseShellExecute = true,
							Verb = item.Admin ? "runas" : null
						};

						Process.Start(startInfo);
						break;
					case 1:
						Process.Start(item.Action);
						break;
					default:
						// Invalid action type
						MessageBox.Show($"Action *{item.Name}* has an invalid action type: " + item.Type);
						break;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while processing speech #2:  \n\n" + ex.Message);
			}
		}

		public static void ToggleRecognition()
		{
			try
			{
				if (!isListening)
				{
					sEngine.RecognizeAsync(RecognizeMode.Multiple);
				}
				else
				{
					sEngine.RecognizeAsyncStop();
				}
				isListening = !isListening;
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while toggling speech recognition:  \n\n" + ex.Message);
			}
		}

		public static void ReloadGrammar()
		{
			try
			{
				actions = JsonManipulation.LoadJsonItems<ActionItem>("tasks.json");

				// Get the existing recognition engine
				var engine = VoiceRecognition.sEngine;

				engine.UnloadAllGrammars();

				// Create a new choices object and add the new keywords
				Choices choices = new Choices();
				foreach (ActionItem item in VoiceRecognition.actions)
				{
					choices.Add(item.Keywords);
				}

				// Create a new grammar builder and set its choices property
				GrammarBuilder grammarBuilder = new GrammarBuilder(choices);

				// Create a new grammar and load it into the recognition engine
				Grammar grammar = new Grammar(grammarBuilder);
				engine.LoadGrammar(grammar);
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while updating the speech recognition engine: \n\n" + ex.Message);
			}
		}
	}
}
