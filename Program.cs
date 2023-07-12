// See https://aka.ms/new-console-template for more information
List<Product> products = new List<Product>()
{
  new Product()
  {
    Name = "Football",
    Price = 15,
    Sold = false,
    StockDate = new DateTime(2022, 10, 20),
    ManufactureYear = 2010
  },
  new Product()
  {
    Name = "Hockey Stick",
    Price = 12,
    Sold = true,
    StockDate = new DateTime(2023, 01, 20),
    ManufactureYear = 2013
  },
  new Product() 
  {
    Name = "Soccer Ball",
    Price = 24,
    Sold = false,
    StockDate = new DateTime(2022, 11, 20),
    ManufactureYear = 2021
  },
  new Product()
  {
    Name = "Golf Club",
    Price = 35,
    Sold = false,
    StockDate = new DateTime(2021, 10, 21),
    ManufactureYear = 2016
  },
  new Product()
  {
    Name = "Tennis Ball",
    Price = 5,
    Sold = false,
    StockDate = new DateTime(2022, 6, 10),
    ManufactureYear = 2015
  },
  new Product()
  {
    Name = "Baseball",
    Price = 20,
    Sold = false,
    StockDate = new DateTime(2021, 5, 20),
    ManufactureYear = 2021
  }
};

string greeting = @"Welcome to Thrown for a Loop
Your one stop-shop for used sporting equipment.";

Console.WriteLine(greeting);

Console.WriteLine("Products:");

for (int i = 0; i < products.Count; i++)
{
  Console.WriteLine($"{i + 1}. {products[i].Name}");
}

Console.WriteLine("Please enter a product number: ");

int response = int.Parse(Console.ReadLine().Trim());

while (response > products.Count || response < 1) 
{
  Console.WriteLine("You didn't choose anything, try again!");
  response = int.Parse(Console.ReadLine().Trim());
}

DateTime now = DateTime.Now;

Product chosenProduct = products[response - 1];
Console.WriteLine($"You chose: {chosenProduct.Name}, which costs {chosenProduct.Price} dollars and is {(chosenProduct.Sold ? "" : "not ")}sold.");

Console.WriteLine(chosenProduct);
