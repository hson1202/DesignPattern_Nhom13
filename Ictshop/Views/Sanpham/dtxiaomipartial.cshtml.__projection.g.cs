//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

public class _Page_Views_Sanpham_dtxiaomipartial_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Views_Sanpham_dtxiaomipartial_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Views\Sanpham\dtxiaomipartial.cshtml"
    foreach (var item in Model)
    {
        

#line default
#line hidden

#line 2 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Views\Sanpham\dtxiaomipartial.cshtml"
                __o = Url.Action("xemchitiet", new {@Masp=item.Masp });


#line default
#line hidden

#line 3 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Views\Sanpham\dtxiaomipartial.cshtml"
                __o = Url.Content("~" +item.Anhbia.ToString());


#line default
#line hidden

#line 4 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Views\Sanpham\dtxiaomipartial.cshtml"
               __o = item.Tensp;


#line default
#line hidden

#line 5 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Views\Sanpham\dtxiaomipartial.cshtml"
                                 __o = String.Format("{0:0,0}", @item.Giatien);


#line default
#line hidden

#line 6 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Views\Sanpham\dtxiaomipartial.cshtml"
                using (Html.BeginForm("ThemGioHang", "GioHang", new { @iMasp = item.Masp, @strURL = Request.Url.ToString() }))
                {
                    

#line default
#line hidden

#line 7 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Views\Sanpham\dtxiaomipartial.cshtml"
                                                                            

                }

#line default
#line hidden

#line 8 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Views\Sanpham\dtxiaomipartial.cshtml"
              
    }

#line default
#line hidden
}
}
}
