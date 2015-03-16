namespace StringBuilder.Substring
{
    using System;
    using System.Text;

    public static class Extension
    {
        public static StringBuilder Substring(this StringBuilder sb, int startIndex, int length)
        {
            if (startIndex < 0 || startIndex >= sb.Length || length < 0 || startIndex + length > sb.Length)
            {
                throw new IndexOutOfRangeException();
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                result.Append(sb[startIndex + i]);
            }

            return result;
        }
    }
}
