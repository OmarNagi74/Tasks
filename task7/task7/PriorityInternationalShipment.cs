namespace task7;

public class PriorityInternationalShipment : InternationalShipment
{
    public PriorityInternationalShipment(
        string id,
        DeliveryAddress address,
        string description,
        decimal weight,
        decimal deliveryFee,
        string destinationCountry,
        decimal customsFee)
        : base(
            id,
            address,
            description,
            weight,
            deliveryFee,
            destinationCountry,
            customsFee)
    {
    }

    public sealed override void GenerateCustomsReport()
    {
        Console.WriteLine("Priority International Customs Report");
    }
}