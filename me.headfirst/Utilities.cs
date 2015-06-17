using System.Globalization;

namespace me.headfirst
{
    public static class Utilities
    {
        public static string FloatToString(float number)
        {
            return number.ToString("F", CultureInfo.CurrentCulture);
        }
    }
}
