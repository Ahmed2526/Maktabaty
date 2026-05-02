using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

[HtmlTargetElement("a", Attributes = "asp-controller")]
public class ActiveRouteTagHelper : TagHelper
{
    public string AspController { get; set; }
    public string AspAction { get; set; }

    [ViewContext]
    public ViewContext ViewContext { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        var currentController = ViewContext.RouteData.Values["controller"]?.ToString();
        var currentAction = ViewContext.RouteData.Values["action"]?.ToString();

        var isActive = false;

        // If both controller and action are specified, match both
        if (!string.IsNullOrEmpty(AspAction))
        {
            isActive = string.Equals(currentController, AspController, StringComparison.OrdinalIgnoreCase)
                && string.Equals(currentAction, AspAction, StringComparison.OrdinalIgnoreCase);
        }
        else
        {
            // If only controller is specified, match controller only
            isActive = string.Equals(currentController, AspController, StringComparison.OrdinalIgnoreCase);
        }

        if (isActive)
        {
            var existingClass = output.Attributes["class"]?.Value?.ToString() ?? "";
            output.Attributes.SetAttribute("class", existingClass + " active");
        }
    }
}