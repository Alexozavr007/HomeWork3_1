using HomeWork3_1_6;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

var home = new Address();
home.City = "Київ";
home.Street = "Мажорна";
home.Country = "Україна";
home.Index = "18000";
home.House = "23";
home.Apartament = "31";

Console.WriteLine(home.FullAddress());
