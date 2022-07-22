using Our.Umbraco.Extensions.ImageCropper.Helpers;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace Our.Umbraco.Extensions.ImageCropper
{
    public static class StringExtensions
    {
        public static string GetCropUrl<T>(this string imageUrl, T cropAlias, int? width = null, int? height = null, string imageCropperValue = null, int? quality = null, ImageCropMode? imageCropMode = null, ImageCropAnchor? imageCropAnchor = null, bool preferFocalPoint = false, bool useCropDimensions = false, string cacheBusterValue = null, string furtherOptions = null, ImageCropRatioMode? ratioMode = null, bool upScale = false)
            where T : struct
        {
            var crop = CropHelper.GetCropAttribute(cropAlias);

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

            return imageUrl.GetCropUrl(width, height, imageCropperValue, crop.Alias, quality, imageCropMode, imageCropAnchor, preferFocalPoint, useCropDimensions, cacheBusterValue, furtherOptions, ratioMode, upScale);
        }
    }
}