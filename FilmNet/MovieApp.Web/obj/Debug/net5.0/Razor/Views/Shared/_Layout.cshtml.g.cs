#pragma checksum "C:\Users\bkesk\source\repos\MovieApp\MovieApp.Web\Views\Shared\_Layout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7d0792ae80271c1394c2d6c2f4715c4ebb61a4bb6f3d321ba914727dbb59ea0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\bkesk\source\repos\MovieApp\MovieApp.Web\Views\_ViewImports.cshtml"
using MovieApp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7d0792ae80271c1394c2d6c2f4715c4ebb61a4bb6f3d321ba914727dbb59ea0b", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"122694bc5f38fcdc3216ffd75f1689e1a9b34b2542e47ddcf319cca7739b5ece", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d0792ae80271c1394c2d6c2f4715c4ebb61a4bb6f3d321ba914727dbb59ea0b3252", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                Write(
#nullable restore
#line 6 "C:\Users\bkesk\source\repos\MovieApp\MovieApp.Web\Views\Shared\_Layout.cshtml"
            ViewBag.Title

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@"</title>
    <link href=""/css/style.css"" rel=""stylesheet"" />
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css"" integrity=""sha384-xOolHFLEh07PJGoPkLv1IbcEPTNtaed2xpHsD9ESMhqIYd0nLMwNLD69Npy4HI+N"" crossorigin=""anonymous"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d0792ae80271c1394c2d6c2f4715c4ebb61a4bb6f3d321ba914727dbb59ea0b4874", async() => {
                WriteLiteral("\r\n\r\n    ");
                Write(
#nullable restore
#line 12 "C:\Users\bkesk\source\repos\MovieApp\MovieApp.Web\Views\Shared\_Layout.cshtml"
     RenderSection("message",false)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n    ");
                Write(
#nullable restore
#line 13 "C:\Users\bkesk\source\repos\MovieApp\MovieApp.Web\Views\Shared\_Layout.cshtml"
     await Html.PartialAsync("_navbar")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n    ");
                Write(
#nullable restore
#line 14 "C:\Users\bkesk\source\repos\MovieApp\MovieApp.Web\Views\Shared\_Layout.cshtml"
     RenderSection("header",false)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n\r\n    \r\n    <div class=\"container mt-3\">\r\n\r\n");
#nullable restore
#line 19 "C:\Users\bkesk\source\repos\MovieApp\MovieApp.Web\Views\Shared\_Layout.cshtml"
         if (IsSectionDefined("menu"))
        {

#line default
#line hidden
#nullable disable

                WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-md-3\">\r\n                    ");
                Write(
#nullable restore
#line 23 "C:\Users\bkesk\source\repos\MovieApp\MovieApp.Web\Views\Shared\_Layout.cshtml"
                     RenderSection("menu",false)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-9\">\r\n                    ");
                Write(
#nullable restore
#line 26 "C:\Users\bkesk\source\repos\MovieApp\MovieApp.Web\Views\Shared\_Layout.cshtml"
                     RenderBody()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 29 "C:\Users\bkesk\source\repos\MovieApp\MovieApp.Web\Views\Shared\_Layout.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable

                WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    ");
                Write(
#nullable restore
#line 34 "C:\Users\bkesk\source\repos\MovieApp\MovieApp.Web\Views\Shared\_Layout.cshtml"
                     RenderBody()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 37 "C:\Users\bkesk\source\repos\MovieApp\MovieApp.Web\Views\Shared\_Layout.cshtml"
        }

#line default
#line hidden
#nullable disable

                WriteLiteral(@"
       

        
        
    </div>
    <script src=""https://cdn.jsdelivr.net/npm/jquery@3.5.1/dist/jquery.slim.min.js"" integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-Fy6S3B9q64WdZWQUiU+q4/2Lc9npb8tCaSX9FK7E8HnRr0Jz8D6OP9dO5Vg3Q9ct"" crossorigin=""anonymous""></script>
    ");
                Write(
#nullable restore
#line 46 "C:\Users\bkesk\source\repos\MovieApp\MovieApp.Web\Views\Shared\_Layout.cshtml"
     RenderSection("scripts",false)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
