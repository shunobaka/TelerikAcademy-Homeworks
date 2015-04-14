namespace ExtensionMethods
{
    using System.Text;

    public static class SBSubstringExtension
    {
        public static void Substring(this StringBuilder text, int index, int length)
        {
            string substring = text.ToString().Substring(index, length);
            text.Clear();
            text.Append(substring);
        }
    }
}
