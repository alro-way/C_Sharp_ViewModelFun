#pragma checksum "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ViewModelFun\Views\Users\SingleUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71b237ac396c40810eb575ec3c1ae0fa247c3022"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_SingleUser), @"mvc.1.0.view", @"/Views/Users/SingleUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/SingleUser.cshtml", typeof(AspNetCore.Views_Users_SingleUser))]
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
#line 1 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ViewModelFun\Views\_ViewImports.cshtml"
using C_Sharp_ViewModelFun;

#line default
#line hidden
#line 1 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ViewModelFun\Views\Users\SingleUser.cshtml"
using C_Sharp_ViewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71b237ac396c40810eb575ec3c1ae0fa247c3022", @"/Views/Users/SingleUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8afb231e1741f27cd54625081f46d0766838cc82", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_SingleUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ViewModelFun\Views\Users\SingleUser.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(98, 179, true);
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome!</h1>\r\n    <h4>Let\'s do Assignment here!</h4>\r\n    <p>--</p> \r\n    <p>Here is a User!</p>\r\n    <p>--</p> \r\n    <p>");
            EndContext();
            BeginContext(278, 15, false);
#line 15 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ViewModelFun\Views\Users\SingleUser.cshtml"
  Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(293, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(295, 14, false);
#line 15 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ViewModelFun\Views\Users\SingleUser.cshtml"
                   Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(309, 14, true);
            WriteLiteral("</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
