namespace Exe1.Entities
{
    public class DomainException : System.Exception
    {
        public DomainException() { }
        public DomainException(string message) : base(message) {
        }
    }
}