using System;
using System.Collections.Generic;

namespace DesignPatterns.Specification
{
    public class Flight
    {
        public DateTime Departure { get; private set; }
        public DateTime Arrival { get; private set; }
        public int Captains { get; private set; }
        public int FirstOfficers { get; private set; }

        private readonly IEnumerable<ISpecification<Flight>> _invariantRules = new ISpecification<Flight>[]
        {
            new DepartureMustBeBeforeArrival(),
            new AtLeastOneCaptainAndFirstOfficerAreAssigned(),
            new OrSpecification<Flight>(
                new DepartureMustBeBeforeArrival(),
                new AtLeastOneCaptainAndFirstOfficerAreAssigned()
            )
        };

        public Flight(DateTime departure, DateTime arrival)
        {
            Departure = departure;
            Arrival = arrival;

            EnforceInvariants();
        }

        private void EnforceInvariants()
        {
            foreach (var invariantRule in _invariantRules)
            {
                if (!invariantRule.IsSatisfiedBy(this))
                    throw new Exception("Invariant for Flight is not satisfied");
            }
        }
    }

    public class OrSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _firstSpecification;
        private readonly ISpecification<T> _secondSpecification;

        public OrSpecification(ISpecification<T> firstSpecification, ISpecification<T> secondSpecification)
        {
            _firstSpecification = firstSpecification;
            _secondSpecification = secondSpecification;
        }

        public bool IsSatisfiedBy(T entity)
        {
            return _firstSpecification.IsSatisfiedBy(entity) || _secondSpecification.IsSatisfiedBy(entity);
        }
    
    }
}