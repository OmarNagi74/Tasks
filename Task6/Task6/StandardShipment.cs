namespace Task6;

public class StandardShipment:Shipment
{
    public StandardShipment(string id,decimal weight,  decimal deliveryFee,string description,
     DeliveryAddress destination)
        : base(id, description,weight,deliveryFee, destination)
    {
    }

}