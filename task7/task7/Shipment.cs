namespace task7;

public class Shipment
{
    private string trackingCode;
    private string description;
    private decimal weight;
    private decimal deliveryFee;
    private DeliveryAddress destination;


    public string TrackingCode
    {
        get { return trackingCode; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                trackingCode = value;
        }
    }

    public string Description
    {
        get { return description; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                description = value;
        }
    }

    public decimal Weight
    {
        get { return weight; }
        set
        {
            if (value > 0)
                weight = value;
        }
    }

    public decimal DeliveryFee
    {
        get { return deliveryFee; }
        set
        {
            if (value >= 0)
                deliveryFee = value;
        }
    }

    public DeliveryAddress Destination
    {
        get { return destination; }
        set { destination = value; }
    }


    public Shipment()
    {
        trackingCode = "Unknown";
        description = "Unknown";
        weight = 0;
        deliveryFee = 0;
        destination = new DeliveryAddress();
    }


    public Shipment(
        string trackingCode,
        string description,
        decimal weight,
        decimal deliveryFee,
        DeliveryAddress destination)
    {
        TrackingCode = trackingCode;
        Description = description;
        Weight = weight;
        DeliveryFee = deliveryFee;
        Destination = destination;
    }


    public virtual decimal EstimatedCost
    {
        get { return Weight * DeliveryFee; }
    }

    public void UpdateDeliveryFee(decimal newFee)
    {
        if (newFee >= 0)
            DeliveryFee = newFee;
    }


    public virtual void PrintShipment()
    {
        Console.WriteLine($"Tracking Code: {TrackingCode}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Weight: {Weight}");
        Console.WriteLine($"Delivery Fee: {DeliveryFee}");
        Console.WriteLine($"Estimated Cost: {EstimatedCost}");

        Console.WriteLine("Destination:");
        Destination.GetFullAddress();
    }

    public void updateweight(decimal newweight)
    {
        this.Weight = newweight;
    }

    public void updateweight(decimal newweight, decimal addpack)
    {
        this.Weight = newweight + addpack;
    }
}
