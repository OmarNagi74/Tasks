namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        #region q1

        // a) A class is a reference type, while a struct is a value type.
// Classes store a reference to an object, while structs store the actual value.
// Classes support inheritance, while structs do not support class inheritance.
// Classes can be null, while structs normally cannot be null.
// b) Classes are more suitable for large applications because they support
// inheritance, polymorphism, and complex relationships between objects.
// They are better for representing large and complex objects with behavior.

        #endregion

        #region q2
        // shipment
        //expressshipment
        //trackcode
        // Inheritance allows us to reuse common code from a parent class
         // instead of duplicating the same code in multiple classes.
         // It reduces code duplication and makes the application easier to maintain.

        #endregion

        #region practical
    DeliveryCenter center = new DeliveryCenter();
    Console.WriteLine("");
    Console.Write("Enter center name: ");
    center.CenterName = Console.ReadLine();

    Console.WriteLine("\n--- Standard Shipment ---");

    Console.Write("Tracking Code: ");
    string trackingCode1 = Console.ReadLine();

    Console.Write("Weight: ");
    decimal weight1 = decimal.Parse(Console.ReadLine());

    Console.Write("Delivery Fee: ");
    decimal deliveryFee1 = decimal.Parse(Console.ReadLine());
    Console.WriteLine("des");
    string description = Console.ReadLine();

    Console.Write("City: ");
    string city1 = Console.ReadLine();

    Console.Write("Street: ");
    string street1 = Console.ReadLine();

    Console.Write("Building Number: ");
    int buildingNumber1 = int.Parse(Console.ReadLine());

    DeliveryAddress address1 =
        new DeliveryAddress(city1, street1, buildingNumber1);

    StandardShipment standard =
        new StandardShipment(trackingCode1, weight1, deliveryFee1, description, address1);

    Console.WriteLine("\n--- Express Shipment ---");

    Console.Write("Tracking Code: ");
    string trackingCode2 = Console.ReadLine();

    Console.Write("Weight: ");
    decimal weight2 = decimal.Parse(Console.ReadLine());

    Console.Write("Delivery Fee: ");
    decimal deliveryFee2 = decimal.Parse(Console.ReadLine());

    Console.Write("Extra Fee: ");
    decimal extraFee = decimal.Parse(Console.ReadLine());

    Console.Write("City: ");
    string city2 = Console.ReadLine();

    Console.Write("Street: ");
    string street2 = Console.ReadLine();

    Console.WriteLine("des");
    string description2 = Console.ReadLine();
    Console.Write("Building Number: ");
    int buildingNumber2 = int.Parse(Console.ReadLine());

    DeliveryAddress address2 =
        new DeliveryAddress(city2, street2, buildingNumber2);

    ExpressShipment express =
        new ExpressShipment(trackingCode2, address2, description2, weight2, deliveryFee2, extraFee);

    Console.WriteLine("\n--- International Shipment ---");

    Console.Write("Tracking Code: ");
    string trackingCode3 = Console.ReadLine();

    Console.Write("Weight: ");
    decimal weight3 = decimal.Parse(Console.ReadLine());

    Console.Write("Delivery Fee: ");
    decimal deliveryFee3 = decimal.Parse(Console.ReadLine());

    Console.Write("Destination Country: ");
    string country = Console.ReadLine();

    Console.Write("Customs Fee: ");
    decimal customsFee = decimal.Parse(Console.ReadLine());

    Console.Write("City: ");
    string city3 = Console.ReadLine();

    Console.Write("Street: ");
    string street3 = Console.ReadLine();

    Console.Write("Building Number: ");
    int buildingNumber3 = int.Parse(Console.ReadLine());

    DeliveryAddress address3 =
        new DeliveryAddress(city3, street3, buildingNumber3);
    Console.WriteLine("des");
    string description3 = Console.ReadLine();

    InternationalShipment international =
        new InternationalShipment(trackingCode3, address3, description3, weight3, deliveryFee3, country, customsFee);

    center.AddShipment(standard);
    center.AddShipment(express);
    center.AddShipment(international);

    Console.WriteLine("\n--- All Shipments ---");
    center.PrintAllShipments();

    Console.Write("\nEnter tracking code to search: ");
    int searchCode = int.Parse(Console.ReadLine());

    Shipment found = center[searchCode];

    if (found != null)
        Console.WriteLine("Shipment Found: " + found);
    else
        Console.WriteLine("Shipment Not Found");

    Console.Write("\nEnter tracking code to remove: ");
    string removeCode = Console.ReadLine();

    bool removed = center.RemoveShipment(removeCode);

    if (removed)
        Console.WriteLine("Shipment removed successfully.");
    else
        Console.WriteLine("Shipment not found.");

    Console.WriteLine("\n--- Remaining Shipments ---");
    center.PrintAllShipments();

        

        #endregion
        
    }
}