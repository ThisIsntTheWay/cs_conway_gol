using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;

// This class reads and writes a JSON config file

namespace Game_Of_Life.Configuration {

    class Configurator {
        public bool drawGrid { get; set; }
        public bool verbosity { get; set; }
        public int simSpeed { get; set; }
        private static string cfgFile = @".\config.json";

        /// <summary>
        /// Parses a configuration file
        /// </summary>
        public Configurator parseConfiguration() {
            if (File.Exists(cfgFile)) {
                string configContents = File.ReadAllText(cfgFile);
                Configurator f = JsonConvert.DeserializeObject<Configurator>(configContents);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[c] drawGrid: {0}, verbosity: {1}, simSpeed: {2}", f.drawGrid, f.verbosity, f.simSpeed);
                Console.ResetColor();

                return f;
            } else {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Configuration file '{0}' not found, creating...", cfgFile);
                Console.ResetColor();

                // Create config with base values
                var c = new Configurator();
                c.drawGrid = true;
                c.verbosity = false;
                c.simSpeed = 10;

                File.WriteAllText(cfgFile, JsonConvert.SerializeObject(c));

                return c;
            }
        }
    }
}