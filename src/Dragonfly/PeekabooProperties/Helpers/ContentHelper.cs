namespace Dragonfly.PeekabooProperties.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Xml;

    using Umbraco.Core.Models;

    using Dragonfly.PeekabooProperties.Extensions;
    using Umbraco.Core.Models.PublishedContent;

    public static class ContentHelper
    {
        //public static string GetPropertyValueAsString(object content, string propertyAlias)
        //{
        //    string result = string.Empty;
        //    if (content is IContent)
        //    {
        //        result = ((IContent)content).GetPropertyValueAsString(propertyAlias);
        //    }
        //    else if (content is IPublishedContent)
        //    {
        //        result = ((IPublishedContent)content).GetPropertyValueAsString(propertyAlias);
        //    }
        //    return result;
        //}

        public static string GetPropertyValueAsString(IPublishedContent Content, string PropertyAlias)
        {
            string result = string.Empty;
            if (Content !=null)
            {
                result = Content.GetPropertyValueAsString(PropertyAlias);
            }
            return result;
        }

        public static string GetPropertyValueAsString(IContent Content, string PropertyAlias)
        {
            string result = string.Empty;
            if (Content !=null)
            {
                result = Content.GetPropertyValueAsString(PropertyAlias);
            }
           
            return result;
        }
    }

}