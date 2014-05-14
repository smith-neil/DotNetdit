using System;

namespace DotNetdit.Utilities
{
    internal static class ExceptionUtils
    {
        internal static void ThrowIfNull<T>(this T source, string paramName = null, string message = null)
            where T : class
        {
            if (source == null)
                throw new ArgumentNullException(paramName, message);
        }
    }
}
