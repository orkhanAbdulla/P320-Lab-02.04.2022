#pragma checksum "C:\Users\hp\Desktop\P320-Lab-02.04.2022\LabAsp\LabP320-02-04-2022\LabP320-02-04-2022\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdda2515e9ce5c25ff615c05bc076a5d3de73412"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\P320-Lab-02.04.2022\LabAsp\LabP320-02-04-2022\LabP320-02-04-2022\Views\_ViewImports.cshtml"
using LabP320_02_04_2022.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\P320-Lab-02.04.2022\LabAsp\LabP320-02-04-2022\LabP320-02-04-2022\Views\_ViewImports.cshtml"
using LabP320_02_04_2022.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdda2515e9ce5c25ff615c05bc076a5d3de73412", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b7ba966a328348befa86377c1d9464497f6cd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/scss/owl.carousel.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/scss/owl.theme.default.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/scss/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/parallax.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/owl.carousel.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/homepage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdda2515e9ce5c25ff615c05bc076a5d3de734126461", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.15.4/css/all.css""
          integrity=""sha384-DyZ88mC6Up2uqS4h/KRgHuoeGwBcD4Ng9SiP4dIRy0EXTlnuz47vAwmeGwVChigm"" crossorigin=""anonymous"">
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Montserrat:wght@100&display=swap"" rel=""stylesheet"">
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
   ");
                WriteLiteral(@" <link href=""https://fonts.googleapis.com/css2?family=Lora:ital@1&display=swap"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css"" />
        <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.css""  />
    <link rel=""stylesheet"" href=""https://unpkg.com/aos@next/dist/aos.css"" />

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cdda2515e9ce5c25ff615c05bc076a5d3de734128246", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cdda2515e9ce5c25ff615c05bc076a5d3de734129425", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cdda2515e9ce5c25ff615c05bc076a5d3de7341210604", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdda2515e9ce5c25ff615c05bc076a5d3de7341212492", async() => {
                WriteLiteral("\r\n    <div class=\"goHeadButton\">\r\n        <i class=\"fas fa-chevron-up\"></i>\r\n    </div>\r\n    ");
#nullable restore
#line 32 "C:\Users\hp\Desktop\P320-Lab-02.04.2022\LabAsp\LabP320-02-04-2022\LabP320-02-04-2022\Views\Shared\_Layout.cshtml"
Write(await Component.InvokeAsync("Header"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <main>\r\n        <div>\r\n            ");
#nullable restore
#line 35 "C:\Users\hp\Desktop\P320-Lab-02.04.2022\LabAsp\LabP320-02-04-2022\LabP320-02-04-2022\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
    </main>

    <footer>
        <div class=""container"">
            <div class=""row"">
                <div class=""top"">
                    <div class=""list col-lg-3 col-md-6 col-12"">
                        <h5>CUSTOMER SERVICE</h5>
                        <ul>
                            <li><a");
                BeginWriteAttribute("href", " href=\"", 2206, "\"", 2213, 0);
                EndWriteAttribute();
                WriteLiteral(">Help & Contact Us</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 2277, "\"", 2284, 0);
                EndWriteAttribute();
                WriteLiteral(">Returns & Refunds</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 2348, "\"", 2355, 0);
                EndWriteAttribute();
                WriteLiteral(">Online Stores</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 2415, "\"", 2422, 0);
                EndWriteAttribute();
                WriteLiteral(@">Terms & Conditions</a></li>
                        </ul>
                    </div>
                    <div class=""list col-lg-3 col-md-6 col-12"">
                        <h5>
                            COMPANY
                        </h5>
                        <ul>
                            <li>
                                <a");
                BeginWriteAttribute("href", " href=\"", 2773, "\"", 2780, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    About Us\r\n                                </a>\r\n                            </li>\r\n                            <li>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 2971, "\"", 2978, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    Blog\r\n                                </a>\r\n                            </li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 3131, "\"", 3138, 0);
                EndWriteAttribute();
                WriteLiteral(">Order Tracking</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 3199, "\"", 3206, 0);
                EndWriteAttribute();
                WriteLiteral(">FAQ Page</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 3261, "\"", 3268, 0);
                EndWriteAttribute();
                WriteLiteral(">Contact Us</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 3325, "\"", 3332, 0);
                EndWriteAttribute();
                WriteLiteral(@">Login</a></li>
                        </ul>
                    </div>
                    <div class=""list col-lg-3 col-md-6 col-12"">
                        <h5>SOCIAL MEDIA</h5>
                        <ul>
                            <li>
                                <a");
                BeginWriteAttribute("href", " href=\"", 3619, "\"", 3626, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    Twitter\r\n                                </a>\r\n                            </li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 3782, "\"", 3789, 0);
                EndWriteAttribute();
                WriteLiteral(">Instagram</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 3845, "\"", 3852, 0);
                EndWriteAttribute();
                WriteLiteral(">Linkedin</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 3907, "\"", 3914, 0);
                EndWriteAttribute();
                WriteLiteral(@">Tumblr</a></li>
                        </ul>
                    </div>
                    <div class=""list col-lg-3 col-md-6 col-12"">
                        <h5>ARCHIVE</h5>
                        <ul>
                            <li>
                                <a");
                BeginWriteAttribute("href", " href=\"", 4197, "\"", 4204, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    Designer Shoes\r\n                                </a>\r\n                            </li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 4367, "\"", 4374, 0);
                EndWriteAttribute();
                WriteLiteral(">Gallery</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 4428, "\"", 4435, 0);
                EndWriteAttribute();
                WriteLiteral(">Pricing</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 4489, "\"", 4496, 0);
                EndWriteAttribute();
                WriteLiteral(">Feature Index</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 4556, "\"", 4563, 0);
                EndWriteAttribute();
                WriteLiteral(">Login</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 4615, "\"", 4622, 0);
                EndWriteAttribute();
                WriteLiteral(@">Help & Support</a></li>
                        </ul>
                    </div>
                </div>
                <div class=""bottom"">
                    <div class=""copyright col-lg-4 col-md-12 col-12"">
                        <span>?? 2018 <a");
                BeginWriteAttribute("href", " href=\"", 4880, "\"", 4887, 0);
                EndWriteAttribute();
                WriteLiteral(@">Qode Interactive</a>, All Rights Reserved</span>
                    </div>
                    <div class=""bankicons col-lg-4 col-md-12 col-12"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/footer-bottom-1.png""");
                BeginWriteAttribute("alt", "\r\n                             alt=\"", 5156, "\"", 5192, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"socialmedia col-lg-4 col-md-12 col-12\">\r\n                        <div class=\"insta\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 5372, "\"", 5379, 0);
                EndWriteAttribute();
                WriteLiteral(">INSTAGRAM</a>\r\n                        </div>\r\n                        <div class=\"face\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 5502, "\"", 5509, 0);
                EndWriteAttribute();
                WriteLiteral(@">FACEBOOK</a>
                        </div>
                    </div>
                </div>
            </div>


        </div>
    </footer>



    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js""
            integrity=""sha512-894YE6QWD5I59HgZOGReFYm4dnWc1Qt5NtvYSaNcOP+u1T9qYdvdihz0PPSiiqn/+/3e7Jo4EaG7TubfWGUrMQ==""
            crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdda2515e9ce5c25ff615c05bc076a5d3de7341221081", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/owl.carousel.min.js""
            integrity=""sha512-bPs7Ae6pVvhOSiIcyUClR7/q2OAsRiovw4vAkX+zJbw3ShAeeqezq50RIIcIURq7Oa20rW2n2q+fyXBNcU9lrw==""
            crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
    <script src=""https://unpkg.com/aos@next/dist/aos.js""></script>


    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdda2515e9ce5c25ff615c05bc076a5d3de7341222556", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdda2515e9ce5c25ff615c05bc076a5d3de7341223656", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdda2515e9ce5c25ff615c05bc076a5d3de7341224756", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.js\"></script>\r\n    ");
#nullable restore
#line 141 "C:\Users\hp\Desktop\P320-Lab-02.04.2022\LabAsp\LabP320-02-04-2022\LabP320-02-04-2022\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scriptss", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
