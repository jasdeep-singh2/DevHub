using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace DevHub.Web.Models.Pages;

// Base class for every DevHub page, so SEO fields exist everywhere and can be filled one way
// (by editors now, by the AI SEO plugin in Phase 5). Abstract: editors never create a "SitePageData".
public abstract class SitePageData : PageData
{
    [CultureSpecific]
    [Display(Name = "Meta title", Description = "Shown in the browser tab and search results. Falls back to the page name.",
        GroupName = Tabs.Seo, Order = 100)]
    [StringLength(70)]
    public virtual string? MetaTitle { get; set; }

    [CultureSpecific]
    [Display(Name = "Meta description", Description = "One or two sentences for search results.",
        GroupName = Tabs.Seo, Order = 110)]
    [UIHint(UIHint.Textarea)]
    [StringLength(160)]
    public virtual string? MetaDescription { get; set; }

    [CultureSpecific]
    [Display(Name = "Teaser text", Description = "Short summary used when this page is listed elsewhere.",
        GroupName = SystemTabNames.Content, Order = 900)]
    [UIHint(UIHint.Textarea)]
    public virtual string? TeaserText { get; set; }
}
