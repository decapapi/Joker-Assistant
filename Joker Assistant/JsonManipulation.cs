using JAssistant.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace JAssistant
{
	internal class JsonManipulation
	{
		public static void createExampleTasksFile()
		{
			try
			{
				List<ActionItem> actions = new List<ActionItem>
				{
					new ActionItem
					{
						Name = "Run CMD",
						Type = 0,
						Keywords = "Open CMD",
						Action = "cmd.exe",
						Parameters = "/C echo test & pause",
						Admin = false,
						ExactMatch = true
					},
					new ActionItem
					{
						Name = "Open google",
						Type = 1,
						Keywords = "Open google",
						Action = "https://google.com",
						Parameters = "",
						Admin = false,
						ExactMatch = true
					}
				};

				SaveActions(actions, "tasks.json");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error creating example tasks file:\n\n {ex.Message}");
			}
		}

		public static void createExampleSettingsFile()
		{
			try
			{
				List<UserPreferences> actions = new List<UserPreferences>
				{
					new UserPreferences
					{
						LaunchAtStartup = false,
						StartListeningAtStartup = true,
						InputSensitivity = 35,
						MaxSimultaneousMatches  = 1,
						VoiceGender  = 0,
						VoiceCountryCode  = 0,
						SpeechVolume  = 80
					},
				};

				SaveActions(actions, "settings.json");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error creating settings file:\n\n {ex.Message}");
			}
		}

		public static void SaveActions<T>(List<T> actions, string file)
		{
			try
			{
				string jsonString = JsonConvert.SerializeObject(actions, new JsonSerializerSettings
				{
					Formatting = Formatting.Indented
				});

				File.WriteAllText(file, jsonString);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error saving configuration to {file}:\n\n {ex.Message}");
			}
		}

		public static List<T> LoadJsonItems<T>(string file)
		{
			try
			{
				string json = File.ReadAllText(file);
				if (!string.IsNullOrWhiteSpace(json))
				{
					return JsonConvert.DeserializeObject<List<T>>(json);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading actions from {file}:\n\\n {ex.Message}");
			}

			// Return an empty list if no actions were loaded
			return new List<T>();
		}

		public static void AddItem(ActionItem newItem)
		{
			try
			{
				List<ActionItem> items = LoadJsonItems<ActionItem>("tasks.json");
				items.Add(newItem);
				SaveActions(items, "tasks.json");
			}
			catch (Exception ex) 
			{
				MessageBox.Show($"Error adding a new item to file: \n\n{ex.Message}");
			}
		}
	}

	public class ActionItem
	{
		public string Name { get; set; }
		public int Type { get; set; }
		public string Keywords { get; set; }
		public string Action { get; set; }
		public string Parameters { get; set; }
		public bool Admin { get; set; }
		public bool ExactMatch { get; set; }
	}

	public class UserPreferences
	{
		public bool LaunchAtStartup { get; set; }
		public bool StartListeningAtStartup { get; set; }
		public int InputSensitivity { get; set; }
		public int MaxSimultaneousMatches { get; set; }
		public int VoiceGender { get; set; }
		public int VoiceCountryCode { get; set; }
		public int SpeechVolume { get; set; }
	}
}
