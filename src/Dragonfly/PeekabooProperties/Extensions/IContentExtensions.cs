namespace Dragonfly.PeekabooProperties.Extensions
{
    using Umbraco.Core.Models;

    public static class ContentExtensions
    {

        public static string GetPropertyValueAsString(this IContent Content, string PropertyName)
        {
            string result = string.Empty;
            if (Content.HasProperty(PropertyName) && Content.GetValue(PropertyName) != null)
            {
                result = Content.GetValue(PropertyName).ToString();
            }
            return result;
        }

    }
}