using HomeWork3_1_4;

Console.OutputEncoding = System.Text.Encoding.Unicode;


var pA = new Point(10, 12, "A");
var pB = new Point(12, 9, "B");
var pC = new Point(12, 6, "C");
var pD = new Point(10, 3, "D");
var pE = new Point(8, 9, "E");

var triangle = new Figure(pA, pB, pC);
var rect = new Figure(pA, pB, pC, pD);
var pentagon = new Figure(pA, pB, pC, pD, pE);

Console.WriteLine($"Perimeter of figure {triangle.Type} is {triangle.PerimeterCalculator()}");
Console.WriteLine($"Perimeter of figure {rect.Type} is {rect.PerimeterCalculator()}");
Console.WriteLine($"Perimeter of figure {pentagon.Type} is {pentagon.PerimeterCalculator()}");