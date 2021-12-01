namespace DesignPatterns.Strategy.Models;

public class ShippingDetails
{
    public string OriginCountry { get; }
    public string DestinationCountry { get; }
    public string DestinationState { get; }

    public ShippingDetails(string originCountry, string destinationCountry, string destinationState = "")
    {
        OriginCountry = originCountry;
        DestinationCountry = destinationCountry;
        DestinationState = destinationState;
    }

    public bool IsNational()
    {
        return OriginCountry == DestinationCountry;
    }
}
