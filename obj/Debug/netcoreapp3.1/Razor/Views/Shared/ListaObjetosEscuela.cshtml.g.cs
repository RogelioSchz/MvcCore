#pragma checksum "C:\Users\sisgsanchez\Desktop\Core\MvcProject\Views\Shared\ListaObjetosEscuela.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ebe212b0f02e1c46eb4fb0a6714fec4ecfbf37e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ListaObjetosEscuela), @"mvc.1.0.view", @"/Views/Shared/ListaObjetosEscuela.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ebe212b0f02e1c46eb4fb0a6714fec4ecfbf37e", @"/Views/Shared/ListaObjetosEscuela.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b195e0951ebb4337c362372a52496a3462d2eef9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ListaObjetosEscuela : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table table-dark table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">Id</th>\r\n            <th scope=\"col\">Nombre</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 11 "C:\Users\sisgsanchez\Desktop\Core\MvcProject\Views\Shared\ListaObjetosEscuela.cshtml"
         foreach (var obj in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 14 "C:\Users\sisgsanchez\Desktop\Core\MvcProject\Views\Shared\ListaObjetosEscuela.cshtml"
               Write(obj.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 15 "C:\Users\sisgsanchez\Desktop\Core\MvcProject\Views\Shared\ListaObjetosEscuela.cshtml"
               Write(obj.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 17 "C:\Users\sisgsanchez\Desktop\Core\MvcProject\Views\Shared\ListaObjetosEscuela.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591