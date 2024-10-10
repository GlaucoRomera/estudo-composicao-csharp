using Orders;
using Orders.Enums;

Console.WriteLine("Enter client data: ");
Console.WriteLine("Name: ");
string name = Console.ReadLine()!;
Console.WriteLine("Email: ");
string email = Console.ReadLine()!;
Console.WriteLine("Birth date (DD/MM/YYYY: ");
string birthDate = Console.ReadLine()!;
DateTime birth = DateTime.Parse(birthDate);
Console.WriteLine("Enter order data:");
Console.WriteLine("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine()!);

Client client = new Client(name, email, birth);
Order order = new Order(DateTime.Now, status, client);

Console.WriteLine("How many items to this order?");
int num = int.Parse(Console.ReadLine()!);

for (int i = 0; i < num; i++)
{
    Console.WriteLine($"Enter #{i + 1} item data:");
    Console.WriteLine("Product name: ");
    string productName = Console.ReadLine()!;
    Console.WriteLine("Product Price: ");
    double productPrice = double.Parse(Console.ReadLine()!);

    Product product = new Product(productName, productPrice);

    Console.WriteLine("Quantity: ");
    int quantity = int.Parse(Console.ReadLine()!); 

    OrderItem item = new OrderItem(product, quantity, productPrice);

    order.AddItem(item);
       

}

Console.WriteLine(order);
Console.WriteLine(client);



