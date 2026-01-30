
namespace TechStore
{
    [Serializable]
    internal class InvalidGadgetException : Exception
    {
        public InvalidGadgetException()
        {
        }

        public InvalidGadgetException(string? message) : base(message)
        {
        }

        
    }
}