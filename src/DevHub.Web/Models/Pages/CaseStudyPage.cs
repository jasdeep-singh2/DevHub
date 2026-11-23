using System.ComponentModel.DataAnnotations;
using DevHub.Web.Models.Media;
using EPiServer.Web;

namespace DevHub.Web.Models.Pages;

// Challenge / solution / results: the structure clients and recruiters scan for.
[ContentType(DisplayName = "Case study", GUID = "9371EADA-2C43-49CE-AC09-E33BCD76BDDD",
    Description = "A project you delivered: the problem, what you built, and the outcome.")]
[AvailableContentTypes(Availability.None)]
public class CaseStudyPage : SitePageData
{
    [CultureSpecific]
    [Display(Name = "Client or industry", Description = "e.g. \"Nordic retailer\" if the client is confidential.",
        GroupName = SystemTabNames.Content, Order = 10)]
    public virtual string? Client { get; set; }

    [Display(Name = "Main image", GroupName = SystemTabNames.Content, Order = 20)]
    [UIHint(UIHint.Image)]
    [AllowedTypes(typeof(ImageFile))]
    public virtual ContentReference? MainImage { get; set; }

    [CultureSpecific]
    [Display(Name = "Challenge", GroupName = SystemTabNames.Content, Order = 30)]
    public virtual XhtmlString? Challenge { get; set; }

    [CultureSpecific]
    [Display(Name = "Solution", GroupName = SystemTabNames.Content, Order = 40)]
    public virtual XhtmlString? Solution { get; set; }

    [CultureSpecific]
    [Display(Name = "Results", Description = "Measurable outcomes, e.g. \"page load 40% faster\".",
        GroupName = SystemTabNames.Content, Order = 50)]
    public virtual XhtmlString? Results { get; set; }

    [Display(Name = "Technologies", Description = "e.g. Optimizely CMS 13, Graph, Next.js",
        GroupName = SystemTabNames.Content, Order = 60)]
    public virtual IList<string>? Technologies { get; set; }
}
