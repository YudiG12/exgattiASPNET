#pragma checksum "C:\Users\aluno\Desktop\exgattiASPNET\Views\Home\ExJuros.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ca12af24dea1b92b32693608d25186531fc7042"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ExJuros), @"mvc.1.0.view", @"/Views/Home/ExJuros.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ExJuros.cshtml", typeof(AspNetCore.Views_Home_ExJuros))]
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
#line 1 "C:\Users\aluno\Desktop\exgattiASPNET\Views\_ViewImports.cshtml"
using exgattiASPNET;

#line default
#line hidden
#line 2 "C:\Users\aluno\Desktop\exgattiASPNET\Views\_ViewImports.cshtml"
using exgattiASPNET.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca12af24dea1b92b32693608d25186531fc7042", @"/Views/Home/ExJuros.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0b23bd6a5d74495dfa771fbdb647c2ce3e7f7dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ExJuros : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 479, true);
            WriteLiteral(@"<center>
    <input style=""width:30%;margin-top:100px"" id=""meses"" class=""form-control"" type=""number"" placeholder=""Quantidade de meses"">
    <button class=""button"" id=""btn"" onclick=""calc()"">Calcular</button>
    <p class=""pa""id=""pa""></p>
</center>

<script>
    function calc() {
        var meses = document.getElementById(""meses"").value;
        var resultado = 1275*(1+(0.01*meses));
        document.getElementById(""pa"").innerHTML = ""R$""+resultado;
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
