using EPiServer.Web;
using System.ComponentModel.DataAnnotations;
using DevHub.Web.Models.Media;

namespace DevHub.Web.Models.Blocks;

[ContentType(DisplayName = "Hero", GUID = "7001BDA2-7C84-42D1-9E1D-416D43F6E023",
    Description = "Large heading with intro text, optional image and a button.")]
public class HeroBlock : BlockData
{
    [CultureSpecific]
    [Required]
    [Display(Name = "Heading", Order = 10)]
    public virtual string Heading { get; set; } = "";

    [CultureSpecific]
    [Display(Name = "Intro", Order = 20)]
    [UIHint(UIHint.Textarea)]
    public virtual string? Intro { get; set; }

    [Display(Name = "Image", Order = 30)]
    [UIHint(UIHint.Image)]
    [AllowedTypes(typeof(ImageFile))]
    public virtual ContentReference? Image { get; set; }

    [CultureSpecific]
    [Display(Name = "Button text", Order = 40)]
    public virtual string? ButtonText { get; set; }

    [Display(Name = "Button link", Order = 50)]
    public virtual Url? ButtonLink { get; set; }
}
