#pragma checksum "C:\Users\Lenovo\Desktop\Azure\Portfolio\PaginaAbove\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46b75252c577159afa7b21791f2808a9d353063d"
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
#line 1 "C:\Users\Lenovo\Desktop\Azure\Portfolio\PaginaAbove\Views\_ViewImports.cshtml"
using PaginaAbove;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\Azure\Portfolio\PaginaAbove\Views\_ViewImports.cshtml"
using PaginaAbove.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46b75252c577159afa7b21791f2808a9d353063d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6d4561219950d484f5700bc1f332ad9c6a11f68", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Lenovo\Desktop\Azure\Portfolio\PaginaAbove\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"about-section\" id=\"about\">\r\n    <div class=\"container\">\r\n        <div class=\"about-header\">\r\n            <h3>SOBRE MÍ</h3>\r\n            <hr />\r\n            <div class=\"about-imag\">\r\n                <img src=\"images/fede1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 284, "\"", 290, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
            </div>
            <div class=""@*about-text*@"" style=""text-align: left; font-size: 15px; color: #7e7e7e; line-height: 1.5em;"">
                <p >Hola, mi nombre es Fede, y el objetivo es contarte en pocas líneas un poco acerca de mí para que me conozcas de forma breve en distintos aspectos de mi vida.</p>                
                <p>Tengo 30 años. Disfruto haciendo actividad física, me gusta pasar tiempo yendo al gimnasio o jugando futbol con amigos. Me gusta la lectura sobre diversos temas, lo cual me llevó a este vasto mundo de la programación.</p>
                <p>Soy muy matero, no importa lo que esté haciendo ni la hora, y no puede faltar nunca en una buena charla.</p>
                <p>Me considero alguien con un espíritu emprendedor, aunque por el momento no es más que una proyección a futuro, no dejo de esperar que la oportunidad acompañada con voluntad, disciplina y aprendije constante converjan en el camino que me llevará a cumplir mis proyectos.</p>
              ");
            WriteLiteral(@"  <p>Para no hacerla más larga, te invito a seguir viendo mi portfolio. Y desde ya, gracias por tu atención!.</p>

            </div>            
            <div class=""clearfix""></div>
        </div>
        <div class=""arrow1"">
            <a href=""#work"" class=""scroll""><img src=""images/arrow1.png""");
            BeginWriteAttribute("alt", " alt=\"", 1623, "\"", 1629, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
        </div>
    </div>
</div>
<!-- about-section-ends -->

<div class=""works-section"" id=""work"">
    <div class=""works-header"">
        <h3>Proyectos</h3>
        <p>Estos son algunos de los proyectos en los que he trabajado.</p>
    </div>
    <div class=""portfolio-section-bottom-row"" id=""portfolio"">
        <div class=""container"">

            <script src=""js/easyResponsiveTabs.js"" type=""text/javascript""></script>
            <script type=""text/javascript"">
                $(document).ready(function() {
                    $('#horizontalTab').easyResponsiveTabs({
                        type: 'default', //Types: default, vertical, accordion
                        width: 'auto', //auto or any width like 600px
                        fit: true // 100% fit in a container
                    });
                });
            </script>
            <link rel=""stylesheet"" href=""css/swipebox.css"">
            <script src=""js/jquery.swipebox.min.js""></script>
            <scri");
            WriteLiteral(@"pt type=""text/javascript"">
                jQuery(function($) {
                    $("".swipebox"").swipebox();
                });
            </script>
            <!-- Portfolio Ends Here -->
            <div class=""sap_tabs"">
                <div id=""horizontalTab"" style=""display: block; width: 100%; margin: 0px;"">
                    <ul class=""resp-tabs-list"">
                        <li class=""resp-tab-item"" aria-controls=""tab_item-0"" role=""tab""><span></span></li>
                        <li class=""resp-tab-item"" aria-controls=""tab_item-1"" role=""tab""><span></span></li>
                        <li class=""resp-tab-item"" aria-controls=""tab_item-2"" role=""tab""><span></span></li>
                        <li class=""resp-tab-item"" aria-controls=""tab_item-3"" role=""tab""><span></span></li>
                        <li class=""resp-tab-item"" aria-controls=""tab_item-4"" role=""tab""><span></span></li>
");
            WriteLiteral(@"                    </ul>
                    <div id=""portfoliolist"">
                        <div class=""resp-tabs-container"">
                            <div class=""tab-1 resp-tab-content"" aria-labelledby=""tab_item-0"">
                                <div class=""tab_img"">
                                    <div class=""col-md-3 img-top grid_box"" style=""margin: 15px"">
                                        <a href=""https://institucional-web.azurewebsites.net/""");
            BeginWriteAttribute("class", " class=\"", 4103, "\"", 4111, 0);
            EndWriteAttribute();
            WriteLiteral(" title=\"Visitar Sitio Web\" target=\"_blank\">\r\n                                            <img src=\"images/ing.jpg\" class=\"img-rounded img-thumbnail img-responsive\"");
            BeginWriteAttribute("alt", " alt=\"", 4275, "\"", 4281, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 100%; height: auto; padding: 1px"">
                                            <span class=""zoom-icon""></span>
                                        </a>
                                    </div>
                                    <div class=""col-md-3 img-top grid_box"" style=""margin: 15px"">
                                        <a href=""https://institucional-gym.azurewebsites.net/""");
            BeginWriteAttribute("class", " class=\"", 4692, "\"", 4700, 0);
            EndWriteAttribute();
            WriteLiteral(" title=\"Visitar Sitio Web\" target=\"_blank\">\r\n                                            <img src=\"images/gym.jpg\" class=\"img-rounded img-thumbnail img-responsive\"");
            BeginWriteAttribute("alt", " alt=\"", 4864, "\"", 4870, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 100%; height: auto; padding: 1px;"">
                                            <span class=""zoom-icon""></span>
                                        </a>
                                    </div>
                                     <div class=""col-md-3 img-top grid_box"" style=""margin: 15px"">
                                        <a href=""https://crud-web.azurewebsites.net/""");
            BeginWriteAttribute("class", " class=\"", 5274, "\"", 5282, 0);
            EndWriteAttribute();
            WriteLiteral(" title=\"Visitar Sitio Web\" target=\"_blank\">\r\n                                            <img src=\"images/crud.jpg\" class=\"img-rounded img-thumbnail img-responsive\"");
            BeginWriteAttribute("alt", " alt=\"", 5447, "\"", 5453, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 100%; height: auto; padding: 1px;"">
                                            <span class=""zoom-icon""></span>
                                        </a>
                                    </div>
                                    <div class=""clearfix""></div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>

            <div class=""arrow"">
                <a href=""#services"" class=""scroll""><img src=""images/arrow.png""");
            BeginWriteAttribute("alt", " alt=\"", 6034, "\"", 6040, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
            </div>
        </div>
    </div>
</div>
<!-- portfolio-section-ends -->

<div class=""services-section"" id=""habilidades"">
    <div class=""container"">
        <div class=""services-header"">
            <h3>Habilidades</h3>
            <p>Éstos son los lenguajes, bibliotecas, sistema de gestión de bases de datos relacional y frameworks con los que trabajo.</p>
            <hr />
        </div>
        <div class=""services-sectiongrids"">

            <div class=""col-md-2 services-grid"">
                <img src=""/Images/html96.png""");
            BeginWriteAttribute("class", " class=\"", 6610, "\"", 6618, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <h4>HTML5</h4>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""col-md-2 services-grid"">
                <img src=""/Images/b96.png""/>                
                <h4>BOOTSTRAP</h4>
            </div>
            <div class=""col-md-2 services-grid"">
                <img src=""/Images/php96.png""");
            BeginWriteAttribute("class", " class=\"", 7121, "\"", 7129, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <h4>PHP</h4>\r\n            </div>\r\n            <div class=\"col-md-2 services-grid\">\r\n                <img src=\"/Images/my96.png\"");
            BeginWriteAttribute("class", " class=\"", 7278, "\"", 7286, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <h4>MySQL</h4>\r\n            </div>\r\n            <div class=\"col-md-2 services-grid\">\r\n                <img src=\"/Images/c96.png\"");
            BeginWriteAttribute("class", " class=\"", 7436, "\"", 7444, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <h4>C#</h4>\r\n            </div>\r\n            <div class=\"col-md-2 services-grid\">\r\n                <img src=\"/Images/n96.png\"");
            BeginWriteAttribute("class", " class=\"", 7591, "\"", 7599, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <h4>.NET</h4>\r\n            </div>\r\n\r\n            <div class=\"clearfix\"></div>\r\n            <div class=\"arrow1\">\r\n                <a href=\"#\r\n\r\n\" class=\"scroll\"><img src=\"images/arrow1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 7809, "\"", 7815, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- services-section-ends -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
