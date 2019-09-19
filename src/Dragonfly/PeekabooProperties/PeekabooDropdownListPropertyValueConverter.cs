namespace Dragonfly.PeekabooProperties
{
    using System;
    using Umbraco.Core.Models.PublishedContent;
    using Umbraco.Core.PropertyEditors;


    public class PeekabooDropdownListPropertyValueConverter : IPropertyValueConverter
    {
        #region Implementation of IPropertyValueConverter

        public bool IsConverter(IPublishedPropertyType propertyType)
        {
            return propertyType.EditorAlias.Equals("Dragonfly.PeekabooProperties.DropdownList");
        }

        public bool? IsValue(object value, PropertyValueLevel level)
        {
            return null;
        }

        public Type GetPropertyValueType(IPublishedPropertyType propertyType)
        {
            return typeof(string);
        }

        public PropertyCacheLevel GetPropertyCacheLevel(IPublishedPropertyType propertyType)
        {
            return PropertyCacheLevel.Element;
        }

        public object ConvertSourceToIntermediate(IPublishedElement owner, IPublishedPropertyType propertyType, object source,
            bool preview)
        {
            if (source == null)
            {
                return "";
            }
            else
            {
                return (string)source;
            }
        }

        public object ConvertIntermediateToObject(IPublishedElement owner, IPublishedPropertyType propertyType,
            PropertyCacheLevel referenceCacheLevel, object inter, bool preview)
        {
            if (inter == null)
            {
                return "";
            }
            else
            {
                return (string)inter;
            }
        }

        public object ConvertIntermediateToXPath(IPublishedElement owner, IPublishedPropertyType propertyType,
            PropertyCacheLevel referenceCacheLevel, object inter, bool preview)
        {
            return null;
        }

        #endregion
    }
}
