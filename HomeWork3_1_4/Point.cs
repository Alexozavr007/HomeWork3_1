using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_1_4 {
    internal class Point {
        int x, y;
        string name;

        public int X {
            get {
                return x;
            }           
        }

        public int Y {
            get {
                return y;
            }
        }

        public string Name {
            get {
                return name;
            }            
        }

        public Point(int x, int y, string name) {
            this.x = x;
            this.y = y;
            this.name = name;
        }



    }
}
