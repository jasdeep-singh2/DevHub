using System.ComponentModel.DataAnnotations;
using DevHub.Web.Models.Blocks;

namespace DevHub.Web.Models.Pages;

[ContentType(DisplayName = "Start page", GUID = "070F52F8-4610-4068-9563-A508D0FC4B6C",
    Description = "The home page of the site. Create one, then set it as the site's start page.")]
[AvailableContentTypes(Availability.Specific,
    Include = [typeof(BlogListPage), typeof(CaseStudyPage), typeof(ServicePage)])]
public class StartPage : SitePageData
{
    [CultureSpecific]
    [Display(Name = "Main content", Description = "Hero, call-to-action and other blocks, in display order.",
        GroupName = SystemTabNames.Content, Order = 10)]
    [AllowedTypes(typeof(HeroBlock), typeof(CallToActionBlock))]
    public virtual ContentArea? MainContentArea { get; set; }
}
