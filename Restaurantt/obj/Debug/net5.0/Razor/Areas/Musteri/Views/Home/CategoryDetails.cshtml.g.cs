#pragma checksum "C:\Users\AKSAM YAZILIM\source\repos\Restaurantt-Final\Restaurantt\Areas\Musteri\Views\Home\CategoryDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "918d0a7c3b2702d37dec1c4aea6b5021f10a4c1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Musteri_Views_Home_CategoryDetails), @"mvc.1.0.view", @"/Areas/Musteri/Views/Home/CategoryDetails.cshtml")]
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
#line 1 "C:\Users\AKSAM YAZILIM\source\repos\Restaurantt-Final\Restaurantt\Areas\Musteri\Views\_ViewImports.cshtml"
using Restaurantt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AKSAM YAZILIM\source\repos\Restaurantt-Final\Restaurantt\Areas\Musteri\Views\_ViewImports.cshtml"
using Restaurantt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"918d0a7c3b2702d37dec1c4aea6b5021f10a4c1e", @"/Areas/Musteri/Views/Home/CategoryDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c063f836858049ebe24a647ce03943d3b47bb197", @"/Areas/Musteri/Views/_ViewImports.cshtml")]
    public class Areas_Musteri_Views_Home_CategoryDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Restaurantt.Models.Menu>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Musteri ", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn1 flex-c-m size1 txt3 trans-0-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\AKSAM YAZILIM\source\repos\Restaurantt-Final\Restaurantt\Areas\Musteri\Views\Home\CategoryDetails.cshtml"
  
    ViewData["Title"] = "CategoryDetails";
    Layout = "~/Views/Shared/_MasterPageLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""section-slide"">
		<div class=""wrap-slick1"">
			<div class=""slick1"">
				<div class=""item-slick1 item1-slick1"" style=""background-image: url(/WebSite/images/slide1-01.jpg);"">
					<div class=""wrap-content-slide1 sizefull flex-col-c-m p-l-15 p-r-15 p-t-150 p-b-170"">
						<span class=""caption1-slide1 txt1 t-center animated visible-false m-b-15"" data-appear=""fadeInDown"">
							Hoş Geldiniz
						</span>

						<h2 class=""caption2-slide1 tit1 t-center animated visible-false m-b-37"" data-appear=""fadeInUp"">
							Mersin Restaurant
						</h2>

						<div class=""wrap-btn-slide1 animated visible-false"" data-appear=""zoomIn"">
							<!-- Button1 -->
							");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "918d0a7c3b2702d37dec1c4aea6b5021f10a4c1e5576", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\tMenüler\r\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
						</div>
					</div>
				</div>

				<div class=""item-slick1 item2-slick1"" style=""background-image: url(/WebSite/images/master-slides-02.jpg);"">
					<div class=""wrap-content-slide1 sizefull flex-col-c-m p-l-15 p-r-15 p-t-150 p-b-170"">
						<span class=""caption1-slide1 txt1 t-center animated visible-false m-b-15"" data-appear=""rollIn"">
							Hoş Geldiniz
						</span>

						<h2 class=""caption2-slide1 tit1 t-center animated visible-false m-b-37"" data-appear=""lightSpeedIn"">
						Mersin Restaurant
						</h2>

						<div class=""wrap-btn-slide1 animated visible-false"" data-appear=""slideInUp"">
							<!-- Button1 -->
						 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "918d0a7c3b2702d37dec1c4aea6b5021f10a4c1e7926", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\tMenüler\r\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
						</div>
					</div>
				</div>

				<div class=""item-slick1 item3-slick1"" style=""background-image: url(/WebSite/images/master-slides-01.jpg);"">
					<div class=""wrap-content-slide1 sizefull flex-col-c-m p-l-15 p-r-15 p-t-150 p-b-170"">
						<span class=""caption1-slide1 txt1 t-center animated visible-false m-b-15"" data-appear=""rotateInDownLeft"">
							Hoş Geldiniz
						</span>

						<h2 class=""caption2-slide1 tit1 t-center animated visible-false m-b-37"" data-appear=""rotateInUpRight"">
							Mersin Restaurant
						</h2>

						<div class=""wrap-btn-slide1 animated visible-false"" data-appear=""rotateIn"">
							<!-- Button1 -->
						");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "918d0a7c3b2702d37dec1c4aea6b5021f10a4c1e10286", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\tMenüler\r\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\r\n\t\t\t</div>\r\n\r\n\t\t\t<div class=\"wrap-slick1-dots\"></div>\r\n\t\t</div>\r\n\t</section>\r\n\t<div class=\"section-gallery p-t-20\">\r\n\t\t");
