#pragma checksum "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4df5648808439741cbb325fe29143d84695edfbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#line 1 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\_ViewImports.cshtml"
using BuyFood_Template;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\_ViewImports.cshtml"
using BuyFood_Template.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4df5648808439741cbb325fe29143d84695edfbd", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1f52bc86e72f64e29fd651d74892b57efe0e70f", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BuyFood_Template.ViewModels.CProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary  btn-rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/vendors/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
  
    Layout = "_LayoutAd";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 6 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
  
    ViewData["Title"] = "List";
    //Layout = null;


#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 12 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
  

    擺腹BuyFoodContext db = new 擺腹BuyFoodContext();

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<h1>產品檢視</h1>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4df5648808439741cbb325fe29143d84695edfbd7171", async() => {
                WriteLiteral("\n    <h2>關鍵字查詢</h2> <input type=\"text\" name=\"pkeyword\" /><input type=\"submit\" value=\"送出\" />\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<h2>類別查詢</h2>\n<select id=\"p產品下拉選單\"></select>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4df5648808439741cbb325fe29143d84695edfbd8751", async() => {
                WriteLiteral(@"
    <input type=""hidden"" name=""pkeyword2"" id=""p產品類別輸出"" /><input type=""submit"" value=""查詢"">
    <script>
        $(""#p產品下拉選單"").click(function () {
            //console.log($('#p產品下拉選單 option:selected').val());
            aa = $('#p產品下拉選單 option:selected').val();
            $(""#p產品類別輸出"").attr(""value"", aa);
        })
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4df5648808439741cbb325fe29143d84695edfbd10537", async() => {
                WriteLiteral(@"
    <style>
        #mwt_mwt_slider_scroll {
            top: 300px;
            left: -230px;
            width: 230px;
            position: absolute;
            z-index: 1; /*優先級*/
        }

        #mwt_slider_content {
            background: #3c5a98;
            text-align: center;
            padding-top: 20px;
            position: relative;
        }


        #mwt_fb_tab {
            position: absolute;
            top: 20px;
            right: -24px;
            width: 24px;
            background: #3c5a98;
            color: #ffffff;
            font-family: Arial, Helvetica, sans-serif;
            text-align: center;
            padding: 9px 0;
            -moz-border-radius-topright: 10px;
            -moz-border-radius-bottomright: 10px;
            -webkit-border-top-right-radius: 10px;
            -webkit-border-bottom-right-radius: 10px;
        }

            #mwt_fb_tab span {
                display: block;
                height: 12px;
                padding: 1px 0;
               ");
                WriteLiteral(" line-height: 30px;\n                text-transform: uppercase;\n                font-size: 30px;\n            }\n    </style>\n\n");
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
            WriteLiteral(@"

<div>
    <div id=""mwt_mwt_slider_scroll"">
        <div id=""mwt_fb_tab"">
            <p>商</p>
            <p>品</p>
            <p>種</p>
            <p>類</p>



        </div>
        <div id=""mwt_slider_content"">
            <p>麵食</p>
            <p>飯食</p>
            <p>飲品</p>
            <p></p>
        </div>
    </div>

</div>







<script ");
            WriteLiteral(@">
    $(function () {
        var w = $(""#mwt_slider_content"").width();
        $(""#mwt_slider_content"").css(""height"", ($(window).height() - 20) + ""px""); //將區塊自動撐滿畫面高度

        $(""#mwt_fb_tab"").mouseover(function () { //滑鼠滑入時
            if ($(""#mwt_mwt_slider_scroll"").css('left') == '-' + w + 'px') {
                $(""#mwt_mwt_slider_scroll"").animate({ left: '0px' }, 600, 'swing')
            }
        });


        $(""#mwt_slider_content"").mouseleave(function () {　//滑鼠離開後
            $(""#mwt_mwt_slider_scroll"").animate({ left: '-' + w + 'px' }, 600, 'swing');
        });
    });

</script>



<script>
    var abc;
    $.ajax({
        url: ""/Product/CheckAccount"",
        type: ""Get"",
        success: function (data) {
            //abc = data.split("","");
            txt = """";
            console.log(data);
            for (let i = 0; i < data.length; i++) {
                txt += ""<option value='"" + data[i].cProductCategoryId + ""'>"" + data[i].cCategoryName + ""</option>"";
            }
            document");
            WriteLiteral(".getElementById(\"p產品下拉選單\").innerHTML = txt;\n        }\n    });\n\n</script>\n\n");
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"ibox\" style=\"z-index:0\">\n    <div class=\"ibox-head\">\n        <div class=\"ibox-title\">\n            <a class=\"btn btn-danger btn-rounded\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4905, "\"", 4915, 0);
            EndWriteAttribute();
            WriteLiteral(">刪除多筆</a>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4df5648808439741cbb325fe29143d84695edfbd14639", async() => {
                WriteLiteral("新增產品");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4df5648808439741cbb325fe29143d84695edfbd16175", async() => {
                WriteLiteral("新增類別");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral(@"        </div>
    </div>

    <div class=""ibox-body"">
        <div class=""table-responsive"">
            <table class=""table table-hover"">
                <thead class=""thead-default"">
                    <tr>
                        <th width=""50px"">
                            <label class=""ui-checkbox"">
                                <input type=""checkbox"" id=""chElt"" onclick=""checkOrCancelAll();"">
                                <span class=""input-span""></span>
                            </label>
                        </th>
                        <th>
                            序
                        </th>
                        <th>
                            ");
#nullable restore
#line 215 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
                       Write(Html.DisplayNameFor(model => model.CCategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 218 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
                       Write(Html.DisplayNameFor(model => model.CPicture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 221 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
                       Write(Html.DisplayNameFor(model => model.CProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 224 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
                       Write(Html.DisplayNameFor(model => model.CPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 227 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
                       Write(Html.DisplayNameFor(model => model.CQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 230 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
                       Write(Html.DisplayNameFor(model => model.CIsOnSaleId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 233 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
                       Write(Html.DisplayNameFor(model => model.CDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>操作</th>\n                    </tr>\n                </thead>\n                <tbody>\n");
#nullable restore
#line 239 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
                      int count = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 240 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
                     foreach (var item in Model)
                    {
                        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <tr>
                            <td>
                                <label class=""ui-checkbox"">
                                    <input type=""checkbox"" name=""interest"">
                                    <span class=""input-span""></span>
                                </label>
                            </td>
                            <td>");
#nullable restore
#line 250 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
                           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>\n");
#nullable restore
#line 252 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
                                  
                                    var p = db.TProductCategories.Where(n => n.CProductCategoryId == item.CategoryIdComBox回傳).Select(n => n.CCategoryName).FirstOrDefault();
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
#nullable restore
#line 255 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
                           Write(p);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("                            </td>\n                            <td>\n                                <img");
            BeginWriteAttribute("src", " src=\"", 7944, "\"", 7977, 1);
#nullable restore
#line 259 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
WriteAttributeValue("", 7950, Url.Content(item.CPicture), 7950, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200\" height=\"240\" /><br />\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 262 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 265 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 268 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 271 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CIsOnSaleId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 274 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 277 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
                           Write(Html.ActionLink("修改", "Edit", new { id = item.CProductId }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n\n                                ");
#nullable restore
#line 279 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
                           Write(Html.ActionLink("刪除", "Delete", new { id = item.CProductId }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                <button class=\"btn btn-default btn-xs m-r-5\"");
            BeginWriteAttribute("onclick", " onclick=\"", 9215, "\"", 9284, 1);
#nullable restore
#line 282 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
WriteAttributeValue("", 9225, Url.ActionLink("修改", "Edit", new { id = item.CProductId }), 9225, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-pencil font-14\"></i></button>\n                                <button class=\"btn btn-default btn-xs\"");
            BeginWriteAttribute("onclick", " onclick=\"", 9402, "\"", 9491, 3);
            WriteAttributeValue("", 9412, "clickLink(\'", 9412, 11, true);
#nullable restore
#line 283 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
WriteAttributeValue("", 9423, Url.Action("ActionName", "ControllerName", new{ /*routeValue*/ }), 9423, 66, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9489, "\')", 9489, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash font-14\"></i></button>\n                            </td>\n                        </tr>\n");
#nullable restore
#line 286 "C:\Users\User\Downloads\BuyFood-master\BuyFood-master\BuyFood_Template\Views\Product\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
</div>

<!-- BEGIN PAGA BACKDROPS-->
<div class=""sidenav-backdrop backdrop""></div>
<div class=""preloader-backdrop"">
    <div class=""page-preloader"">Loading</div>
</div>
<!-- END PAGA BACKDROPS-->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4df5648808439741cbb325fe29143d84695edfbd28372", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    function checkOrCancelAll() {
        //1.獲取checkbo的元素對象
        var chElt = document.getElementById(""chElt"");
        //2.獲取選中狀態
        var checkedElt = chElt.checked;
        console.log(checkedElt)
        //3.若checked=true,將所有的復選框選中,checked=false,將所有的復選框取消
        var allCheck = document.getElementsByName(""interest"");
        //4.循環遍歷取出每一個復選框中的元素
        //var mySpan=document.getElementById(""mySpan"");
        if (checkedElt) {
            //全選
            for (var i = 0; i < allCheck.length; i++) {
                //設置復選框的選中狀態
                allCheck[i].checked = true;
            }
            //mySpan.innerHTML=""取消全選"";
        } else {
            //取消全選
            for (var i = 0; i < allCheck.length; i++) {
                allCheck[i].checked = false;
            }
            //mySpan.innerHTML=""全選"";
        }
    };
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BuyFood_Template.ViewModels.CProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
