#pragma checksum "C:\Users\ruwar\OneDrive\Desktop\Grand Circus Projects\Labs\Coffee_Shop_Lab\Coffee_Shop_Lab\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "205877eeb1f87231b9483f890bfacafc383e2160"
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
#line 1 "C:\Users\ruwar\OneDrive\Desktop\Grand Circus Projects\Labs\Coffee_Shop_Lab\Coffee_Shop_Lab\Views\_ViewImports.cshtml"
using Coffee_Shop_Lab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ruwar\OneDrive\Desktop\Grand Circus Projects\Labs\Coffee_Shop_Lab\Coffee_Shop_Lab\Views\_ViewImports.cshtml"
using Coffee_Shop_Lab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"205877eeb1f87231b9483f890bfacafc383e2160", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ff87d17442fc63598f91cfbb983868bb238c5bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ruwar\OneDrive\Desktop\Grand Circus Projects\Labs\Coffee_Shop_Lab\Coffee_Shop_Lab\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"" style=""color:blue"">Welcome to the Coffee Shop Lab!</h1>
    <h3 style=""color:green"">Click the link above to add a new user.</h3>
</div>

<img src=""https://s3.amazonaws.com/factmag-images/wp-content/uploads/2015/03/snoop-hogan.jpg"" alt=""HulkFlex"" draggable=""false"" class=""center"" />

<div id=""brotherButton"">
    <audio id=""brother"" src=""brother.mp3"" preload=""auto""></audio>
    <button onclick=""document.getElementById('brother').play().pause();"" class=""center"">Hulkamania!</button>
</div>");
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
