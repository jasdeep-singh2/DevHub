using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace DevHub.Web.Models.Blocks;

[ContentType(DisplayName = "Call to action", GUID = "8FECAFC2-CC39-48CF-8AAE-41DF475FC836",
    Description = "A short message with a button, e.g. \"Hire me\".")]
public class CallToActionBlock : BlockData
{
    [CultureSpecific]
    [Required]
    [Display(Name = "Heading", Order = 10)]
    public virtual string Heading { get; set; } = "";

    [CultureSpecific]
    [Display(Name = "Text", Order = 20)]
    [UIHint(UIHint.Textarea)]
    public virtual string? Text { get; set; }

    [CultureSpecific]
    [Required]
    [Display(Name = "Button text", Order = 30)]
    public virtual string ButtonText { get; set; } = "";

    [Required]
    [Display(Name = "Button link", Order = 40)]
    public virtual Url? ButtonLink { get; set; }
}
