// See https://aka.ms/new-console-template for more information
using CsharpOOP.Models;



//instance alma
//Car sınıfı objecten türüyor
Car car = new Car();
car.Brand = "Renault";
car.Model = "2019";
car.Speed = 100;
car.Gear = 5;
Console.WriteLine($"{ car.Model} ,{car.ProductionDate} ");
car.ColorSetting("Yellow");
Car car1 = new Car("BMW");
Console.WriteLine(car1.Brand);

Console.WriteLine("**************");
Writer writer = new Writer();
writer.Name = "Gulsun";
writer.SurName = "Ciftci";
writer.Write("Hayat");

Console.WriteLine("**************");
Product product = new Product();
product.c = 15;
Console.WriteLine(product.c);

Console.WriteLine("**************");
Console.WriteLine("Encapsulation");
User user = new User("Gulsun","1234");
Console.WriteLine(user.Password);

Console.WriteLine("**************");
Console.WriteLine("Inheritance");
Archer archer = new Archer();
Console.WriteLine(archer.Damage);
Wizard wizard = new Wizard();
Console.WriteLine(wizard.DoMagic(archer.Damage));