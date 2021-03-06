#pragma checksum "E:\Users\Owner\Documents\GitHub\bmstorage.github.io-master\BMStorageWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b094a976d7e7852d8c5d12a7f869b75ca670ed11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\Users\Owner\Documents\GitHub\bmstorage.github.io-master\BMStorageWebApp\Views\_ViewImports.cshtml"
using BMStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Users\Owner\Documents\GitHub\bmstorage.github.io-master\BMStorageWebApp\Views\_ViewImports.cshtml"
using BMStorage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b094a976d7e7852d8c5d12a7f869b75ca670ed11", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec734324443072d9246229f34f8cd90de829d98f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Users\Owner\Documents\GitHub\bmstorage.github.io-master\BMStorageWebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""siteContainer"">
    <div class=""parallax-home"">

        <div class=""header"" id=""myHeader"">
            <section class=""headings"">

                <div class=""sticky"">
                    <img class=""Site-Logo"" src=""../images/Thinner Banner.jpg"" alt=""Logo of a Lock"">
                </div>
                <div id=""myNav"" class=""overlay"">
                    <a href=""javascript:void(0)"" class=""closebtn"" onclick=""closeCSNav()"">&times;</a>
                    <div class=""overlay-content"">
                        <a onclick=""closeCSNav()"">Click to go to Static Website</a>
                        <a href=""../homeStatic.html"">Home</a></li>
                        <a href=""../info.html""> Info / Units</a></li>
                        <a class=""active"" href=""../register.html"">Register</a></li>
                    </div>
                </div>
            </section>

            <div class=""holder"">
                <span class=""main-menu-button"" style=""font-size:30px;cursor:pointer"" onclick=""openCSNav()"">&#97");
            WriteLiteral(@"76; Menu</span>
            </div>             
        </div>



        <div class=""content-main"">
            <!--  A call to action to make a sign up for a unit  -->
            <section class=""call-to-action"">
                <!-- Call To Action-->
                <section class=""cta-img"">
                    <p class=""intro-p"">
                        You won't beat our prices!
                    </p>
                    <p class=""intro-p"">
                        Call for a Unit Today!
                    </p>
                    <button onclick=""clickContact()"" class=""btn"">Contact Us!</button>
                </section>
            </section>


            <h2 class=""homepage-h2"">What we Offer</h2>
            <!-- Fill this with Json File that holds Unit info & images -->
            <section class=""homepage-sections"">
                <section class=""unit-1"">
                    <section class=""details"">
                        <h3>Small Units</h3>
                        <img class=""unit-image"" src");
            WriteLiteral(@"=""../images/unit-photo-6.jpg"" alt=""small unit"">
                        <p>Size: 10ft x 10ft </p>
                        <p>Price: 40$ / Month</p>
                    </section>
                </section>

                <section class=""unit-2"">
                    <section class=""details"">
                        <h3>Large Units</h3>
                        <img class=""unit-image"" src=""../images/unit-photo-1.jpg"" alt=""Large Unit"">
                        <p>Size: 11ft x 24ft </p>
                        <p>Price: 70$ / Month</p>
                    </section>
                </section>

                <section class=""unit-3"">
                    <section class=""details"">
                        <h3>Extra Large Units</h3>
                        <img class=""unit-image"" src=""../images/unit-photo-4.jpg"" alt=""Really Big Unit"">
                        <p>Double Doors</p>
                        <p>Size: 22ft x 30ft </p>
                        <p>Price: 140$ / Month</p>
                    </section>
         ");
            WriteLiteral(@"       </section>

                <section class=""unit-4"">
                    <!-- Entering some place holder text to be edited later -->
                        <section class=""details"">
                            <h3>RV / Boat Storage</h3>
                            <img class=""unit-image"" src=""../images/unit-photo-1.jpg"" alt=""An open lot for storing boats and RVs"">
                            <p>Size: 11ft x 30ft </p>
                            <p>Price: 70$ / Month </p>
                        </section>
                </section>
            </section>

            <!-- Expectations -->
            <!-- Get acutal date when when Bart got set up -->
            <section class=""expectation-section"">
                <section class=""company-motto"">
                    <h3>Expectations</h3>
                    <p>
                        We strive to keep things simple, since first creating this family owned and operated business in 1980
                        the goal has been to give people a place to");
            WriteLiteral(@" store their belongings at a reasonable price.
                    </p>

                </section>
            </section>
            <!-- contact information for the Storage Units -->
            <section class=""information-h2"" id=""contact-section"">
                <h2>Contact information</h2>
                <div class=""article-box"">
                    <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d13710.626830452855!2d-111.6802692199318!3d40.05990860798941!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x6b6c439374501d1a!2sB%26M%20Storage!5e0!3m2!1sen!2sus!4v1579539677516!5m2!1sen!2sus""
                            width=""75%"" height=""200px"" frameborder=""0"" style=""border:10;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 4855, "\"", 4873, 0);
            EndWriteAttribute();
            WriteLiteral(@"></iframe>
                    <div class=""contact-p"">
                        <p> B&M Storage:</p>
                        <p> 310 N 100 E</p>
                        <p>Salem, UT 84653</p>
                        <span class=""phone-number"">&#9742; (801) 592-0211</span>
                        <a class=""registration-link"" href=""../register.html""> Registration</a>

                    </div>
                </div>
            </section>

</div>
      
        </div>
    </div>
    <script src=""../scripts/main.js""></script>
    <script src=""../scripts/clickContact.js""></script>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
</html>

");
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
