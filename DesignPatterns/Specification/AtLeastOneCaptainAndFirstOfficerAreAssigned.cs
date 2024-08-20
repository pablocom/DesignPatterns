namespace DesignPatterns.Specification
{
    public class AtLeastOneCaptainAndFirstOfficerAreAssigned : ISpecification<Flight>
    {
        public bool IsSatisfiedBy(Flight flight)
        {
            return flight.Captains > 0 && flight.FirstOfficers > 0;
        }
    }
}