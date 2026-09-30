namespace task7;

public class StandardShipment:Shipment
{
    public StandardShipment(string id,decimal weight,  decimal deliveryFee,string description,
        DeliveryAddress destination)
        : base(id, description,weight,deliveryFee, destination)
    {
    }

    override public void PrintShipment()
    {
        Console.WriteLine("Standard Shipment");
        Console.WriteLine("----------------");
        base.PrintShipment();
    }
}