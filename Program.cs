// See https://aka.ms/new-console-template for more information
List<Product> products = new List<Product>()
{
  new Product()
  {
    Name = "Football",
    Price = 15.00M,
    Sold = false,
    StockDate = new DateTime(2022, 10, 20),
    ManufactureYear = 2010,
    Condition = 4.2
  },
  new Product()
  {
    Name = "Hockey Stick",
    Price = 12.97M,
    Sold = true,
    StockDate = new DateTime(2023, 01, 20),
    ManufactureYear = 2013,
    Condition = 3.4
  },
  new Product() 
  {
    Name = "Soccer Ball",
    Price = 24.45M,
    Sold = false,
    StockDate = new DateTime(2022, 11, 20),
    ManufactureYear = 2021,
    Condition = 5.0
  },
  new Product()
  {
    Name = "Golf Club",
    Price = 35.43M,
    Sold = false,
    StockDate = new DateTime(2021, 10, 21),
    ManufactureYear = 2016,
    Condition = 2.4
  },
  new Product()
  {
    Name = "Tennis Ball",
    Price = 5.64M,
    Sold = false,
    StockDate = new DateTime(2022, 6, 10),
    ManufactureYear = 2015,
    Condition = 4.3
  },
  new Product()
  {
    Name = "Baseball",
    Price = 20.36M,
    Sold = false,
    StockDate = new DateTime(2021, 5, 20),
    ManufactureYear = 2021, 
    Condition = 1.5
  }
};

string greeting = @"Welcome to Thrown for a Loop
Your one stop-shop for used sporting equipment.";

Console.WriteLine(greeting);

string choice = null;
while (choice != "0")
{
  Console.WriteLine(@"Choose an option:
  0. Exit
  1. View All Products
  2. View Product Details");
  choice = Console.ReadLine();
  if (choice == "0")
  {
    Console.WriteLine("Goodbye!");
  }
  else if (choice == "1")
  {
    ListProducts();
  } 
  else if (choice == "2")
  {
    ViewProductDetails();
  }
}

void ViewProductDetails ()
{
ListProducts();
for (int i = 0; i < products.Count; i++)
{
  Console.WriteLine($"{i + 1}. {products[i].Name}");
}

Product chosenProduct = null;

while (chosenProduct == null)
{
  Console.WriteLine("Please enter a product number: ");
  try
  {
    int response = int.Parse(Console.ReadLine().Trim());
    chosenProduct = products[response - 1];
  }
  catch (FormatException)
  {
    Console.WriteLine("Please type only integers!");
  }
  catch (ArgumentOutOfRangeException)
  {
    Console.WriteLine("Please choose an existing item only!");
  }
  catch (Exception ex)
  {
    Console.WriteLine(ex);
    Console.WriteLine("Do better!");
  }
}
Console.WriteLine($"You chose: {chosenProduct.Name}, which costs {chosenProduct.Price} dollars and is {(chosenProduct.Sold ? "" : "not ")}sold. Its condition is {chosenProduct.Condition}");

}

void ListProducts() 
{
  decimal totalValue = 0.0M;
  foreach (Product product in products)
  {
    if (!product.Sold)
    {
      totalValue += product.Price;
    }
  }
  Console.WriteLine($"Total inventory value: {totalValue}");
  Console.WriteLine("Products: ");
  for (int i = 0; i < products.Count; i++)
  {
    Console.WriteLine($"{i + 1}. {products[i].Name}");
  }
}
