using Microsoft.Win32;
using System.Collections.Generic;

namespace mp3Player
{
    public class PlayerConfig
    {
        private const string REG_KEY = "JoeMp3Player";
        private const int DEFAULT_TOP = 100;
        private const int DEFAULT_LEFT = 100;
        private const int DEFAULT_WIDTH = 420;
        private const int DEFAULT_HEIGHT = 255;

        private int _top;
        private int _left;
        private int _width;
        private int _height;
        private int _volume;
        private double _lastMediaPosition;

        public static bool Initialized { get; set; } = false;
        public int Top { get { return _top; } set { _top = value; } }
        public int Left { get { return _left; } set { _left = value; } }
        public int Width { get { return _width; } set { _width = value; } }
        public int Height { get { return _height; } set { _height = value; } }
        public int Volume {  get { return _volume; } set { _volume = value; } }

        public string LastMediaFileName { get; set; }
        public List<string> mediaPlayList { get; set; }
        public double LastMediaPosition { get { return _lastMediaPosition; } set { _lastMediaPosition = value; } }
        private RegistryKey key;

        public PlayerConfig()
        {
            key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\" + REG_KEY, true);
            if ( key == null)
            {
                key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\" + REG_KEY, true);
                Initialized = false;
            }
            else
            {
                Initialized = true;
                LoadConfig();
            }
        }

        ~PlayerConfig()
        {
            key.Close();
        }

        private void LoadConfig()
        {
            if ( key.GetValue("Top") != null ) int.TryParse(key.GetValue("Top").ToString(), out _top);
            if ( key.GetValue("Left") != null) int.TryParse(key.GetValue("Left").ToString(), out _left);
            if ( key.GetValue("Width") != null ) int.TryParse(key.GetValue("Width").ToString(), out _width);
            if ( key.GetValue("Height") != null ) int.TryParse(key.GetValue("Height").ToString(), out _height);
            if (key.GetValue("Volume") != null) int.TryParse(key.GetValue("Volume").ToString(), out _volume);
            if ( key.GetValue("LastMediaFileName") != null ) LastMediaFileName = key.GetValue("LastMediaFileName").ToString();
            if (key.GetValue("LastMediaPosition") != null) double.TryParse(key.GetValue("LastMediaPosition").ToString(), out _lastMediaPosition);
        }

        private void SaveConfig()
        {
            key.SetValue("Top", Top);
            key.SetValue("Left", Left);
            key.SetValue("Width", Width);
            key.SetValue("Height", Height);
            key.SetValue("LastMediaFileName", (LastMediaFileName==null)?"":LastMediaFileName);
            key.SetValue("LastMediaPosition", LastMediaPosition);
            key.SetValue("Volume", Volume);

            key.Flush();
        }

        public void SaveConfig( int top, int left, int width, int height, string mediaFileName, List<string> playList, double mediaPosition, int volume)
        {
            _top = top;
            _left = left;
            _width = width;
            _height = height;
            _volume = volume;
            LastMediaFileName = mediaFileName;
            mediaPlayList = playList;
            LastMediaPosition = mediaPosition;
            SaveConfig();
        }

        public void ResetConfig()
        {
            _top = DEFAULT_TOP;
            _left = DEFAULT_LEFT;
            _width = DEFAULT_WIDTH;
            _height = DEFAULT_HEIGHT;
            _lastMediaPosition = 0.0f;
            _volume = 50;
            LastMediaFileName = "";

            key.SetValue("Top", Top);
            key.SetValue("Left", Left);
            key.SetValue("Width", Width);
            key.SetValue("Height", Height);
            key.SetValue("Volume", Volume);
            key.SetValue("LastMediaFileName", LastMediaFileName);
            key.SetValue("LastMediaPosition", LastMediaPosition);
            key.Flush();
        }
    }
}
