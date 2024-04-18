using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_1_3 {
    internal class Content {

        string innerText;

        public string InnerText {
            get {
                return innerText;
            }
            set {
                innerText = value;
            }
        }

        public Content(string value) {
            InnerText = value;
        }

        public void Show() {
            var backUpColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(InnerText);
            Console.ForegroundColor = backUpColor;
        }
    }
}
