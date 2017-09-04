using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryCore.Helpers
{
    [HtmlTargetElement("a", Attributes = ConfirmationAttributeName)]
    public class ConfirmationMessageTagHelper : TagHelper
    {
        private const string ConfirmationAttributeName = "confirmation-message";

        [HtmlAttributeName(ConfirmationAttributeName)]
        public string ConfirmationMessage { get; set; }

        public override void Process(
            TagHelperContext context, TagHelperOutput output)
        {
            if (output.Attributes.Where(
                a => a.Name.ToLower() == "onclick").Count() == 0)
            {
                output.Attributes.Add("onclick", new HtmlString($"return confirm('{this.ConfirmationMessage}');"));
            }
        }
    }
}
