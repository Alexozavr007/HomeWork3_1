using HomeWork3_1_6;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

var home = new Address();
home.City = "Popa";
home.Street = "Popena";
home.Country = "Pop";
home.Index = "Popch";
home.House = "Poop";
home.Apartament = "Popi";

Console.WriteLine(home.FullAddress());
