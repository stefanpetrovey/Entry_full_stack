namespace VestelTask
{
    public class TextReverser
    {
        public string Reverse(string input)
        {
            if (input is null) return string.Empty;

            var chars = input.ToCharArray();
            
            Array.Reverse(chars);
            
            return new string(chars);
        }
    }

}
