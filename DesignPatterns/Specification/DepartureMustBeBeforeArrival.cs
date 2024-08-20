namespace DesignPatterns.Specification
{
    public class DepartureMustBeBeforeArrival : ISpecification<Flight>
    {
        public bool IsSatisfiedBy(Flight flight)
        {
            return flight.Departure < flight.Arrival;
        }
    }
}