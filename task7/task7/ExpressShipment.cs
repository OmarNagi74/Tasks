namespace task7;
public class ExpressShipment : Shipment
{
    private decimal extraFee;

    public decimal ExtraFee
    {
        get
        {
            return extraFee;
        }
        set
        {
            if (value >= 0)
                extraFee = value;
        }
    }

    public override decimal EstimatedCost
    {
        get
        {
            return DeliveryFee + (Weight * 5) + ExtraFee;
        }
    }

    public ExpressShipment(
        string id,
        DeliveryAddress address
        ,string description,
        decimal weight,
        decimal deliveryFee,
        decimal extraFee)
        : base(id ,description, weight, deliveryFee,address)
    {
        ExtraFee = extraFee;
    }

    override public void PrintShipment()
    {
        Console.WriteLine("Express Shipment");
        Console.WriteLine("----------------");
        base.PrintShipment();
        Console.WriteLine($"Extra Fee: {ExtraFee}");
    }
}