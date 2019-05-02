using System.CodeDom.Compiler;
using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace mp3Player
{
    public class PlayerConfig
    {
        private const string REG_KEY = "JoeMp3Player";
        private const int DEFAULT_TOP = 100;
        private const int DEFAULT_LEFT = 100;
        private const int DEFAULT_WIDTH = 420;
        private const int DEFAULT_HEIGHT = 255;
        private string ConfigFileName = Path.Combine("MP3Config.cfg");
        private JObject ConfigJSON { get; set; }

        public static bool Initialized { get; set; } = false;
        public int Top { get;set;  }
        public int Left { get; set;  }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Volume { get; set; }
        public int CurrentFileIndex { get; set; }

        public string LastMediaFileName { get; set; }
        public List<string> MediaPlayList { get; set; }
        public double LastMediaPosition { get; set; }
        private RegistryKey key;
        public clsFileManager MediaFiles { get; set; }

        public PlayerConfig()
        {
            Initialized = true;
            LoadConfig();
        }

        ~PlayerConfig()
        {
            //SaveConfig();
        }

        private string CreateConfigFile(string filename)
        {
            JObject json = new JObject();

            json.Add("top", 26 );
            json.Add("left", 26 );
            json.Add("height", 250);
            json.Add("lastMediaFileName", "");
            json.Add("lastMediaPosition", 0);
            json.Add("mediaFileList","[]");
            json.Add("volume", 0);
            json.Add("width", 400);
            json.Add("currentFileIndex", 0);
            File.WriteAllText(ConfigFileName, json.ToString());

            return json.ToString();
        }

        private void LoadConfig()
        {
            string mediaList = "";

            if (File.Exists(ConfigFileName))
            {
                ConfigJSON = JObject.Parse(File.ReadAllText(ConfigFileName));
            }
            else
            {
                ConfigJSON = JObject.Parse(CreateConfigFile(ConfigFileName));
            }
            Top = ConfigJSON.GetValue("top").Value<int>();
            Left = ConfigJSON.GetValue("left").Value<int>();
            Width = ConfigJSON.GetValue("width").Value<int>();
            Height = ConfigJSON.GetValue("height").Value<int>();
            Volume = ConfigJSON.GetValue("volume").Value<int>();
            LastMediaFileName = ConfigJSON.GetValue("lastMediaFileName").Value<string>();
            LastMediaPosition = ConfigJSON.GetValue("lastMediaPosition").Value<double>();
            CurrentFileIndex = ConfigJSON.GetValue("currentFileIndex").Value<int>();
            mediaList = ConfigJSON.GetValue("mediaFileList").Value<string>();
            MediaPlayList = mediaList.Split(',').ToList();
        }

        private void SaveConfig()
        {
            string mediaFiles = string.Join(", ", MediaPlayList);

            ConfigJSON["top"] = Top;
            ConfigJSON["mediaFileList"] = mediaFiles;
            ConfigJSON["left"] =  Left;
            ConfigJSON["width"] = Width;
            ConfigJSON["height"] = Height;
            ConfigJSON["lastMediaFileName"] = (LastMediaFileName == null)?"":LastMediaFileName;
            ConfigJSON["lastMediaPosition"] = LastMediaPosition;
            ConfigJSON["volume"] =  Volume;
            ConfigJSON["currentFileIndex"] = CurrentFileIndex;
            File.WriteAllText(ConfigFileName, ConfigJSON.ToString());
        }

        public void SaveConfig( int top, int left, int width, int height, string mediaFileName, int currentFileIndex, List<string> playList, double mediaPosition, int volume)
        {
            Top = top;
            Left = left;
            Width = width;
            Height = height;
            Volume = volume;
            LastMediaFileName = mediaFileName;
            MediaPlayList = playList;
            LastMediaPosition = mediaPosition;
            CurrentFileIndex = currentFileIndex;
            SaveConfig();
        }

        public void ResetConfig()
        {
            Top = DEFAULT_TOP;
            Left = DEFAULT_LEFT;
            Width = DEFAULT_WIDTH;
            Height = DEFAULT_HEIGHT;
            LastMediaPosition = 0.0f;
            Volume = 50;
            LastMediaFileName = "";
            MediaPlayList = new List<string>();

            ConfigJSON["top"] =  Top;
            ConfigJSON["left"] = Left;
            ConfigJSON["width"] = Width;
            ConfigJSON["height"] = Height;
            ConfigJSON["volume"] = Volume;
            ConfigJSON["lastMediaFileName"] = LastMediaFileName;
            ConfigJSON["lastMediaPosition"] = LastMediaPosition;
            SaveConfig();
        }
    }
}
