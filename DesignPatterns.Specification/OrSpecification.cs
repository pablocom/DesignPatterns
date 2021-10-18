namespace DesignPatterns.Specification
{
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