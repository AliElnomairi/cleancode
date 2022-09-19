namespace cleancode.shared.Abstraction.Common
{
    public abstract class ParkingException : Exception
    {
        public ParkingException(string message) : base(message) { }
    }
}
