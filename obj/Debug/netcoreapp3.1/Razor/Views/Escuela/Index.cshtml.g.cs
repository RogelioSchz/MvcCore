#pragma checksum "C:\Users\sisgsanchez\Desktop\Core\MvcProject\Views\Escuela\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faf636f11e6bbdc2271bb874662a72af5d268bac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_Index), @"mvc.1.0.view", @"/Views/Escuela/Index.cshtml")]
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
#line 1 "C:\Users\sisgsanchez\Desktop\Core\MvcProject\Views\_ViewImports.cshtml"
using MvcProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sisgsanchez\Desktop\Core\MvcProject\Views\_ViewImports.cshtml"
using MvcProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faf636f11e6bbdc2271bb874662a72af5d268bac", @"/Views/Escuela/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b195e0951ebb4337c362372a52496a3462d2eef9", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Escuela>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sisgsanchez\Desktop\Core\MvcProject\Views\Escuela\Index.cshtml"
  
    ViewData["Title"] = "Info escuela";


#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Escuela</h1>\r\n<h2>Nombre: ");
#nullable restore
#line 7 "C:\Users\sisgsanchez\Desktop\Core\MvcProject\Views\Escuela\Index.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n<h2>Año: ");
#nullable restore
#line 8 "C:\Users\sisgsanchez\Desktop\Core\MvcProject\Views\Escuela\Index.cshtml"
    Write(Model.AñoDeCreación);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Tipo de escuela: ");
#nullable restore
#line 9 "C:\Users\sisgsanchez\Desktop\Core\MvcProject\Views\Escuela\Index.cshtml"
                Write(Model.TipoEscuela);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<address>\r\n    <p>Dirección: ");
#nullable restore
#line 11 "C:\Users\sisgsanchez\Desktop\Core\MvcProject\Views\Escuela\Index.cshtml"
             Write(Model.Dirección);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Pais: ");
#nullable restore
#line 12 "C:\Users\sisgsanchez\Desktop\Core\MvcProject\Views\Escuela\Index.cshtml"
        Write(Model.Pais);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Ciudad: ");
#nullable restore
#line 13 "C:\Users\sisgsanchez\Desktop\Core\MvcProject\Views\Escuela\Index.cshtml"
          Write(Model.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</address>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Escuela> Html { get; private set; }
    }
}
#pragma warning restore 1591
