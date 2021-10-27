using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyG.Week8.Amazon.MVC.TagHelpers
{
    [HtmlTargetElement("e-mail", TagStructure = TagStructure.WithoutEndTag)]
    public class EMailTagHelper : TagHelper
    {
        // gi attributi che vogliamo avere nel nostro tag diventato proprietà nella classe
        public string ToUser { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Content.SetContent("Mandami e-mail!");
            output.Attributes.SetAttribute("class", "btn btn-primary");
            output.Attributes.SetAttribute("href", $"mailto:{ToUser}");
        }
    }
}
