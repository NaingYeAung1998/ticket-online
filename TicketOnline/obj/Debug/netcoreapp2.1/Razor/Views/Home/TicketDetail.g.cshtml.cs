#pragma checksum "D:\friends\mt\TicketOnline\TicketOnline\Views\Home\TicketDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0f862b13366039520b39cf33caf922397202d80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TicketDetail), @"mvc.1.0.view", @"/Views/Home/TicketDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/TicketDetail.cshtml", typeof(AspNetCore.Views_Home_TicketDetail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0f862b13366039520b39cf33caf922397202d80", @"/Views/Home/TicketDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f53d8d5345080c1b33f3f97657ea571b9a5c7e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TicketDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ticket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\friends\mt\TicketOnline\TicketOnline\Views\Home\TicketDetail.cshtml"
  
    ViewData["Title"] = "TicketDetail";

#line default
#line hidden
            BeginContext(63, 12, true);
            WriteLiteral("<br />\r\n<h2>");
            EndContext();
            BeginContext(76, 10, false);
#line 6 "D:\friends\mt\TicketOnline\TicketOnline\Views\Home\TicketDetail.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(86, 75, true);
            WriteLiteral("</h2>\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 161, "\"", 293, 3);
            WriteAttributeValue("", 169, "width:100%;height:400px;background-image:url(/img//posts/", 169, 57, true);
#line 10 "D:\friends\mt\TicketOnline\TicketOnline\Views\Home\TicketDetail.cshtml"
WriteAttributeValue("", 226, Model.CoverPhoto, 226, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 243, ");background-size:cover;background-position:center", 243, 50, true);
            EndWriteAttribute();
            BeginContext(294, 96, true);
            WriteLiteral("></div>\r\n    </div>\r\n</div>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <div");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 390, "\"", 522, 3);
            WriteAttributeValue("", 398, "width:80%;height:400px;background-image:url(/img//posts/", 398, 56, true);
#line 16 "D:\friends\mt\TicketOnline\TicketOnline\Views\Home\TicketDetail.cshtml"
WriteAttributeValue("", 454, Model.TicketPhoto, 454, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 472, ");background-size:cover;background-position:center", 472, 50, true);
            EndWriteAttribute();
            BeginContext(523, 61, true);
            WriteLiteral("></div>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <h6>");
            EndContext();
            BeginContext(585, 10, false);
#line 19 "D:\friends\mt\TicketOnline\TicketOnline\Views\Home\TicketDetail.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(595, 18, true);
            WriteLiteral("</h6>\r\n        <p>");
            EndContext();
            BeginContext(614, 17, false);
#line 20 "D:\friends\mt\TicketOnline\TicketOnline\Views\Home\TicketDetail.cshtml"
      Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(631, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(649, 20, false);
#line 21 "D:\friends\mt\TicketOnline\TicketOnline\Views\Home\TicketDetail.cshtml"
      Write(Model.CreatedOn.Date);

#line default
#line hidden
            EndContext();
            BeginContext(669, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(687, 11, false);
#line 22 "D:\friends\mt\TicketOnline\TicketOnline\Views\Home\TicketDetail.cshtml"
      Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(698, 20, true);
            WriteLiteral(" ks</p>\r\n        <p>");
            EndContext();
            BeginContext(719, 9, false);
#line 23 "D:\friends\mt\TicketOnline\TicketOnline\Views\Home\TicketDetail.cshtml"
      Write(Model.Qty);

#line default
#line hidden
            EndContext();
            BeginContext(728, 67, true);
            WriteLiteral(" tickets left</p>\r\n        <hr />\r\n        <h4>Order</h4>\r\n        ");
            EndContext();
            BeginContext(795, 982, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "722ed552bc1948d79052fb3339b77ef5", async() => {
                BeginContext(860, 50, true);
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"TicketId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 910, "\"", 927, 1);
#line 27 "D:\friends\mt\TicketOnline\TicketOnline\Views\Home\TicketDetail.cshtml"
WriteAttributeValue("", 918, Model.Id, 918, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(928, 37, true);
                WriteLiteral(" />\r\n            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 965, "\"", 985, 1);
#line 28 "D:\friends\mt\TicketOnline\TicketOnline\Views\Home\TicketDetail.cshtml"
WriteAttributeValue("", 973, Model.Price, 973, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(986, 784, true);
                WriteLiteral(@" id=""price"" />
            <div class=""row"">
                <div class=""col-md-2"">
                    <label>Qty</label>
                </div>
                <div class=""col-md-4"">
                    <input type=""number"" class=""form-control"" id=""qty"" name=""Qty"" onchange=""changeQty()"" />
                </div>
            </div>
            <br />
            <div class=""row"">
                <div class=""col-md-2"">
                    <label>Total</label>
                </div>
                <div class=""col-md-4"">
                    <input type=""text"" class=""form-control"" readonly name=""Cost"" id=""cost"" />
                </div>
            </div>
            <br />
            <button class=""btn btn-danger"" type=""submit"">Purchase</button>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1777, 434, true);
            WriteLiteral(@"

    </div>
</div>
<br />
<div class=""row"">
    <div class=""col-md-12"" style=""height:300px"">
        <div id=""map"" style=""width:100%;height:100%""></div>
    </div>
</div>

<script>
    function changeQty() {
        var price = $(""#price"").val();
        var qty = $(""#qty"").val();

        $(""#cost"").val(price * qty);
    }

    function initMap() {
        // The location of Uluru
        var uluru = { lat: ");
            EndContext();
            BeginContext(2212, 14, false);
#line 69 "D:\friends\mt\TicketOnline\TicketOnline\Views\Home\TicketDetail.cshtml"
                      Write(Model.Latitude);

#line default
#line hidden
            EndContext();
            BeginContext(2226, 7, true);
            WriteLiteral(", lng: ");
            EndContext();
            BeginContext(2234, 15, false);
#line 69 "D:\friends\mt\TicketOnline\TicketOnline\Views\Home\TicketDetail.cshtml"
                                            Write(Model.Longitude);

#line default
#line hidden
            EndContext();
            BeginContext(2249, 444, true);
            WriteLiteral(@" };
        // The map, centered at Uluru
        var map = new google.maps.Map(
            document.getElementById('map'), { zoom: 4, center: uluru });
        // The marker, positioned at Uluru
        var marker = new google.maps.Marker({ position: uluru, map: map });
    }
</script>
<script async defer
        src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyAN8gOzTMRcSgcN3cscIN1zNNQAWGk9bu0&callback=initMap"">
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ticket> Html { get; private set; }
    }
}
#pragma warning restore 1591
