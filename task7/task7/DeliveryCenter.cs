namespace task7;

public class DeliveryCenter
{
    public Driver driver { get; set; }
    public string CenterName { get; set; }

    private Shipment[] shipments = new Shipment[20];

    public Shipment this[int index]
    {
        get
        {
            if (index >= 0 && index < shipments.Length)
                return shipments[index];

            return default;
        }

        set
        {
            if (index >= 0 && index < shipments.Length)
                shipments[index] = value;
        }
    }

    public void AddShipment(Shipment shipment)
    {
        for (int i = 0; i < shipments.Length; i++)
        {
            if (shipments[i] == null)
            {
                shipments[i] = shipment;
                return;
            }
        }
    }
    public bool RemoveShipment(string trackingCode)
    {
        for (int i = 0; i < shipments.Length; i++)
        {
            if (shipments[i] != null &&
                shipments[i].TrackingCode == trackingCode)
            {
                shipments[i] = null;
                return true;
            }
        }

        return false;
    }
    public void printshipments()
    {
        foreach (Shipment shipment in shipments)
        {
            if (shipment != null)
            {
                shipment.PrintShipment();
            }
        }
    }
}