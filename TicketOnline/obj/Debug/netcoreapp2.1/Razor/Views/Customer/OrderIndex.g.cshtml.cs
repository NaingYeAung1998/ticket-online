#pragma checksum "D:\friends\mt\TicketOnline\TicketOnline\Views\Customer\OrderIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef93e14c02975640e024d0d5ec94d70838e14f37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_OrderIndex), @"mvc.1.0.view", @"/Views/Customer/OrderIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/OrderIndex.cshtml", typeof(AspNetCore.Views_Customer_OrderIndex))]
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
#line 1 "D:\friends\mt\TicketOnline\TicketOnline\Views\_ViewImports.cshtml"
using TicketOnline;

#line default
#line hidden
#line 2 "D:\friends\mt\TicketOnline\TicketOnline\Views\_ViewImports.cshtml"
using TicketOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef93e14c02975640e024d0d5ec94d70838e14f37", @"/Views/Customer/OrderIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f53d8d5345080c1b33f3f97657ea571b9a5c7e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_OrderIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\friends\mt\TicketOnline\TicketOnline\Views\Customer\OrderIndex.cshtml"
  
    ViewData["Title"] = "OrderIndex";

#line default
#line hidden
            BeginContext(66, 338, true);
            WriteLiteral(@"
<br />
<div class=""row""  style=""color:#999"">
    <div class=""col-md-6"" style=""height:300px;"">
        <div style=""background-image:url(/img/profile.jpg);background-position:center;background-size:cover;width:90%;height:100%""></div>
    </div>
    <div class=""col-md-6"">
        <h4>Customer Information</h4>

        <h6>Name - ");
            EndContext();
            BeginContext(405, 36, false);
#line 14 "D:\friends\mt\TicketOnline\TicketOnline\Views\Customer\OrderIndex.cshtml"
              Write(Model.FirstOrDefault().Customer.Name);

#line default
#line hidden
            EndContext();
            BeginContext(441, 27, true);
            WriteLiteral("</h6>\r\n        <h6>Email - ");
            EndContext();
            BeginContext(469, 37, false);
#line 15 "D:\friends\mt\TicketOnline\TicketOnline\Views\Customer\OrderIndex.cshtml"
               Write(Model.FirstOrDefault().Customer.Email);

#line default
#line hidden
            EndContext();
            BeginContext(506, 27, true);
            WriteLiteral("</h6>\r\n        <h6>Phone - ");
            EndContext();
            BeginContext(534, 37, false);
#line 16 "D:\friends\mt\TicketOnline\TicketOnline\Views\Customer\OrderIndex.cshtml"
               Write(Model.FirstOrDefault().Customer.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(571, 112, true);
            WriteLiteral("</h6>\r\n    </div>\r\n</div>\r\n<br />\r\n<hr style=\"background-color:white\" />\r\n<br />\r\n<h4>Your Orders</h4>\r\n<br />\r\n");
            EndContext();
#line 24 "D:\friends\mt\TicketOnline\TicketOnline\Views\Customer\OrderIndex.cshtml"
 foreach (var order in Model)
{

#line default
#line hidden
            BeginContext(717, 125, true);
            WriteLiteral("    <br />\r\n    <div class=\"row\"  style=\"color:#999\">\r\n        <div class=\"col-md-8\" style=\"height:250px;\">\r\n            <div");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 842, "\"", 978, 3);
            WriteAttributeValue("", 850, "background-image:url(/img/posts/", 850, 32, true);
#line 29 "D:\friends\mt\TicketOnline\TicketOnline\Views\Customer\OrderIndex.cshtml"
WriteAttributeValue("", 882, order.Ticket.CoverPhoto, 882, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 906, ");background-position:center;background-size:cover;width:90%;height:100%", 906, 72, true);
            EndWriteAttribute();
            BeginContext(979, 106, true);
            WriteLiteral("></div>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <h4>Order Info</h4>\r\n            <h6>");
            EndContext();
            BeginContext(1086, 17, false);
#line 33 "D:\friends\mt\TicketOnline\TicketOnline\Views\Customer\OrderIndex.cshtml"
           Write(order.Ticket.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1103, 42, true);
            WriteLiteral("</h6>\r\n            <h6>Price Per Ticket - ");
            EndContext();
            BeginContext(1146, 18, false);
#line 34 "D:\friends\mt\TicketOnline\TicketOnline\Views\Customer\OrderIndex.cshtml"
                              Write(order.Ticket.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1164, 39, true);
            WriteLiteral(" ks</h6>\r\n            <h6>Ticket Qty - ");
            EndContext();
            BeginContext(1204, 9, false);
#line 35 "D:\friends\mt\TicketOnline\TicketOnline\Views\Customer\OrderIndex.cshtml"
                        Write(order.Qty);

#line default
#line hidden
            EndContext();
            BeginContext(1213, 36, true);
            WriteLiteral("</h6>\r\n            <h6>Order Date - ");
            EndContext();
            BeginContext(1250, 15, false);
#line 36 "D:\friends\mt\TicketOnline\TicketOnline\Views\Customer\OrderIndex.cshtml"
                        Write(order.CreatedOn);

#line default
#line hidden
            EndContext();
            BeginContext(1265, 85, true);
            WriteLiteral("</h6>\r\n            <hr style=\"background-color:white\" />\r\n            <h6>Order No - ");
            EndContext();
            BeginContext(1351, 13, false);
#line 38 "D:\friends\mt\TicketOnline\TicketOnline\Views\Customer\OrderIndex.cshtml"
                      Write(order.OrderNo);

#line default
#line hidden
            EndContext();
            BeginContext(1364, 43, true);
            WriteLiteral(" &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; ");
            EndContext();
            BeginContext(1408, 10, false);
#line 38 "D:\friends\mt\TicketOnline\TicketOnline\Views\Customer\OrderIndex.cshtml"
                                                                               Write(order.Cost);

#line default
#line hidden
            EndContext();
            BeginContext(1418, 64, true);
            WriteLiteral(" ks</h6>\r\n        </div>\r\n\r\n    </div>\r\n    <br />\r\n    <hr />\r\n");
            EndContext();
#line 44 "D:\friends\mt\TicketOnline\TicketOnline\Views\Customer\OrderIndex.cshtml"
                                             
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
