namespace task7;
public sealed class CompletedShipment : Shipment
{
    public CompletedShipment(string trackingCode)
        : base()
    {
        TrackingCode = trackingCode;
    }

    public override void PrintShipment()
    {
        Console.WriteLine($"Completed Shipment: {TrackingCode}");
    }
}