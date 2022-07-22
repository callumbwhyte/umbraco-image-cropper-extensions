using System.Web;
using System.Web.Mvc;
using Umbraco.Core;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace Our.Umbraco.Extensions.ImageCropper
{
    public static class UrlHelperExtensions
    {
        public static IHtmlString GetCropUrl<T>(this UrlHelper urlHelper, IPublishedContent mediaItem, T cropAlias)
            where T : struct
        {
            return urlHelper.GetCropUrl(mediaItem, cropAlias, useCropDimensions: true);
        }

        public static IHtmlString GetCropUrl<T>(this UrlHelper urlHelper, IPublishedContent mediaItem, T cropAlias, string propertyAlias)
            where T : struct
        {
            return urlHelper.GetCropUrl(mediaItem, cropAlias, propertyAlias: propertyAlias, useCropDimensions: true);
        }

        public static IHtmlString GetCropUrl<T>(this UrlHelper urlHelper, IPublishedContent mediaItem, T cropAlias, int? width = null, int? height = null, string propertyAlias = Constants.Conventions.Media.File, int? quality = null, ImageCropMode? imageCropMode = null, ImageCropAnchor? imageCropAnchor = null, bool preferFocalPoint = false, bool useCropDimensions = false, bool cacheBuster = true, string furtherOptions = null, ImageCropRatioMode? ratioMode = null, bool upScale = true)
            where T : struct
        {
            var url = mediaItem.GetCropUrl(cropAlias, width, height, propertyAlias, quality, imageCropMode, imageCropAnchor, preferFocalPoint, useCropDimensions, cacheBuster, furtherOptions, ratioMode, upScale);

            return new HtmlString(url);
        }

        public static IHtmlString GetCropUrl<T>(this UrlHelper urlHelper, string imageUrl, T cropAlias, int? width = null, int? height = null, string imageCropperValue = null, int? quality = null, ImageCropMode? imageCropMode = null, ImageCropAnchor? imageCropAnchor = null, bool preferFocalPoint = false, bool useCropDimensions = false, string cacheBusterValue = null, string furtherOptions = null, ImageCropRatioMode? ratioMode = null, bool upScale = true)
            where T : struct
        {
            var url = imageUrl.GetCropUrl(cropAlias, width, height, imageCropperValue, quality, imageCropMode, imageCropAnchor, preferFocalPoint, useCropDimensions, cacheBusterValue, furtherOptions, ratioMode, upScale);

            return new HtmlString(url);
        }
    }
}