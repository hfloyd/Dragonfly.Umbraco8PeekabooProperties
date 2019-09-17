namespace Dragonfly.PeekabooProperties.Extensions
{
    using Umbraco.Core.Models.PublishedContent;
    using Umbraco.Web;

    public static class PublishedContentExtensions
    {

        public static string GetPropertyValueAsString(this IPublishedContent PublishedContent, string PropertyName)
        {
            string result = string.Empty;
            if (PublishedContent.HasProperty(PropertyName) && PublishedContent.Value(PropertyName) != null)
            {
                result = PublishedContent.Value(PropertyName).ToString();
            }
            return result;
        }

    }
}