#pragma checksum "C:\Users\robe1819\source\repos\NewRentCar\NewRentCar\Views\Home\CarConfirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6c4b01701f4e44fe9e4b396d349d7c24db5cd31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CarConfirm), @"mvc.1.0.view", @"/Views/Home/CarConfirm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CarConfirm.cshtml", typeof(AspNetCore.Views_Home_CarConfirm))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6c4b01701f4e44fe9e4b396d349d7c24db5cd31", @"/Views/Home/CarConfirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CarConfirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewRentCar.Models.CarModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 224, true);
            WriteLiteral("\r\n<div class=\"row justify-content-center align-items-center w-100 h-100\">\r\n<div class=\"bg-primary panel-body\"><h2>A new car was added</h2></div>\r\n\r\n<table class=\"table table-bordered table-striped\">\r\n    <tr><th>ID:</th><td>");
            EndContext();
            BeginContext(260, 11, false);
#line 7 "C:\Users\robe1819\source\repos\NewRentCar\NewRentCar\Views\Home\CarConfirm.cshtml"
                   Write(Model.CarID);

#line default
#line hidden
            EndContext();
            BeginContext(271, 39, true);
            WriteLiteral("</td></tr>\r\n    <tr><th>Brand:</th><td>");
            EndContext();
            BeginContext(311, 11, false);
#line 8 "C:\Users\robe1819\source\repos\NewRentCar\NewRentCar\Views\Home\CarConfirm.cshtml"
                      Write(Model.Brand);

#line default
#line hidden
            EndContext();
            BeginContext(322, 39, true);
            WriteLiteral("</td></tr>\r\n    <tr><th>Model:</th><td>");
            EndContext();
            BeginContext(362, 11, false);
#line 9 "C:\Users\robe1819\source\repos\NewRentCar\NewRentCar\Views\Home\CarConfirm.cshtml"
                      Write(Model.Model);

#line default
#line hidden
            EndContext();
            BeginContext(373, 39, true);
            WriteLiteral("</td></tr>\r\n    <tr><th>Color:</th><td>");
            EndContext();
            BeginContext(413, 11, false);
#line 10 "C:\Users\robe1819\source\repos\NewRentCar\NewRentCar\Views\Home\CarConfirm.cshtml"
                      Write(Model.Color);

#line default
#line hidden
            EndContext();
            BeginContext(424, 39, true);
            WriteLiteral("</td></tr>\r\n    <tr><th>Seats:</th><td>");
            EndContext();
            BeginContext(464, 11, false);
#line 11 "C:\Users\robe1819\source\repos\NewRentCar\NewRentCar\Views\Home\CarConfirm.cshtml"
                      Write(Model.Seats);

#line default
#line hidden
            EndContext();
            BeginContext(475, 45, true);
            WriteLiteral("</td></tr>\r\n    <tr><th>NumberPlate:</th><td>");
            EndContext();
            BeginContext(521, 17, false);
#line 12 "C:\Users\robe1819\source\repos\NewRentCar\NewRentCar\Views\Home\CarConfirm.cshtml"
                            Write(Model.NumberPlate);

#line default
#line hidden
            EndContext();
            BeginContext(538, 47, true);
            WriteLiteral("</td></tr>\r\n    <tr><th>Is car washed:</th><td>");
            EndContext();
            BeginContext(586, 17, false);
#line 13 "C:\Users\robe1819\source\repos\NewRentCar\NewRentCar\Views\Home\CarConfirm.cshtml"
                              Write(Model.IsCarWashed);

#line default
#line hidden
            EndContext();
            BeginContext(603, 44, true);
            WriteLiteral("</td></tr>\r\n    <tr><th>Rent price:</th><td>");
            EndContext();
            BeginContext(648, 15, false);
#line 14 "C:\Users\robe1819\source\repos\NewRentCar\NewRentCar\Views\Home\CarConfirm.cshtml"
                           Write(Model.RentPrice);

#line default
#line hidden
            EndContext();
            BeginContext(663, 32, true);
            WriteLiteral("</td></tr>\r\n</table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewRentCar.Models.CarModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
