using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_1_3 {
    internal class Title {
        string content;

        public string Content {
            get {
                return content;
            }
            set {
                content = value;
            }
        }

        public Title(string value) {
            Content = value;
        }

        public void Show() {
            var backUpColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = backUpColor;
        }
    }
}