#nullable restore
#line 73 "C:\Users\AKSAM YAZILIM\source\repos\Restaurantt-Final\Restaurantt\Areas\Musteri\Views\Home\CategoryDetails.cshtml"
   Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\r\n\t\t\r\n\t</div>\r\n\r\n\r\n<section class=\"section-lunch bgwhite\">\r\n\r\n\r\n\t<div class=\"container\">\r\n\t\t<div class=\"row p-t-10\">\r\n");
#nullable restore
#line 84 "C:\Users\AKSAM YAZILIM\source\repos\Restaurantt-Final\Restaurantt\Areas\Musteri\Views\Home\CategoryDetails.cshtml"
             if(Model.Count()>0)
			{
              

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\AKSAM YAZILIM\source\repos\Restaurantt-Final\Restaurantt\Areas\Musteri\Views\Home\CategoryDetails.cshtml"
               foreach (var item in Model)
			{
		

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"col-md-12 col-lg-6 \">\r\n\t\t\t\t\t<!-- Block3 -->\r\n\t\t\t\t\t<div class=\"blo3 flex-w flex-col-l-sm m-b-30\">\r\n\t\t\t\t\t\t<div class=\"pic-blo3 size20 bo-rad-10 hov-img-zoom m-r-28\">\r\n\t\t\t\t\t\t\t<a><img");
            BeginWriteAttribute("src", " src=\"", 3171, "\"", 3188, 1);
#nullable restore
#line 93 "C:\Users\AKSAM YAZILIM\source\repos\Restaurantt-Final\Restaurantt\Areas\Musteri\Views\Home\CategoryDetails.cshtml"
WriteAttributeValue("", 3177, item.Image, 3177, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"IMG-MENU\"></a>\r\n\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t<div class=\"text-blo3 size21 flex-col-l-m\">\r\n\t\t\t\t\t\t\t<a class=\"txt21 m-b-3\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 98 "C:\Users\AKSAM YAZILIM\source\repos\Restaurantt-Final\Restaurantt\Areas\Musteri\Views\Home\CategoryDetails.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</a>\r\n\r\n\t\t\t\t\t\t\t<span class=\"txt23\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 102 "C:\Users\AKSAM YAZILIM\source\repos\Restaurantt-Final\Restaurantt\Areas\Musteri\Views\Home\CategoryDetails.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</span>\r\n\r\n\t\t\t\t\t\t\t<span class=\"txt22 m-t-20\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 106 "C:\Users\AKSAM YAZILIM\source\repos\Restaurantt-Final\Restaurantt\Areas\Musteri\Views\Home\CategoryDetails.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (₺)\r\n\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\r\n\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 113 "C:\Users\AKSAM YAZILIM\source\repos\Restaurantt-Final\Restaurantt\Areas\Musteri\Views\Home\CategoryDetails.cshtml"

			}

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Users\AKSAM YAZILIM\source\repos\Restaurantt-Final\Restaurantt\Areas\Musteri\Views\Home\CategoryDetails.cshtml"
             
			}
			else
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"alert alert-warning text-center\">\r\n\t\t\t\t\tSeçtiğiniz kategoriye ait menü bulunamadı!!\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 121 "C:\Users\AKSAM YAZILIM\source\repos\Restaurantt-Final\Restaurantt\Areas\Musteri\Views\Home\CategoryDetails.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\r\n\r\n\r\n\r\n\t\t</div>\r\n\t</div>\r\n</section>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Restaurantt.Models.Menu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
