#pragma checksum "C:\Users\capa6\Desktop\New folder\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Accounts\ForgetPasswordConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9881fe787e1493461b8cc640e39807f6fe3c6462"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_ForgetPasswordConfirmation), @"mvc.1.0.view", @"/Views/Accounts/ForgetPasswordConfirmation.cshtml")]
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
#line 1 "C:\Users\capa6\Desktop\New folder\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\_ViewImports.cshtml"
using Examen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\capa6\Desktop\New folder\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\_ViewImports.cshtml"
using Examen.Models.DataModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\capa6\Desktop\New folder\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\_ViewImports.cshtml"
using Examen.Models.DataTransferModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\capa6\Desktop\New folder\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\_ViewImports.cshtml"
using Examen.Models.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\capa6\Desktop\New folder\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\_ViewImports.cshtml"
using Examen.Models.InputModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\capa6\Desktop\New folder\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\_ViewImports.cshtml"
using Examen.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9881fe787e1493461b8cc640e39807f6fe3c6462", @"/Views/Accounts/ForgetPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"608961145734fd4859998535ebb6bdfc82707c3f", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_ForgetPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<style>

    .header {
        margin-bottom: 20px;
    }

        .header h3 {
            margin-bottom: 5px;
            margin-top: 25px;
        }

    .separator {
        height: 1px;
        background: #e8e8e8;
        margin: 0px -25px;
    }

    .inputs {
        margin-top: 25px;
    }

        .inputs label {
            letter-spacing: 1px;
            margin-bottom: 7px;
        }

        .inputs #submit {
            width: 100%;
            margin-top: 20px;
            padding: 15px 0;
            letter-spacing: 1px;
        }
</style>

<div class=""form-row"">
    <div class=""form-group col-5"">
            <div class=""form-group header"">
                <h3>Olvidé contraseña</h3>
            </div>

            <div class=""form-group"">
                <div class=""clearfix separator""></div>
            </div>

            <div class=""form-group inputs"">
                Si tiene una cuenta con nosotros utilizando el correo electrónico proporcionad");
            WriteLiteral("o, entonces \r\n                recibirá las instrucciones para recuperar la contraseña.\r\n            </div>\r\n\r\n            <div class=\"form-group inputs\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9881fe787e1493461b8cc640e39807f6fe3c64626745", async() => {
                WriteLiteral("Regresar al inicio");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n    </div>\r\n</div>\r\n");
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
