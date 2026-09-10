using D;
namespace Task5;

using System;

public struct Shipment
{
    private string trackingCode;
    private string description;
    private double weight;
    private double deliveryFee;

    public DeliveryAddress Destination { get; set; }

    public string TrackingCode
    {
        get { return trackingCode; }
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

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value > 0)
                weight = value;
        }
    }

    public double DeliveryFee
    {
        get { return deliveryFee; }
        private set
        {
            if (value > 0)
                deliveryFee = value;
        }
    }

    public double EstimatedCost
    {
        get { return DeliveryFee + (Weight * 5); }
    }

    public Shipment(
        string trackingCode,
        string description,
        double weight,
        double deliveryFee,
        DeliveryAddress destination)
    {
        this.trackingCode = "";

        this.description = "";
        this.weight = 0;
        this.deliveryFee = 0;

        if (!string.IsNullOrWhiteSpace(trackingCode))
            this.trackingCode = trackingCode;

        if (!string.IsNullOrWhiteSpace(description))
            this.description = description;

        if (weight > 0)
            this.weight = weight;

        if (deliveryFee > 0)
            this.deliveryFee = deliveryFee;

        Destination = destination;
        
    }
    
    public Shipment(string trackingCode)
    {
        this.trackingCode = trackingCode;
        this.description = "Unknown";
        this.weight = 1;
        this.deliveryFee = 50;
        this.Destination = new DeliveryAddress("Unknown", "Unknown", 1);
    }
    public void UpdateDeliveryFee(decimal newFee)
    {
        if (newFee > 0)
            DeliveryFee = (double)newFee;
    }

    public void PrintShipment()
    {
        Console.WriteLine("Tracking Code: " + TrackingCode);
        Console.WriteLine("Description: " + Description);
        Console.WriteLine("Weight: " + Weight);
        Console.WriteLine("Delivery Fee: " + DeliveryFee);
        Console.WriteLine("Destination: " + Destination.GetFullAddress());
        Console.WriteLine("Estimated Cost: " + EstimatedCost);
    }
    
    
}
