#pragma checksum "C:\Users\Cruz\Documents\ConsultaTemperatura\ConsultaTemperatura\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e711597b03310e1190ec4128c8bd8f9bfe0226b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e711597b03310e1190ec4128c8bd8f9bfe0226b", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tempo.BLL.Models.main>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Cruz\Documents\ConsultaTemperatura\ConsultaTemperatura\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Temperatura";

#line default
#line hidden
            BeginContext(77, 65, true);
            WriteLiteral("\r\n<h2>Temperatura de São Paulo</h2>\r\n\r\n    <p>Temperatura Atual: ");
            EndContext();
            BeginContext(143, 21, false);
#line 8 "C:\Users\Cruz\Documents\ConsultaTemperatura\ConsultaTemperatura\Views\Home\Index.cshtml"
                     Write(Model.tempo.tempAtual);

#line default
#line hidden
            EndContext();
            BeginContext(164, 33, true);
            WriteLiteral("</p>\r\n    <p>Temperatura Minima: ");
            EndContext();
            BeginContext(198, 19, false);
#line 9 "C:\Users\Cruz\Documents\ConsultaTemperatura\ConsultaTemperatura\Views\Home\Index.cshtml"
                      Write(Model.tempo.tempMin);

#line default
#line hidden
            EndContext();
            BeginContext(217, 33, true);
            WriteLiteral("</p>\r\n    <p>Temperatura Maxima: ");
            EndContext();
            BeginContext(251, 19, false);
#line 10 "C:\Users\Cruz\Documents\ConsultaTemperatura\ConsultaTemperatura\Views\Home\Index.cshtml"
                      Write(Model.tempo.tempMax);

#line default
#line hidden
            EndContext();
            BeginContext(270, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tempo.BLL.Models.main> Html { get; private set; }
    }
}
#pragma warning restore 1591