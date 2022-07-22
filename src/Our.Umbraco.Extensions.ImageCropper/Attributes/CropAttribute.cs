using System;

namespace Our.Umbraco.Extensions.ImageCropper.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class CropAttribute : Attribute
    {
        public CropAttribute(string alias)
        {
            Alias = alias;
        }

        public CropAttribute(int width, int height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Crop alias, as defined in Umbraco
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// Width of the output image
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Height of the output image
        /// </summary>
        public int Height { get; set; }
    }
}