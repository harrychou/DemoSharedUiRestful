﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18213
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SharedUI.Views.Shared
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/OfferCatalog.New.cshtml")]
    public partial class OfferCatalog_New : System.Web.Mvc.WebViewPage<dynamic>
    {
        public OfferCatalog_New()
        {
        }
        public override void Execute()
        {
WriteLiteral("<form");

WriteLiteral(" id=\"frm\"");

WriteLiteral(" action=\"http://localhost:1000/api/OfferCatalog\"");

WriteLiteral(" method=\"GET\"");

WriteLiteral(">\r\n<div>\r\n    <div><label>Zip Code</label><input");

WriteLiteral(" name=\"zip\"");

WriteLiteral(" id=\"zip\"");

WriteLiteral(" type=\"text\"");

WriteLiteral("/></div>\r\n    <div><label>Personal Code</label><input");

WriteLiteral(" name=\"personal_code\"");

WriteLiteral(" id=\"personal_code\"");

WriteLiteral(" type=\"text\"");

WriteLiteral("/></div>\r\n    <div><label>Commodity Type</label><input");

WriteLiteral(" name=\"commodity\"");

WriteLiteral(" id=\"commodity\"");

WriteLiteral(" type=\"text\"");

WriteLiteral("/></div>\r\n    <div><label>Utility</label><input");

WriteLiteral(" name=\"udc\"");

WriteLiteral(" id=\"udc\"");

WriteLiteral(" type=\"text\"");

WriteLiteral("/></div>\r\n</div>\r\n</form>");

        }
    }
}
#pragma warning restore 1591
