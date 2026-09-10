using D;
namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        #region q1

        #region a

        // not changed

        #endregion

        #region b

        // changed

        #endregion

        #endregion

        #region q2

        //a make it private and use public properties
        //b it will be in ecpuslation

        #endregion

        #region q3
        
        DeliveryAddress address1 =
            new DeliveryAddress("Cairo", "Nasr City", 25);
        
        DeliveryAddress address2 = address1;
        
        address2.City = "Giza";
        address2.BuildingNumber = 50;
        Console.WriteLine("Original: " + address1.GetFullAddress());
        Console.WriteLine("Copy: " + address2.GetFullAddress());
         DeliveryCenter center = new DeliveryCenter();

        // b & c. Read and add 3 shipments
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Enter data for Shipment {i + 1}");

            Console.Write("Tracking Code: ");
            string trackingCode = Console.ReadLine();

            Console.Write("Description: ");
            string description = Console.ReadLine();

            Console.Write("Weight: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            double deliveryFee = double.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city = Console.ReadLine();

            Console.Write("Street: ");
            string street = Console.ReadLine();

            Console.Write("Building Number: ");
            int buildingNumber = int.Parse(Console.ReadLine());

            DeliveryAddress address =
                new DeliveryAddress(city, street, buildingNumber);

            Shipment shipment = new Shipment(
                trackingCode,
                description,
                weight,
                deliveryFee,
                address
            );

            center.AddShipment(shipment);

            Console.WriteLine();
        }

        
        Console.WriteLine("===== Shipments =====");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Shipment {i + 1}:");
            center[i].PrintShipment();
            Console.WriteLine();
        }
        
        Console.Write("Enter tracking code to search: ");
        string searchCode = Console.ReadLine();

        
        Shipment foundShipment = center[searchCode];

        
        if (!string.IsNullOrEmpty(foundShipment.TrackingCode))
        {
            foundShipment.PrintShipment();
        }
        else
        {
            Console.WriteLine("Shipment not found.");
        }

        
        Console.WriteLine("\n===== DeliveryAddress Copy =====");

        
        #endregion
        
    }
}