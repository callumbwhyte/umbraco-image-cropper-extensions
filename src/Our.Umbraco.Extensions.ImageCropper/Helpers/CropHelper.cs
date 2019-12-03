using System.Reflection;
using Our.Umbraco.Extensions.ImageCropper.Attributes;

namespace Our.Umbraco.Extensions.ImageCropper.Helpers
{
    public static class CropHelper
    {
        public static CropAttribute GetCropAttribute<T>(T cropAlias)
        {
            var alias = cropAlias.ToString();

            var type = typeof(T);

            var property = type.GetMember(alias);

            var cropAttribute = property[0].GetCustomAttribute<CropAttribute>();

            return cropAttribute;
        }
    }
}