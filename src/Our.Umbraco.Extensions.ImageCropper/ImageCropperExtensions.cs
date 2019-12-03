using Our.Umbraco.Extensions.ImageCropper.Helpers;
using Umbraco.Core;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace Our.Umbraco.Extensions.ImageCropper
{
    public static class ImageCropperExtensions
    {
        public static string GetCropUrl<T>(this IPublishedContent mediaItem, T cropAlias)
            where T : struct
        {
            return mediaItem.GetCropUrl(cropAlias: cropAlias, useCropDimensions: true);
        }

        public static string GetCropUrl<T>(this IPublishedContent mediaItem, T cropAlias, string propertyAlias)
            where T : struct
        {
            return mediaItem.GetCropUrl(propertyAlias: propertyAlias, cropAlias: cropAlias, useCropDimensions: true);
        }

        public static string GetCropUrl<T>(this IPublishedContent mediaItem, T cropAlias, int? width = null, int? height = null, string propertyAlias = Constants.Conventions.Media.File, int? quality = null, ImageCropMode? imageCropMode = null, ImageCropAnchor? imageCropAnchor = null, bool preferFocalPoint = false, bool useCropDimensions = false, bool cacheBuster = true, string furtherOptions = null, ImageCropRatioMode? ratioMode = null, bool upScale = true)
            where T : struct
        {
            var crop = CropHelper.GetCropAttribute(cropAlias);

            var alias = string.IsNullOrWhiteSpace(crop.Alias) == false ? crop.Alias : null;

            if (width.HasValue == false)
            {
                if (crop.Width > 0)
                {
                    width = crop.Width;
                }
            }

            if (height.HasValue == false)
            {
                if (crop.Height > 0)
                {
                    height = crop.Height;
                }
            }

            return mediaItem.GetCropUrl(width, height, propertyAlias, alias, quality, imageCropMode, imageCropAnchor, preferFocalPoint, useCropDimensions, cacheBuster, furtherOptions, ratioMode, upScale);
        }
    }
}