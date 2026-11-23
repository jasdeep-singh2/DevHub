using System.ComponentModel.DataAnnotations;
using DevHub.Web.Models.Media;
using EPiServer.Web;

namespace DevHub.Web.Models.Pages;

[ContentType(DisplayName = "Blog post", GUID = "E7DAFFC7-8DC0-4190-A6E6-5F43394155B2")]
[AvailableContentTypes(Availability.None)]   // posts have no child pages
public class BlogPostPage : SitePageData
{
    [CultureSpecific]
    [Display(Name = "Summary", Description = "One or two sentences shown in the blog list.",
        GroupName = SystemTabNames.Content, Order = 10)]
    [UIHint(UIHint.Textarea)]
    public virtual string? Summary { get; set; }

    [Display(Name = "Main image", GroupName = SystemTabNames.Content, Order = 20)]
    [UIHint(UIHint.Image)]
    [AllowedTypes(typeof(ImageFile))]
    public virtual ContentReference? MainImage { get; set; }

    [CultureSpecific]
    [Display(Name = "Body", GroupName = SystemTabNames.Content, Order = 30)]
    public virtual XhtmlString? MainBody { get; set; }

    [Display(Name = "Tags", Description = "e.g. Optimizely, .NET, AI", GroupName = SystemTabNames.Content, Order = 40)]
    public virtual IList<string>? Tags { get; set; }
}
