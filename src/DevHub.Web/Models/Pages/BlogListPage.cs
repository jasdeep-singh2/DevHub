using System.ComponentModel.DataAnnotations;

namespace DevHub.Web.Models.Pages;

// A container: blog posts are created as its children.
[ContentType(DisplayName = "Blog", GUID = "46061E9C-D953-4E5B-AAFC-07D8214E4D33",
    Description = "Lists blog posts. Create posts underneath it.")]
[AvailableContentTypes(Availability.Specific, Include = [typeof(BlogPostPage)])]
public class BlogListPage : SitePageData
{
    [CultureSpecific]
    [Display(Name = "Intro", GroupName = SystemTabNames.Content, Order = 10)]
    [UIHint(EPiServer.Web.UIHint.Textarea)]
    public virtual string? Intro { get; set; }
}
