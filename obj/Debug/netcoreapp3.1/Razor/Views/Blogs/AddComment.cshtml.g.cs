#pragma checksum "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\AddComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccc95746aa3d364f9dd77dbe96925bb585afa99a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_AddComment), @"mvc.1.0.view", @"/Views/Blogs/AddComment.cshtml")]
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
#line 1 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\_ViewImports.cshtml"
using Foodly_new;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\_ViewImports.cshtml"
using Foodly_new.Models.EfModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\_ViewImports.cshtml"
using Foodly_new.Models.DomainModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\_ViewImports.cshtml"
using Foodly_new.Models.Administration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\_ViewImports.cshtml"
using Foodly_new.Models.HomeModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\_ViewImports.cshtml"
using Foodly_new.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\_ViewImports.cshtml"
using Foodly_new.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccc95746aa3d364f9dd77dbe96925bb585afa99a", @"/Views/Blogs/AddComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8031ff6bbc2c8983fb2c7da832f48b6b76ca4216", @"/Views/_ViewImports.cshtml")]
    public class Views_Blogs_AddComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Comment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", new global::Microsoft.AspNetCore.Html.HtmlString("AddComment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("visibility:hidden;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\AddComment.cshtml"
  
    ViewData["Title"] = "Yorum yaz";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"hero-wrap hero-wrap-2\"");
            BeginWriteAttribute("style", " style=\"", 103, "\"", 164, 4);
            WriteAttributeValue("  ", 111, "background-image:", 113, 19, true);
            WriteAttributeValue(" ", 130, "url(", 131, 5, true);
#nullable restore
#line 7 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\AddComment.cshtml"
WriteAttributeValue("", 135, ViewData["BlogPictureURL"], 135, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 162, ");", 162, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" data-stellar-background-ratio=""0.5"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-end justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center mb-4"">
                <h1 class=""mb-2 bread"">Yorum yaz</h1>

            </div>
        </div>
    </div>
</section>
<section class=""ftco-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8 ftco-animate"">
                <h2 class=""mb-3"">");
#nullable restore
#line 22 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\AddComment.cshtml"
                            Write(ViewData["BlogHeader"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <br /><div>");
#nullable restore
#line 23 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\AddComment.cshtml"
                      Write(ViewData["ShortCast"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                <hr />
            </div> <!-- .col-md-8 -->
            <div class=""col-lg-4 sidebar ftco-animate"">
                <div class=""sidebar-box ftco-animate"">
                    <div class=""block-21 mb-4 d-flex"">
                        <a class=""blog-img mr-4""");
            BeginWriteAttribute("style", " style=\"", 1075, "\"", 1133, 4);
            WriteAttributeValue(" ", 1083, "background-image:", 1084, 18, true);
            WriteAttributeValue(" ", 1101, "url(", 1102, 5, true);
#nullable restore
#line 29 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\AddComment.cshtml"
WriteAttributeValue("", 1106, ViewData["PhotoProfile"], 1106, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1131, ");", 1131, 2, true);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                        <div class=\"text\">\r\n                            <h3 class=\"heading\"><a href=\"#\">");
#nullable restore
#line 31 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\AddComment.cshtml"
                                                       Write(ViewData["BlogUser"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h3>
                            <div class=""meta"">
                                <div>
                                    <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-calendar-date-fill"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M4 .5a.5.5 0 0 0-1 0V1H2a2 2 0 0 0-2 2v1h16V3a2 2 0 0 0-2-2h-1V.5a.5.5 0 0 0-1 0V1H4V.5zM16 14V5H0v9a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2zm-6.664-1.21c-1.11 0-1.656-.767-1.703-1.407h.683c.043.37.387.82 1.051.82.844 0 1.301-.848 1.305-2.164h-.027c-.153.414-.637.79-1.383.79-.852 0-1.676-.61-1.676-1.77 0-1.137.871-1.809 1.797-1.809 1.172 0 1.953.734 1.953 2.668 0 1.805-.742 2.871-2 2.871zm.066-2.544c.625 0 1.184-.484 1.184-1.18 0-.832-.527-1.23-1.16-1.23-.586 0-1.168.387-1.168 1.21 0 .817.543 1.2 1.144 1.2zm-2.957-2.89v5.332H5.77v-4.61h-.012c-.29.156-.883.52-1.258.777V8.16a12.6 12.6 0 0 1 1.313-.805h.632z"" /></svg>
                                    ");
#nullable restore
#line 35 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\AddComment.cshtml"
                               Write(ViewData["BlogPublishDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div><!-- END COL -->\r\n            </div>\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccc95746aa3d364f9dd77dbe96925bb585afa99a10713", async() => {
                WriteLiteral("\r\n            <div style=\"margin-left:20px; margin-top:30px;\">\r\n\r\n                <span>Yorumunuzu yazın</span><br />\r\n                ");
#nullable restore
#line 47 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\AddComment.cshtml"
           Write(Html.TextAreaFor(x=>x.Entry, new { style="width:100%" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ccc95746aa3d364f9dd77dbe96925bb585afa99a11401", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 48 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\AddComment.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ReviewID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\AddComment.cshtml"
                                                                          WriteLiteral(ViewData["id"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <button type=\"submit\" class=\"btn btn-dark\" style=\"width:100%\">Kaydet</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<UserIdentity> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<UserIdentity> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Comment> Html { get; private set; }
    }
}
#pragma warning restore 1591
