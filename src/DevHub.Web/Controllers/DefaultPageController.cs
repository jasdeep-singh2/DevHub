using DevHub.Web.Models.Pages;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace DevHub.Web.Controllers;

// One controller renders every page type: Inherited = true makes it the template for all SitePageData.
// Each type gets its own view by name: StartPage -> Views/Pages/StartPage.cshtml.
// (Temporary server-side rendering for preview; the public site becomes headless Next.js in Phase 3.)
[TemplateDescriptor(Inherited = true)]
public class DefaultPageController : PageController<SitePageData>
{
    public IActionResult Index(SitePageData currentPage) =>
        // GetOriginalType: the CMS hands us a runtime proxy subclass, so GetType().Name would be the proxy's name.
        View($"~/Views/Pages/{currentPage.GetOriginalType().Name}.cshtml", currentPage);
}
