using System.ComponentModel.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace DevHub.Web.Models.Media;

// Without a media type for these extensions, uploads to the asset pane fail.
[ContentType(DisplayName = "Image", GUID = "27A6586F-3B3C-449F-A11A-251B698BF026")]
[MediaDescriptor(ExtensionString = "jpg,jpeg,png,gif,webp,svg")]
public class ImageFile : ImageData
{
    [CultureSpecific]
    [Display(Name = "Alt text", Description = "Describes the image for screen readers and search engines.", Order = 10)]
    public virtual string? AltText { get; set; }   // the Phase 5 AI plugin will generate this on upload
}
