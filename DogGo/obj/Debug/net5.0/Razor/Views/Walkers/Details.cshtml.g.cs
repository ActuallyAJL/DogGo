#pragma checksum "C:\Users\zero3\workspace\nss\csharp\DogGo\DogGo\Views\Walkers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36b510966048e8c5926b62597d89997b66db9e78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Walkers_Details), @"mvc.1.0.view", @"/Views/Walkers/Details.cshtml")]
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
#line 1 "C:\Users\zero3\workspace\nss\csharp\DogGo\DogGo\Views\_ViewImports.cshtml"
using DogGo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zero3\workspace\nss\csharp\DogGo\DogGo\Views\_ViewImports.cshtml"
using DogGo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36b510966048e8c5926b62597d89997b66db9e78", @"/Views/Walkers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b50fd1f91f777ae09abf39d99992ea9d25da6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Walkers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DogGo.Models.ViewModels.WalkerFormViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\zero3\workspace\nss\csharp\DogGo\DogGo\Views\Walkers\Details.cshtml"
   ViewData["Title"] ="Profile"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n  <h1 class=\"mb-4\">");
#nullable restore
#line 5 "C:\Users\zero3\workspace\nss\csharp\DogGo\DogGo\Views\Walkers\Details.cshtml"
              Write(Model.Walker.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n  <section class=\"container\">\r\n    <img\r\n      style=\"width:100px;float:left;margin-right:20px\"");
            BeginWriteAttribute("src", "\r\n      src=\"", 239, "\"", 274, 1);
#nullable restore
#line 10 "C:\Users\zero3\workspace\nss\csharp\DogGo\DogGo\Views\Walkers\Details.cshtml"
WriteAttributeValue("", 252, Model.Walker.ImageUrl, 252, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n    />\r\n    <div>\r\n      <label class=\"font-weight-bold\">Name</label>\r\n      <span>");
#nullable restore
#line 14 "C:\Users\zero3\workspace\nss\csharp\DogGo\DogGo\Views\Walkers\Details.cshtml"
       Write(Model.Walker.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n    <div>\r\n      <label class=\"font-weight-bold\">Neighborhood:</label>\r\n      <span>");
#nullable restore
#line 18 "C:\Users\zero3\workspace\nss\csharp\DogGo\DogGo\Views\Walkers\Details.cshtml"
       Write(Model.Walker.Neighborhood.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n  </section>\r\n\r\n  <hr class=\"mt-5\" />\r\n  <div class=\"clearfix\"></div>\r\n\r\n  <div class=\"row\">\r\n    <section class=\"col-8 container mt-5\">\r\n      <h1 class=\"text-left\">Walks</h1>\r\n      <div class=\"row\">\r\n");
#nullable restore
#line 29 "C:\Users\zero3\workspace\nss\csharp\DogGo\DogGo\Views\Walkers\Details.cshtml"
         foreach (Walk walk in Model.Walks) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card m-4\" style=\"width: 18rem;\">\r\n          <div class=\"card-body\">\r\n            <div>\r\n              <label class=\"font-weight-bold\">Date:</label>\r\n              <span>");
#nullable restore
#line 34 "C:\Users\zero3\workspace\nss\csharp\DogGo\DogGo\Views\Walkers\Details.cshtml"
               Write(walk.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            <div>\r\n              <label class=\"font-weight-bold\">Client:</label>\r\n              <span>");
#nullable restore
#line 38 "C:\Users\zero3\workspace\nss\csharp\DogGo\DogGo\Views\Walkers\Details.cshtml"
               Write(walk.Dog.Owner.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            <div>\r\n              <label class=\"font-weight-bold\">Duration:</label>\r\n              <p>");
#nullable restore
#line 42 "C:\Users\zero3\workspace\nss\csharp\DogGo\DogGo\Views\Walkers\Details.cshtml"
            Write(walk.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n          </div>\r\n        </div>\r\n");
#nullable restore
#line 46 "C:\Users\zero3\workspace\nss\csharp\DogGo\DogGo\Views\Walkers\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n          <label class=\"font-weight-bold\">Total Walk Time: </label>\r\n          <span>");
#nullable restore
#line 49 "C:\Users\zero3\workspace\nss\csharp\DogGo\DogGo\Views\Walkers\Details.cshtml"
           Write(Model.TotalDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n      </div>\r\n    </section>\r\n  </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DogGo.Models.ViewModels.WalkerFormViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
