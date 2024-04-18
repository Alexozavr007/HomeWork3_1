using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_1_3 {

    public class Author {

        string content;

        public string Content {
            get {
                return content;
            }
            set {
                content = value;
            }
        }

        public Author(string value) {
            Content = value;
        }

        public void Show() {
            var backUpColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = backUpColor;
        }

    }

}
