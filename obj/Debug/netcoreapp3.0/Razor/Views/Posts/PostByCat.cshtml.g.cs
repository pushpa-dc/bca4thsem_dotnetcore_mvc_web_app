#pragma checksum "D:\4thsem\NewsWebApp\Views\Posts\PostByCat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88d4b1741425fc14891ed92ed92a8aae254482d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_PostByCat), @"mvc.1.0.view", @"/Views/Posts/PostByCat.cshtml")]
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
#line 1 "D:\4thsem\NewsWebApp\Views\_ViewImports.cshtml"
using NewsWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\4thsem\NewsWebApp\Views\_ViewImports.cshtml"
using NewsWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d4b1741425fc14891ed92ed92a8aae254482d7", @"/Views/Posts/PostByCat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"611b239ef6ae9b32b4cba408aa5ed3a1ffee7262", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_PostByCat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/uploads/five.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\4thsem\NewsWebApp\Views\Posts\PostByCat.cshtml"
  
    ViewData["Title"] = ViewData["category"] + "Category";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var category = ViewData["category"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container my-5\">\r\n    <div class=\"row squareimage\">\r\n        <div class=\"col-md-12\">\r\n            <h1 class=\"shadow-sm p-2 cat-title\"> ");
#nullable restore
#line 11 "D:\4thsem\NewsWebApp\Views\Posts\PostByCat.cshtml"
                                            Write(category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n");
#nullable restore
#line 13 "D:\4thsem\NewsWebApp\Views\Posts\PostByCat.cshtml"
           int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "D:\4thsem\NewsWebApp\Views\Posts\PostByCat.cshtml"
         foreach (var item in Model)
        {
            i++;
            if (i == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h1>");
#nullable restore
#line 20 "D:\4thsem\NewsWebApp\Views\Posts\PostByCat.cshtml"
               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <div class=\"col-md-12 mb-4\">\r\n\r\n                    <div class=\"card thulo shadow-sm border-0 rounded-0\">\r\n\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 676, "\"", 706, 2);
            WriteAttributeValue("", 683, "/posts/details/", 683, 15, true);
#nullable restore
#line 25 "D:\4thsem\NewsWebApp\Views\Posts\PostByCat.cshtml"
WriteAttributeValue("", 698, item.Id, 698, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 26 "D:\4thsem\NewsWebApp\Views\Posts\PostByCat.cshtml"
                             if (item.Picture == null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "88d4b1741425fc14891ed92ed92a8aae254482d75951", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 29 "D:\4thsem\NewsWebApp\Views\Posts\PostByCat.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img");
            BeginWriteAttribute("src", " src=\"", 1016, "\"", 1044, 2);
            WriteAttributeValue("", 1022, "/uploads/", 1022, 9, true);
#nullable restore
#line 32 "D:\4thsem\NewsWebApp\Views\Posts\PostByCat.cshtml"
WriteAttributeValue("", 1031, item.Picture, 1031, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1045, "\"", 1051, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 33 "D:\4thsem\NewsWebApp\Views\Posts\PostByCat.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <div class=\"card-body\">\r\n                                ");
#nullable restore
#line 36 "D:\4thsem\NewsWebApp\Views\Posts\PostByCat.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <div class=\"time text-dark\">\r\n                                    <i class=\"fas fa-clock\"></i> ");
#nullable restore
#line 38 "D:\4thsem\NewsWebApp\Views\Posts\PostByCat.cshtml"
                                                            Write(item.CreatedDate.ToString("dddd, dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </a>\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 45 "D:\4thsem\NewsWebApp\Views\Posts\PostByCat.cshtml"
            }
            else
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 mb-4\">\r\n\r\n                    <div class=\"card shadow-sm border-0 rounded-0\">\r\n\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1718, "\"", 1748, 2);
            WriteAttributeValue("", 1725, "/posts/details/", 1725, 15, true);
#nullable restore
#line 53 "D:\4thsem\NewsWebApp\Views\Posts\PostByCat.cshtml"
WriteAttributeValue("", 1740, item.Id, 1740, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 54 "D:\4thsem\NewsWebApp\Views\Posts\PostByCat.cshtml"
                             if (item.Picture == null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "88d4b1741425fc14891ed92ed92a8aae254482d710023", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 57 "D:\4thsem\NewsWebApp\Views\Posts\PostByCat.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img");
            BeginWriteAttribute("src", " src=\"", 2058, "\"", 2086, 2);
            WriteAttributeValue("", 2064, "/uploads/", 2064, 9, true);
#nullable restore
#line 60 "D:\4thsem\NewsWebApp\Views\Posts\PostByCat.cshtml"
WriteAttributeValue("", 2073, item.Picture, 2073, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2087, "\"", 2093, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 61 "D:\4thsem\NewsWebApp\Views\Posts\PostByCat.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <div class=\"card-body\">\r\n                                ");
#nullable restore
#line 64 "D:\4thsem\NewsWebApp\Views\Posts\PostByCat.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <div class=\"time text-dark\">\r\n                                    <i class=\"fas fa-clock\"></i> ");
#nullable restore
#line 66 "D:\4thsem\NewsWebApp\Views\Posts\PostByCat.cshtml"
                                                            Write(item.CreatedDate.ToString("dddd, dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </a>\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 73 "D:\4thsem\NewsWebApp\Views\Posts\PostByCat.cshtml"
            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
