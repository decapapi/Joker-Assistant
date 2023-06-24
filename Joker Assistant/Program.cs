using JAssistant.Properties;
using System;
using System.IO;
using System.Runtime;
using System.Threading;
using System.Windows.Forms;
using static JAssistant.Preferences;

namespace JAssistant
{
	internal static class Program
	{
		public static bool createdNew;
		public static Mutex mutex = new Mutex(true, "JAssistant", out createdNew);

		[STAThread]
		static void Main()
		{
			if (!CreateMutex())
				return;

			if (!File.Exists("tasks.json"))
				JsonManipulation.createExampleTasksFile();

			if (!File.Exists("settings.json"))
				JsonManipulation.createExampleSettingsFile();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Preferences preferences = new Preferences();
			preferences.InitializateUserPreferences();

			Tasks mainForm = new Tasks();
			mainForm.TrayIcon.Visible = true;

			if (preferences.userPreferences[0].StartListeningAtStartup)
			{
				// Start speech recognition on a separate thread
				VoiceRecognition voiceRecognition = new VoiceRecognition();
				Thread t = new Thread(voiceRecognition.StartRecognizing);
				t.Start();
			}

			Application.Run();

			// Stop speech recognition when the application exits
			VoiceRecognition.StopRecognizing();
		}

		private static bool CreateMutex()
		{

			if (!createdNew)
			{
				// Another instance of the program is already running
				MessageBox.Show("Another instance of the program is already running.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}

		public static void ReleaseMutex()
		{
			// Release the mutex
			mutex.ReleaseMutex();
		}
	}
}
