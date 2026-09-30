namespace task7;


public class InternationalShipment : Shipment
{
    private string destinationCountry;
    private decimal customsFee;

    public string DestinationCountry
    {
        get
        {
            return destinationCountry;
        }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                destinationCountry = value;
        }
    }

    public decimal CustomsFee
    {
        get
        {
            return customsFee;
        }
        set
        {
            if (value >= 0)
                customsFee = value;
        }
    }

    public override decimal EstimatedCost
    {
        get
        {
            return DeliveryFee + (Weight * 5) + CustomsFee;
        }
    }
    public InternationalShipment(
        string id,
        DeliveryAddress address,
        string description,
        decimal weight,
        decimal deliveryFee,
        string destinationCountry,
        decimal customsFee)
        : base(id, description, weight, deliveryFee, address)
    {
        DestinationCountry = destinationCountry;
        CustomsFee = customsFee;
    }

    override public void PrintShipment()
    {
        Console.WriteLine("International Shipment");
        Console.WriteLine("----------------");
        base.PrintShipment();
        Console.WriteLine($"Destination Country: {DestinationCountry}");
        Console.WriteLine($"Customs Fee: {CustomsFee}");
    }
    public virtual void GenerateCustomsReport()
    {
        Console.WriteLine("International Customs Report");
    }
}