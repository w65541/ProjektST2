#pragma checksum "C:\Users\HP\Documents\Programowanie studia\ProjektST2\ProjektST2\Webpage\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69995e5b0d595b3f45baa9912ad75e1a1d3b3175"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\HP\Documents\Programowanie studia\ProjektST2\ProjektST2\Webpage\Views\_ViewImports.cshtml"
using Webpage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Documents\Programowanie studia\ProjektST2\ProjektST2\Webpage\Views\_ViewImports.cshtml"
using Webpage.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Documents\Programowanie studia\ProjektST2\ProjektST2\Webpage\Views\Home\Index.cshtml"
using Storage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69995e5b0d595b3f45baa9912ad75e1a1d3b3175", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6290471084a076268dd3d459d1970682844298a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Profil>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/ludek2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Zdjęcie Profilowe"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\HP\Documents\Programowanie studia\ProjektST2\ProjektST2\Webpage\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Nagłówek z nawigacją -->\r\n<!-- Sekcja 2 Szukaj -->\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12 col-lg-12 section search-section\">\r\n            <!--       <h2>Sekcja 2 Szukaj</h2> -->\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69995e5b0d595b3f45baa9912ad75e1a1d3b31755183", async() => {
                WriteLiteral("\r\n                <input class=\"form-control col-sm-12 col-md-10 col-lg-11\" type=\"search\" placeholder=\"Znajdź\" aria-label=\"Search\">\r\n                <button class=\"btn btn-outline-success my-12 my-sm-0\" type=\"submit\">Szukaj</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n<!-- Pierwsza sekcja   -->\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4 section user-profile\">\r\n            <h2>Twój Profil</h2>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "69995e5b0d595b3f45baa9912ad75e1a1d3b31757012", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <h4>");
#nullable restore
#line 31 "C:\Users\HP\Documents\Programowanie studia\ProjektST2\ProjektST2\Webpage\Views\Home\Index.cshtml"
           Write(Model.Imie);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 31 "C:\Users\HP\Documents\Programowanie studia\ProjektST2\ProjektST2\Webpage\Views\Home\Index.cshtml"
                       Write(Model.Nazwisko);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 32 "C:\Users\HP\Documents\Programowanie studia\ProjektST2\ProjektST2\Webpage\Views\Home\Index.cshtml"
             if (@Model.Plec == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p><b>Płeć:</b> Mężczyzna</p>");
#nullable restore
#line 34 "C:\Users\HP\Documents\Programowanie studia\ProjektST2\ProjektST2\Webpage\Views\Home\Index.cshtml"
                                     }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p><b>Płeć:</b> Kobieta</p>");
#nullable restore
#line 36 "C:\Users\HP\Documents\Programowanie studia\ProjektST2\ProjektST2\Webpage\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p><b>Telefon:</b>");
#nullable restore
#line 37 "C:\Users\HP\Documents\Programowanie studia\ProjektST2\ProjektST2\Webpage\Views\Home\Index.cshtml"
                         Write(Model.Telefon);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        </div>



        <div class=""col-md-8 section"">
            <h2 id=""Kandydaci1"">Kandydaci</h2>

            <div class=""card-container row"" id=""Kandydaci"" onload=""test()"">




            </div>


        </div>


        </>
    </div>


    <script>

        document.addEventListener(""DOMContentLoaded"", function () { loadCandidates() });
        //funkcja wczytuje i tworzy karty kandytatów
        function loadCandidates() {
			$.ajax({
				type: ""GET"", dataType: 'json',
				url: '");
#nullable restore
#line 67 "C:\Users\HP\Documents\Programowanie studia\ProjektST2\ProjektST2\Webpage\Views\Home\Index.cshtml"
                 Write(Url.Action("ProfileCom", "DatingSite"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n\t\t\t\tdata: { id: ");
#nullable restore
#line 68 "C:\Users\HP\Documents\Programowanie studia\ProjektST2\ProjektST2\Webpage\Views\Home\Index.cshtml"
                       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"},

				success: function (result) {
					var html = """";
                    for (var i = 0; i < 10 || i<result.lenght; i++) {
                        html += '<div id = ""rej' + result[i]['id'] +'""class=""col-sm-6 col-md-4 col-lg-3 mb-4"">';
                        html += '<div class=""card"">';
                        html += '<div class=""square-img-wrapper"">';
                        html += '<a onClick=""profile(' + result[i]['id'] +')"">';
                        html += '<img src=""/images/ludek1.jpg"" class=""card-img-top img-fluid square-img"" alt=""..."" />';
                        html += '</a>';
                        html += '</div>';
                        html += '<div class=""card-body p-0""> <p class=""card-text ml-2 mr-2 mt-3 mb-3"">';
                        html += result[i][""imie""] + "" "" + result[i][""nazwisko""] +'</p>';
                        html += '<button class=""btn w-50"" id=""btnyes"">&#129505</button><button class=""btn w-50"" id=""btnno"" onClick=""Reject(' + result[i]['id'] +')"" >&#1281");
            WriteLiteral(@"48</button ></div ></div ></div ></div ></div >';
                        document.getElementById(""Kandydaci"").innerHTML += html;
					}

		},
		error: function () {

		}
				});
		}
        
			function Reject(Rid) {

        $.ajax({
            type: ""Get"", dataType: 'json',
            url:'");
#nullable restore
#line 97 "C:\Users\HP\Documents\Programowanie studia\ProjektST2\ProjektST2\Webpage\Views\Home\Index.cshtml"
            Write(Url.Action("Reject", "DatingSite"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            data: { id1 : ");
#nullable restore
#line 98 "C:\Users\HP\Documents\Programowanie studia\ProjektST2\ProjektST2\Webpage\Views\Home\Index.cshtml"
                     Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@", id2: Rid },

            success: function () {
                var id = ""rej"" + Rid;
                alert(id);
				document.getElementById(id).remove();
            },
        error: function () {
            alert(""Wystąpił błąd sprubój ponownie"");
            location.reload();
            }
        });
    }
        function profile(ID) {

            window.location = '");
#nullable restore
#line 113 "C:\Users\HP\Documents\Programowanie studia\ProjektST2\ProjektST2\Webpage\Views\Home\Index.cshtml"
                          Write(Url.Action("Profile", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + \"?id1=\" +");
#nullable restore
#line 113 "C:\Users\HP\Documents\Programowanie studia\ProjektST2\ProjektST2\Webpage\Views\Home\Index.cshtml"
                                                                     Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("+\"&id2=\" + ID + \"&id3=\" + ");
#nullable restore
#line 113 "C:\Users\HP\Documents\Programowanie studia\ProjektST2\ProjektST2\Webpage\Views\Home\Index.cshtml"
                                                                                                        Write(Model.IdUser);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    }\r\n\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Profil> Html { get; private set; }
    }
}
#pragma warning restore 1591
