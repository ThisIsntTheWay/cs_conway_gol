using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;

// This class reads and writes a JSON config file

namespace Game_Of_Life.Configuration {

    class Configuration {
        public bool drawGrid { get; set; }
        public bool verbosity { get; set; }
        public int simSpeed { get; set; }
        private static string cfgFile = @".\config.json";

        /// <summary>
        /// Parses a configuration file
        /// </summary>
        public Configuration parseConfiguration() {
            if (File.Exists(cfgFile)) {
                string configContents = File.ReadAllText(cfgFile);
                Configuration f = JsonConvert.DeserializeObject<Configuration>(configContents);

                return f;
            } else {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Configuration file '{0}' not found, creating...", cfgFile);
                Console.ResetColor();

                // Create config with base values
                var c = new Configuration();
                c.drawGrid = true;
                c.verbosity = false;
                c.simSpeed = 10;

                File.WriteAllText(cfgFile, JsonConvert.SerializeObject(c));

                return c;
            }
        }
    }
}