#pragma checksum "C:\Users\USER\Desktop\careerdotnet\CareerSearchInc\Views\JobRecuiter\AllJobs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2e2e8ba500e034200c016e2d1ada12e2cedf7ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JobRecuiter_AllJobs), @"mvc.1.0.view", @"/Views/JobRecuiter/AllJobs.cshtml")]
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
#line 1 "C:\Users\USER\Desktop\careerdotnet\CareerSearchInc\Views\_ViewImports.cshtml"
using CareerSearchInc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Desktop\careerdotnet\CareerSearchInc\Views\_ViewImports.cshtml"
using CareerSearchInc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2e2e8ba500e034200c016e2d1ada12e2cedf7ed", @"/Views/JobRecuiter/AllJobs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b467ca073ff110d4c4f2dc264651b395fbd58f", @"/Views/_ViewImports.cshtml")]
    public class Views_JobRecuiter_AllJobs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "JobRecuiter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Apply", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\USER\Desktop\careerdotnet\CareerSearchInc\Views\JobRecuiter\AllJobs.cshtml"
  
    ViewData["Title"] = "AllJobs";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">AllJobs</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\USER\Desktop\careerdotnet\CareerSearchInc\Views\JobRecuiter\AllJobs.cshtml"
 foreach (var job in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>Company: ");
#nullable restore
#line 11 "C:\Users\USER\Desktop\careerdotnet\CareerSearchInc\Views\JobRecuiter\AllJobs.cshtml"
                Write(job.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h6>Location: ");
#nullable restore
#line 12 "C:\Users\USER\Desktop\careerdotnet\CareerSearchInc\Views\JobRecuiter\AllJobs.cshtml"
                 Write(job.JobLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h6>Qualification: ");
#nullable restore
#line 13 "C:\Users\USER\Desktop\careerdotnet\CareerSearchInc\Views\JobRecuiter\AllJobs.cshtml"
                      Write(job.HighestQualification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h6>Experience: ");
#nullable restore
#line 14 "C:\Users\USER\Desktop\careerdotnet\CareerSearchInc\Views\JobRecuiter\AllJobs.cshtml"
                   Write(job.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h6>Recruitment Services: ");
#nullable restore
#line 15 "C:\Users\USER\Desktop\careerdotnet\CareerSearchInc\Views\JobRecuiter\AllJobs.cshtml"
                             Write(job.RecruitmentService);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2e2e8ba500e034200c016e2d1ada12e2cedf7ed6036", async() => {
                WriteLiteral("Apply");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <hr />\r\n");
#nullable restore
#line 18 "C:\Users\USER\Desktop\careerdotnet\CareerSearchInc\Views\JobRecuiter\AllJobs.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
