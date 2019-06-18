using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Bot.Structs;
using Newtonsoft.Json;

namespace Bot.Configurations
{
    public static class TokenConfiguration
    {
        private const string ConfigFolder = "Configs";

        private const string ConfigFile = "Config.json";

        public static ConfigData Config;

        static TokenConfiguration()
        {
            if (!Directory.Exists(ConfigFolder))
                Directory.CreateDirectory(ConfigFolder);

            if (!File.Exists(ConfigFolder + "/" + ConfigFile))
            {
                Config = new ConfigData();
                var json = JsonConvert.SerializeObject(Config, Formatting.Indented);
                File.WriteAllText(ConfigFolder + "/" + ConfigFile, json);
            }
            else
            {
                var json = File.ReadAllText(ConfigFolder + "/" + ConfigFile);
                Config = JsonConvert.DeserializeObject<ConfigData>(json);
            }
        }
    }
}
