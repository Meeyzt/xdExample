#pragma checksum "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cdd3f9c14554c7cae0779df0299c76fd61b3957"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_Blog), @"mvc.1.0.view", @"/Views/Blogs/Blog.cshtml")]
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
#line 2 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cdd3f9c14554c7cae0779df0299c76fd61b3957", @"/Views/Blogs/Blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8031ff6bbc2c8983fb2c7da832f48b6b76ca4216", @"/Views/_ViewImports.cshtml")]
    public class Views_Blogs_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Comment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:20%;height:30%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
  
    ViewData["Title"] = ViewData["BlogHeader"];
    int starCount = Convert.ToInt16(ViewData["BlogStar"]);
    int Count=0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"hero-wrap hero-wrap-2\"");
            BeginWriteAttribute("style", " style=\"", 288, "\"", 349, 4);
            WriteAttributeValue("  ", 296, "background-image:", 298, 19, true);
            WriteAttributeValue(" ", 315, "url(", 316, 5, true);
#nullable restore
#line 10 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
WriteAttributeValue("", 320, ViewData["BlogPictureURL"], 320, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 347, ");", 347, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" data-stellar-background-ratio=""0.5"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-end justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center mb-4"">
                <h1 class=""mb-2 bread"">");
#nullable restore
#line 15 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
                                  Write(ViewData["BlogHeader"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<section class=\"ftco-section\">\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 24 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
         if (User.IsInRole("Editor") || User.IsInRole("Admin"))
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cdd3f9c14554c7cae0779df0299c76fd61b39577566", async() => {
                WriteLiteral("\r\n                <input type=\"text\" asp-area=\"Blog\"");
                BeginWriteAttribute("asp-route-ReviewID", " asp-route-ReviewID=\"", 962, "\"", 998, 1);
#nullable restore
#line 28 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
WriteAttributeValue("", 983, ViewData["id"], 983, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""visibility:hidden;"" />
                <input asp-area=""Blog"" asp-route-Header=""Delete"" style=""visibility:hidden"" />
                <button type=""submit"" class=""btn btn-danger"" style="" float: right; margin-right:30%"">Makaleyi Sil   </button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 32 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-lg-8 ftco-animate\">\r\n                <h2 class=\"mb-3\">");
#nullable restore
#line 35 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
                            Write(ViewData["BlogHeader"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <div class=\"ftco-animate col-lg-4\">\r\n                    <span>\r\n");
#nullable restore
#line 38 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
                          
                            for (int i = 1; i <= starCount; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"golden fas fa-star\"></span>\r\n");
#nullable restore
#line 42 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
                            }
                            for (int i = starCount + 1; i <= 5; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"golden far fa-star\"></span>\r\n");
#nullable restore
#line 46 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </span>
                    <span style=""margin-left:10px;""><svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-cash"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M15 4H1v8h14V4zM1 3a1 1 0 0 0-1 1v8a1 1 0 0 0 1 1h14a1 1 0 0 0 1-1V4a1 1 0 0 0-1-1H1z"" /><path d=""M13 4a2 2 0 0 0 2 2V4h-2zM3 4a2 2 0 0 1-2 2V4h2zm10 8a2 2 0 0 1 2-2v2h-2zM3 12a2 2 0 0 0-2-2v2h2zm7-4a2 2 0 1 1-4 0 2 2 0 0 1 4 0z"" /></svg></span>
                    ");
#nullable restore
#line 51 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
               Write(ViewData["BlogPrice"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺\r\n                </div><br />\r\n                <div>");
#nullable restore
#line 53 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
                Write(ViewData["ShorCast"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <hr />\r\n                <div>\r\n                    ");
#nullable restore
#line 56 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
               Write(Html.Raw(ViewData["BlogContent"].ToString()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n       \r\n                <!--Comment-->\r\n                <div class=\"pt-5 mt-5\">\r\n                    <h3 class=\"mb-5 h4 font-weight-bold p-4 bg-light\">");
#nullable restore
#line 61 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
                                                                 Write(Model.ToList().Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Yorum</h3>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cdd3f9c14554c7cae0779df0299c76fd61b395713191", async() => {
                WriteLiteral("Yorum yaz");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
                                                                                WriteLiteral(ViewData["id"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br /><br />\r\n                    <hr />\r\n                    <ul class=\"comment-list\">\r\n");
#nullable restore
#line 65 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
                         foreach (var item in Model)
                        {

                            var user = await userManager.FindByIdAsync(item.UserID);


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"comment\">\r\n                            <div class=\"vcard bio\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 3443, "\"", 3467, 1);
#nullable restore
#line 72 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
WriteAttributeValue("", 3449, user.Profilephoto, 3449, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image placeholder\">\r\n                            </div>\r\n                            <div class=\"comment-body\">\r\n                                <h3>");
#nullable restore
#line 75 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
                               Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <div class=\"meta mb-2\">");
#nullable restore
#line 76 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
                                                  Write(item.PublishDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <p>");
#nullable restore
#line 77 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
                              Write(item.Entry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p><hr /></p>\r\n                            </div>\r\n                        </li>\r\n");
#nullable restore
#line 81 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                </div>
                    <!-- END comment-list -->
                </div> <!-- .col-md-8 -->
                <div class=""col-lg-4 sidebar ftco-animate"">
                    <div class=""sidebar-box ftco-animate"">
                        <div class=""block-21 mb-4 d-flex"">
                            <a class=""blog-img mr-4""");
            BeginWriteAttribute("href", " href=\"", 4291, "\"", 4331, 2);
            WriteAttributeValue("", 4298, "/user/profile/", 4298, 14, true);
#nullable restore
#line 89 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
WriteAttributeValue("", 4312, ViewData["UserID"], 4312, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 4332, "\"", 4390, 4);
            WriteAttributeValue(" ", 4340, "background-image:", 4341, 18, true);
            WriteAttributeValue(" ", 4358, "url(", 4359, 5, true);
#nullable restore
#line 89 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
WriteAttributeValue("", 4363, ViewData["PhotoProfile"], 4363, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4388, ");", 4388, 2, true);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                            <div class=\"text\">\r\n                                <h3 class=\"heading\"><a");
            BeginWriteAttribute("href", " href=\"", 4500, "\"", 4540, 2);
            WriteAttributeValue("", 4507, "/user/profile/", 4507, 14, true);
#nullable restore
#line 91 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
WriteAttributeValue("", 4521, ViewData["UserID"], 4521, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 91 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
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
#line 95 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Blogs\Blog.cshtml"
                                   Write(ViewData["BlogPublishDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div><!-- END COL -->
                </div>
            </div>
    </div>
</section>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<UserIdentity> UserManager { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
