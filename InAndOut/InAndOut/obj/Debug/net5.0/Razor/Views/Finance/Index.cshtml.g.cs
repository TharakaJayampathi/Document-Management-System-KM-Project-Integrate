#pragma checksum "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bcc744416c4477a1b14328d4f961c944625f494"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Finance_Index), @"mvc.1.0.view", @"/Views/Finance/Index.cshtml")]
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
#line 1 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\_ViewImports.cshtml"
using InAndOut;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\_ViewImports.cshtml"
using InAndOut.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bcc744416c4477a1b14328d4f961c944625f494", @"/Views/Finance/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b68bf42a2f6da1b0bba0ff4b16a23c8e4ecef32e", @"/Views/_ViewImports.cshtml")]
    public class Views_Finance_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InAndOut.Models.Finance>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Finance", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary mx-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger mx-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<div class=\"row pt-4\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-primary\">Finance List</h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bcc744416c4477a1b14328d4f961c944625f4945755", async() => {
                WriteLiteral("Create new Finance");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"
 if (Model.Count() > 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 21 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"
             using (Html.BeginForm("Index", "Finance", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""form-horizontal"">

                    <div class=""form-group"">

                        <label class=""col-md-2 control-label"">Search</label>

                        <div class=""d-flex"">

                            <input type=""text"" name=""searchTxt"" class=""form-control"" placeholder=""Search your text here"" style=""max-width: 100%"" />

                            <div class=""ml-2"">
                                <button class=""btn btn-primary"" type=""submit""><span class=""glyphicon glyphicon-search""></span>Search</button>
                            </div>
                        </div>
                    </div>

                </div>
");
#nullable restore
#line 40 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>

        <div class=""row"">
            <div class=""col-md-12"">
                <table class=""table table-sm"">
                    <thead>
                        <tr>
                            <th>
                                Id
                            </th>
                            <th style=""text-align:center"">
                                Expense Name
");
            WriteLiteral("                            </th>\r\n                            <th style=\"text-align:center\">\r\n                                Expense Type\r\n");
            WriteLiteral("                            </th>\r\n                            <th style=\"text-align:center\">\r\n                                Amount\r\n");
            WriteLiteral(@"                            </th>
                            <th style=""text-align:center"">
                                Actions
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 71 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"
                         foreach (var finance in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td width=\"5%\">");
#nullable restore
#line 74 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"
                                          Write(finance.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td style=\"text-align:center\" width=\"25%\">");
#nullable restore
#line 75 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"
                                                                     Write(finance.ExpenseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td style=\"text-align:center\" width=\"25%\">");
#nullable restore
#line 76 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"
                                                                     Write(finance.ExpenseType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td style=\"text-align:center\" width=\"25%\">");
#nullable restore
#line 77 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"
                                                                     Write(finance.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td style=\"text-align:center\" width=\"25%\">\r\n                                    <div class=\"w-100 btn-group\" role=\"group\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bcc744416c4477a1b14328d4f961c944625f49412229", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"
                                                                                          WriteLiteral(finance.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bcc744416c4477a1b14328d4f961c944625f49414819", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"
                                                                                          WriteLiteral(finance.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 85 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n\r\n");
#nullable restore
#line 90 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"
                  

                    double totalPages = ViewBag.TotalPages;


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <ul class=\"pagination\">\r\n                        <div class=\"mr-2\">\r\n");
#nullable restore
#line 96 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"
                             if (ViewBag.PageNumber == 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                ");
#nullable restore
#line 99 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"
                           Write(Html.ActionLink("Previous", "Index", new { SortOrder = ViewBag.SortOrder == null ? "Asc" : ViewBag.SortOrder, SortBy = ViewBag.SortBy == null ? "Name" : ViewBag.SortBy, PageNumber = ViewBag.PageNumber }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 101 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"

                        }
                        else
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                ");
#nullable restore
#line 107 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"
                           Write(Html.ActionLink("Previous", "Index", new { SortOrder = ViewBag.SortOrder == null ? "Asc" : ViewBag.SortOrder, SortBy = ViewBag.SortBy == null ? "Name" : ViewBag.SortBy, PageNumber = ViewBag.PageNumber - 1 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 109 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n\r\n\r\n\r\n");
#nullable restore
#line 115 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"
                     for (int i = 1; i <= totalPages; i++)
                    {

                        if (i == ViewBag.PageNumber)
                        {



#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"ml-3\">\r\n                                ");
#nullable restore
#line 123 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"
                           Write(Html.ActionLink(i.ToString(), "Index", new { SortOrder = ViewBag.SortOrder == null ? "Asc" : ViewBag.SortOrder, SortBy = ViewBag.SortBy == null ? "Name" : ViewBag.SortBy, PageNumber = i }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 125 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"

                        }

                        else
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"ml-3\">\r\n                                ");
#nullable restore
#line 132 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"
                           Write(Html.ActionLink(i.ToString(), "Index", new { SortOrder = ViewBag.SortOrder == null ? "Asc" : ViewBag.SortOrder, SortBy = ViewBag.SortBy == null ? "Name" : ViewBag.SortBy, PageNumber = i }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 134 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"

                        }


                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                    <div class=\"ml-4\">\r\n\r\n");
#nullable restore
#line 144 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"
                         if (ViewBag.PageNumber == totalPages)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                ");
#nullable restore
#line 148 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"
                           Write(Html.ActionLink("Next", "Index", new { SortOrder = ViewBag.SortOrder == null ? "Asc" : ViewBag.SortOrder, SortBy = ViewBag.SortBy == null ? "Name" : ViewBag.SortBy, PageNumber = ViewBag.PageNumber }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 150 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"
                        }

                        else
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                ");
#nullable restore
#line 156 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"
                           Write(Html.ActionLink("Next", "Index", new { SortOrder = ViewBag.SortOrder == null ? "Asc" : ViewBag.SortOrder, SortBy = ViewBag.SortBy == null ? "Name" : ViewBag.SortBy, PageNumber = ViewBag.PageNumber + 1 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 158 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n\r\n                    </ul>\r\n");
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 171 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No such Finance record created yet</p>\r\n");
#nullable restore
#line 176 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\Finance\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InAndOut.Models.Finance>> Html { get; private set; }
    }
}
#pragma warning restore 1591
