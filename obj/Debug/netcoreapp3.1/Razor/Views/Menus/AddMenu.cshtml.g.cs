#pragma checksum "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Menus\AddMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a26b9fee61462d9183b12587b26431189df266ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menus_AddMenu), @"mvc.1.0.view", @"/Views/Menus/AddMenu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a26b9fee61462d9183b12587b26431189df266ad", @"/Views/Menus/AddMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8031ff6bbc2c8983fb2c7da832f48b6b76ca4216", @"/Views/_ViewImports.cshtml")]
    public class Views_Menus_AddMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Menu>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Menus\AddMenu.cshtml"
  
    ViewData["Title"] = "Menu Ekle";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""/richtexteditor/rte_theme_default.css"" />
<script type=""text/javascript"" src=""/richtexteditor/rte.js""></script>
<script type=""text/javascript"" src='/richtexteditor/plugins/all_plugins.js'></script>
<section class=""hero-wrap hero-wrap-2"" style=""background-image: url(/images/bg_3.jpg);"" data-stellar-background-ratio=""0.5"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-end justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center mb-4"">
                <h1 class=""mb-2 bread"">Fikirlerini Belirt</h1>

            </div>
        </div>
    </div>
</section>


<section>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a26b9fee61462d9183b12587b26431189df266ad6923", async() => {
                WriteLiteral("\r\n        <div style=\"margin-left:20px; margin-top:30px;\">\r\n            <span>Dikkat çekici bir başlık</span><br />\r\n            ");
#nullable restore
#line 25 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Menus\AddMenu.cshtml"
       Write(Html.TextBoxFor(x => x.MenuHeader, new { style = "width:100%" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n            <span>Restoran ismi</span><br />\r\n            ");
#nullable restore
#line 27 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Menus\AddMenu.cshtml"
       Write(Html.TextBoxFor(x => x.RestaurantName, new { style = "width:100%" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n            <span>Fotoğraf ya da Fotoğrafları çektiğiniz tarih</span><br />\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a26b9fee61462d9183b12587b26431189df266ad8015", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 29 "D:\Uygulamalarim\Foodly_New\Foodly_new\Views\Menus\AddMenu.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PhotoDate);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"<br />
            <span>Menü fotoğraf/fotoğraflarını yükle <br /> Çoklu seçim yapmak için ""Ctrl(Mac Os işletim sistemi için Cmd tuşu)"" Tuşu kullanılabilir</span>
            <input type=""file"" name=""file"" class=""form-control"" multiple  accept=""image/x-png,image/gif,image/jpeg""/>
        </div>
        <br />
        <button type=""submit"" class=""btn btn-dark"" style=""width:100%"">Kaydet</button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Menu> Html { get; private set; }
    }
}
#pragma warning restore 1591
