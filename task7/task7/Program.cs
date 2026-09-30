namespace task7;

class Program
{
    static void Main(string[] args)
    {
        #region q1
       /* Overloading  → Same class → Different parameters → Compile time
        Overriding   → Parent/Child → Same method → Runtime

            Static Binding  → "Which method?" decided early → Compile time
        Dynamic Binding → "Which method?" decided later → Runtime*/
        #endregion

        #region q2
/*
 * sealed class
       ↓
   No one can inherit the class.
   
   sealed method
       ↓
   Inheritance is allowed,
   but no one can override this method anymore.
 */

        #endregion
         // a. Create a Driver
        Driver driver = new Driver(
            1,
            "Ahmed Ali",
            "01012345678"
        );

        // b. Create a DeliveryCenter
        DeliveryCenter center = new DeliveryCenter();

        // c. Assign the Driver to the DeliveryCenter
        center.driver= driver;


        // d. Create one StandardShipment
        StandardShipment standard = new StandardShipment(
            "S001",
            12,
            14,
            "Clothes",
            new DeliveryAddress()
            
        );


        // e. Create one ExpressShipment
        ExpressShipment express =new ExpressShipment("1",new DeliveryAddress(),description: "Clothes",weight: 10,deliveryFee: 50,extraFee: 100);


        // f. Create one InternationalShipment
        InternationalShipment international =
            new InternationalShipment(
                "S003",
                new DeliveryAddress(),
                "Electronics",
                10,
                100,
                "Germany",
                200
            );


        // g. Add all shipments to the DeliveryCenter
        center.AddShipment(standard);
        center.AddShipment(express);
        center.AddShipment(international);


        // h. Print all shipments using PrintAllShipments()
        Console.WriteLine("=== All Shipments ===");

        center.printshipments();


        // i. Call DeliveryHelper.PrintShipmentDetails()
        // for each shipment
        Console.WriteLine("\n=== DeliveryHelper ===");

        DeliveryHelper.PrintShipmentDetails(standard);
        DeliveryHelper.PrintShipmentDetails(express);
        DeliveryHelper.PrintShipmentDetails(international);


        // j. Demonstrate both versions of UpdateWeight()

        // Version 1: update weight directly
        standard.updateweight(15);

        // Version 2: update weight + packing weight
        express.updateweight(10, 2);


        // k. Shipment[] holding mixed types
        Shipment[] shipments =
        {
            standard,
            express,
            international
        };

        Console.WriteLine("\n=== Mixed Shipment Array ===");

        foreach (Shipment shipment in shipments)
        {
            shipment.PrintShipment();
        }


        // l. Demonstrate sealed class
        CompletedShipment completed =
            new CompletedShipment("21");

        // CompletedShipment can be created,
        // but another class cannot inherit from it
        // because it is sealed.


        // Demonstrate sealed method
        PriorityInternationalShipment priority =
            new PriorityInternationalShipment(
                "S004",
                new DeliveryAddress(),
                "Documents",
                4,
                150,
                "France",
                300
            );

        priority.GenerateCustomsReport();

        // A class inheriting from PriorityInternationalShipment
        // cannot override GenerateCustomsReport()
        // because the method is sealed.
    }
        
    }
