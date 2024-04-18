using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_1_4 {
    internal class Figure {
        Point a,b,c,d,e;
        public string Type { get; private set; }

        public Figure(Point a, Point b, Point c) : this(a, b, c, null, null){ 
        }

        public Figure(Point a, Point b, Point c,Point d) : this(a, b, c, d, null) {
        }

        public Figure(Point a, Point b, Point c, Point d, Point e) {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;

            if (this.d == null) {
                Type = "Triangle";
            }else if (this.e == null) {
                Type = "Rectangle"; 
            }else { 
                Type = "Pentagon"; 
            }
        }

        public double LengthSide(Point A, Point B) {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public double PerimeterCalculator() {
            var AB = LengthSide(this.a, this.b);
            var BC = LengthSide(this.b, this.c);
            if (this.d == null) {
                var AC = LengthSide(this.a, this.c);
                return AB + BC + AC;
            } else if (this.e == null) {
                var CD = LengthSide(this.c, this.d);
                var DA = LengthSide(this.d, this.a);
                return AB + BC + CD + DA;
            } else {
                var CD = LengthSide(this.c, this.d);
                var DE = LengthSide(this.d, this.e);
                var EA = LengthSide(this.e, this.a);
                return AB + BC + CD + DE + EA;
            }
        }

    }
}
