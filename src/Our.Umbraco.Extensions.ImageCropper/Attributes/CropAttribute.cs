using System;

namespace Our.Umbraco.Extensions.ImageCropper.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class CropAttribute : Attribute
    {
        public string Alias { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public CropAttribute(string alias)
        {
            Alias = alias;
        }
    }
}