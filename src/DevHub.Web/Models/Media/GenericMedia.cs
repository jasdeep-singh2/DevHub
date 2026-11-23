using EPiServer.Framework.DataAnnotations;

namespace DevHub.Web.Models.Media;

[ContentType(DisplayName = "Document", GUID = "729C49A7-D1A5-4EF5-9853-3C9A615A9499")]
[MediaDescriptor(ExtensionString = "pdf,docx,xlsx,pptx,txt,zip")]
public class GenericMedia : MediaData
{
}
