#pragma checksum "C:\Users\AntoniaSacchitella\Desktop\AcademyG\Week8\AcademyG.Week8.MVC\AcademyG.Week8.MVC\Views\Employees\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92a07933c1cd7a3e18db1f063c0d569a68db7b0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Detail), @"mvc.1.0.view", @"/Views/Employees/Detail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\AntoniaSacchitella\Desktop\AcademyG\Week8\AcademyG.Week8.MVC\AcademyG.Week8.MVC\Views\_ViewImports.cshtml"
using AcademyG.Week8.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AntoniaSacchitella\Desktop\AcademyG\Week8\AcademyG.Week8.MVC\AcademyG.Week8.MVC\Views\_ViewImports.cshtml"
using AcademyG.Week8.MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AntoniaSacchitella\Desktop\AcademyG\Week8\AcademyG.Week8.MVC\AcademyG.Week8.MVC\Views\_ViewImports.cshtml"
using AcademyG.Week8.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92a07933c1cd7a3e18db1f063c0d569a68db7b0d", @"/Views/Employees/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58382a2b7076d38f224428560a8de3d8e7602d07", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"card\" style=\"width: 18rem;\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 5 "C:\Users\AntoniaSacchitella\Desktop\AcademyG\Week8\AcademyG.Week8.MVC\AcademyG.Week8.MVC\Views\Employees\Detail.cshtml"
                              Write(Model.EmployeeCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">");
#nullable restore
#line 6 "C:\Users\AntoniaSacchitella\Desktop\AcademyG\Week8\AcademyG.Week8.MVC\AcademyG.Week8.MVC\Views\Employees\Detail.cshtml"
                            Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "C:\Users\AntoniaSacchitella\Desktop\AcademyG\Week8\AcademyG.Week8.MVC\AcademyG.Week8.MVC\Views\Employees\Detail.cshtml"
                                             Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 6 "C:\Users\AntoniaSacchitella\Desktop\AcademyG\Week8\AcademyG.Week8.MVC\AcademyG.Week8.MVC\Views\Employees\Detail.cshtml"
                                                               Write(Model.BirthDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>            \r\n        </div>\r\n    </div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
