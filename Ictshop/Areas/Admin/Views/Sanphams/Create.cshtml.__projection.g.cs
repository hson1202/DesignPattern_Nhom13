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

public class _Page_Areas_Admin_Views_Sanphams_Create_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Areas_Admin_Views_Sanphams_Create_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
  
    ViewBag.Title = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden

#line 3 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
using (Html.BeginForm()) 
{
    

#line default
#line hidden

#line 4 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
__o = Html.AntiForgeryToken();


#line default
#line hidden

#line 5 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
                            
    


#line default
#line hidden

#line 6 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
__o = Html.ValidationSummary(true, "", new { @class = "text-danger" });


#line default
#line hidden

#line 7 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
   __o = Html.LabelFor(model => model.Tensp, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 8 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
       __o = Html.EditorFor(model => model.Tensp, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 9 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
       __o = Html.ValidationMessageFor(model => model.Tensp, "", new { @class = "text-danger" });


#line default
#line hidden

#line 10 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
   __o = Html.LabelFor(model => model.Giatien, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 11 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
       __o = Html.EditorFor(model => model.Giatien, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 12 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
       __o = Html.ValidationMessageFor(model => model.Giatien, "", new { @class = "text-danger" });


#line default
#line hidden

#line 13 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
   __o = Html.LabelFor(model => model.Soluong, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 14 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
       __o = Html.EditorFor(model => model.Soluong, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 15 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
       __o = Html.ValidationMessageFor(model => model.Soluong, "", new { @class = "text-danger" });


#line default
#line hidden

#line 16 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
   __o = Html.LabelFor(model => model.Mota, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 17 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
       __o = Html.EditorFor(model => model.Mota, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 18 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
       __o = Html.ValidationMessageFor(model => model.Mota, "", new { @class = "text-danger" });


#line default
#line hidden

#line 19 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
   __o = Html.LabelFor(model => model.Thesim, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 20 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
       __o = Html.EditorFor(model => model.Thesim, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 21 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
       __o = Html.ValidationMessageFor(model => model.Thesim, "", new { @class = "text-danger" });


#line default
#line hidden

#line 22 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
   __o = Html.LabelFor(model => model.Bonhotrong, new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 23 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
       __o = Html.DropDownListFor(model => model.Bonhotrong, (SelectList)ViewBag.StorageOptions, new { @class = "form-control" });


#line default
#line hidden

#line 24 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
       __o = Html.ValidationMessageFor(model => model.Bonhotrong, "", new { @class = "text-danger" });


#line default
#line hidden

#line 25 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
   __o = Html.LabelFor(model => model.Sanphammoi, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 26 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
           __o = Html.EditorFor(model => model.Sanphammoi);


#line default
#line hidden

#line 27 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
           __o = Html.ValidationMessageFor(model => model.Sanphammoi, "", new { @class = "text-danger" });


#line default
#line hidden

#line 28 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
   __o = Html.LabelFor(model => model.Ram, new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 29 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
       __o = Html.DropDownListFor(model => model.Ram, (SelectList)ViewBag.StorageOptions, new { @class = "form-control" });


#line default
#line hidden

#line 30 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
       __o = Html.ValidationMessageFor(model => model.Ram, "", new { @class = "text-danger" });


#line default
#line hidden

#line 31 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
   __o = Html.LabelFor(model => model.Anhbia, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 32 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
       __o = Html.EditorFor(model => model.Anhbia, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 33 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
       __o = Html.ValidationMessageFor(model => model.Anhbia, "", new { @class = "text-danger" });


#line default
#line hidden

#line 34 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
   __o = Html.LabelFor(model => model.Mahang, "Mahang", htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 35 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
       __o = Html.DropDownList("Mahang", null, htmlAttributes: new { @class = "form-control" });


#line default
#line hidden

#line 36 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
       __o = Html.ValidationMessageFor(model => model.Mahang, "", new { @class = "text-danger" });


#line default
#line hidden

#line 37 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
   __o = Html.LabelFor(model => model.Mahdh, "Mahdh", htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 38 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
       __o = Html.DropDownList("Mahdh", null, htmlAttributes: new { @class = "form-control" });


#line default
#line hidden

#line 39 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
       __o = Html.ValidationMessageFor(model => model.Mahdh, "", new { @class = "text-danger" });


#line default
#line hidden

#line 40 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
      
}

#line default
#line hidden

#line 41 "C:\Users\Admin\AppData\Local\Temp\1CAF4F21D0414992FE7B26AF3AD46BC7D261\7\DAPM_NHOM2\Ictshop\Areas\Admin\Views\Sanphams\Create.cshtml"
__o = Html.ActionLink("Back to List", "Index");


#line default
#line hidden
}
}
}
