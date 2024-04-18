using HomeWork1_3;

Console.Write("Enter the width of the rectangle: ");
var width = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the height of the rectangle: ");
var height = Convert.ToInt32(Console.ReadLine());

var r = new Rectangle(height, width);
Console.WriteLine($"Area: {r.Area}");
Console.WriteLine($"Perimeter: {r.Perimeter}");