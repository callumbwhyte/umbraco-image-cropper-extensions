# Umbraco Image Cropper Extensions

[![NuGet release](https://img.shields.io/nuget/v/Our.Umbraco.Extensions.ImageCropper.svg)](https://www.nuget.org/packages/Our.Umbraco.Extensions.ImageCropper/)
[![Our Umbraco project page](https://img.shields.io/badge/our-umbraco-orange.svg)](https://our.umbraco.com/packages/developer-tools/image-cropper-extensions/)

## Getting started

This package is supported on Umbraco 8.1+.

### Installation

Image Cropper Extensions is available from Our Umbraco, NuGet, or as a manual download directly from GitHub.

#### Our Umbraco repository

You can find a downloadable package on the [Our Umbraco](https://our.umbraco.com/packages/developer-tools/image-cropper-extensions/) site.

#### NuGet package repository

To [install from NuGet](https://www.nuget.org/packages/Our.Umbraco.Extensions.ImageCropper/), run the following command in your instance of Visual Studio.

    PM> Install-Package Our.Umbraco.Extensions.ImageCropper

## Usage

Image Cropper Extensions makes it possible to map a strongly typed C# `enum` to cropper configuration, by decorating each property with the `Crop` attribute like this:

```
public enum ImageCrops
{
    [Crop("heroAlias")]
    Hero,
    [Crop("promoAlias")]
    Promo
}
```

It is also possible to define a crop width and height via the attribute, like this:

```
[Crop("myCropAlias", width = 900, height = 600)]
```

Properties from the `enum` can be passed into the `GetCropUrl` extension method to generate crop URLs based on the configured settings:

```
@image.GetCropUrl(ImageCrops.Hero)
```

## Contribution guidelines

To raise a new bug, create an issue on the GitHub repository. To fix a bug or add new features, fork the repository and send a pull request with your changes. Feel free to add ideas to the repository's issues list if you would to discuss anything related to the library.

### Who do I talk to?

This project is maintained by [Callum Whyte](https://callumwhyte.com/) and contributors. If you have any questions about the project please get in touch on [Twitter](https://twitter.com/callumbwhyte), or by raising an issue on GitHub.

## License

Copyright &copy; 2019 [Callum Whyte](https://callumwhyte.com/), and other contributors

Licensed under the [MIT License](LICENSE.md).