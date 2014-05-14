namespace DotNetdit.Utilities
{
    internal static class StringUtils
    {
        internal static string FormatWith(this string source, params object[] args) {
            source.ThrowIfNull();
            args.ThrowIfNull();

            return string.Format(source, args);
        }
    }
}
