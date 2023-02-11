namespace DineshPortfolio.Helper
{
    public class Truncate
    {
        public string TruncateDescription(string description, int length)
        {
            if (description.Length <= length)
                return description;
            return description.Substring(0, length) + "...";
        }
    }
}
