#pragma checksum "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a8fb10c48a90729090b8cbff0782c37be6d811a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Details), @"mvc.1.0.view", @"/Views/Posts/Details.cshtml")]
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
#line 1 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\_ViewImports.cshtml"
using NewsWebApp;

#line default
#line hidden
#line 2 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\_ViewImports.cshtml"
using NewsWebApp.Models;

#line default
#line hidden
#line 3 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\_ViewImports.cshtml"
using NewsWebApp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a8fb10c48a90729090b8cbff0782c37be6d811a", @"/Views/Posts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1f4d4bd2a75d8aaa7f42dbc83efd19adbba3da8", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:40px;object-fit:cover;height:40px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Latest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/uploads/default.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
  
    ViewData["Title"] = Model.Name;
    Layout = "~/Views/Shared/_Layout.cshtml";
    var posts = ViewData["relatedPost"] as IEnumerable<Post>;
    var latest = ViewData["latest"] as IEnumerable<Post>;



#line default
#line hidden
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row my-5\">\r\n        <div class=\"col-md-8\">\r\n            <div class=\"shadow-sm p-3\">\r\n                <h3 class=\"my-5\">");
#line 15 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                            Write(Model.Name);

#line default
#line hidden
            WriteLiteral("</h3>\r\n                <hr />\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 538, "\"", 581, 2);
            WriteAttributeValue("", 545, "/posts/postbyauthor/", 545, 20, true);
#line 19 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
WriteAttributeValue("", 565, Model.AppUserId, 565, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0a8fb10c48a90729090b8cbff0782c37be6d811a5926", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 623, "~/uploads/", 623, 10, true);
#line 20 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
AddHtmlAttributeValue("", 633, Model.AppUser.ProfileImg, 633, 25, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
#line 21 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                             
                               var index = Model.AppUser.UserName.IndexOf('@');
                           

#line default
#line hidden
            WriteLiteral("                            ");
#line 24 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                       Write(Model.AppUser.UserName.Substring(0,index));

#line default
#line hidden
            WriteLiteral(@"
                        </a>
                    </div>
                    <div class=""col-md-6"">
                        <div class=""time text-dark"">
                            Published On
                            <i class=""fas fa-clock""></i> ");
#line 30 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                                                    Write(Model.CreatedDate.ToString("dddd, dd MMMM yyyy"));

#line default
#line hidden
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <hr />\r\n");
#line 35 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                 if (Model.Picture != null)
                {

#line default
#line hidden
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a8fb10c48a90729090b8cbff0782c37be6d811a8933", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1455, "~/uploads/", 1455, 10, true);
#line 37 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
AddHtmlAttributeValue("", 1465, Model.Picture, 1465, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#line 38 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                }

#line default
#line hidden
            WriteLiteral("                <hr />\r\n");
#line 40 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                 foreach (var item in Model.PostCategories)
                {

#line default
#line hidden
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1630, "\"", 1671, 2);
            WriteAttributeValue("", 1637, "/posts/postbycat/", 1637, 17, true);
#line 42 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
WriteAttributeValue("", 1654, item.Category.Id, 1654, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"category\">\r\n                            <span>\r\n                                ");
#line 45 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                           Write(item.Category.Name);

#line default
#line hidden
            WriteLiteral("\r\n                            </span>\r\n                        </div>\r\n                    </a>\r\n");
#line 49 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                }

#line default
#line hidden
            WriteLiteral("                ");
#line 50 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
           Write(Html.Raw(Model.Content));

#line default
#line hidden
            WriteLiteral("\r\n\r\n                <div class=\"tag-wrapper my-5\">\r\n\r\n");
#line 54 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                     foreach (var item in Model.PostTags)
                    {

#line default
#line hidden
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 2128, "\"", 2164, 2);
            WriteAttributeValue("", 2135, "/posts/postbytag/", 2135, 17, true);
#line 56 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
WriteAttributeValue("", 2152, item.Tag.Id, 2152, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"tag\">\r\n                            # ");
#line 57 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                         Write(item.Tag.Name);

#line default
#line hidden
            WriteLiteral("\r\n                        </a>\r\n");
#line 59 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                    }

#line default
#line hidden
            WriteLiteral("                </div>\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a8fb10c48a90729090b8cbff0782c37be6d811a13277", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 65 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = latest;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-md-12 my-4\">\r\n            <div class=\"cat-title\"> Related News    </div>\r\n        </div>\r\n");
#line 71 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
         foreach (var post in posts)
        {


#line default
#line hidden
            WriteLiteral("            <div class=\"col-md-4 my-4\">\r\n\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2672, "\"", 2702, 2);
            WriteAttributeValue("", 2679, "/posts/details/", 2679, 15, true);
#line 76 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
WriteAttributeValue("", 2694, post.Id, 2694, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"card shadow-sm h-100 border-0\">\r\n");
#line 78 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                         if (post.Picture != null)
                        {

#line default
#line hidden
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a8fb10c48a90729090b8cbff0782c37be6d811a15920", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2888, "~/uploads/", 2888, 10, true);
#line 80 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
AddHtmlAttributeValue("", 2898, post.Picture, 2898, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#line 81 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a8fb10c48a90729090b8cbff0782c37be6d811a17612", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#line 85 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"

                        }

#line default
#line hidden
            WriteLiteral("                        <div class=\"card-body\">\r\n                            ");
#line 88 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                       Write(post.Name);

#line default
#line hidden
            WriteLiteral("\r\n                            <div class=\"time text-dark\">\r\n\r\n                                <i class=\"fas fa-clock\"></i> ");
#line 91 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                                                        Write(Model.CreatedDate.ToString("dddd, dd MMMM yyyy"));

#line default
#line hidden
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </a>\r\n            </div>\r\n");
#line 97 "D:\4thsem\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
        }

#line default
#line hidden
            WriteLiteral("    </div>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
