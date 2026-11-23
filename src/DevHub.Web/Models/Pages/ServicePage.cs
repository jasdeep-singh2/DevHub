using System.ComponentModel.DataAnnotations;
using DevHub.Web.Models.Blocks;
using EPiServer.Web;

namespace DevHub.Web.Models.Pages;

[ContentType(DisplayName = "Service", GUID = "5519B183-CA7D-4FD2-A664-34FF74F88B7E",
    Description = "Something you offer, e.g. \"CMS 12 to 13 upgrades\".")]
[AvailableContentTypes(Availability.None)]
public class ServicePage : SitePageData
{
    [CultureSpecific]
    [Display(Name = "Summary", GroupName = SystemTabNames.Content, Order = 10)]
    [UIHint(UIHint.Textarea)]
    public virtual string? Summary { get; set; }

    [CultureSpecific]
    [Display(Name = "Body", GroupName = SystemTabNames.Content, Order = 20)]
    public virtual XhtmlString? MainBody { get; set; }

    [CultureSpecific]
    [Display(Name = "Main content", GroupName = SystemTabNames.Content, Order = 30)]
    [AllowedTypes(typeof(CallToActionBlock))]
    public virtual ContentArea? MainContentArea { get; set; }
}
