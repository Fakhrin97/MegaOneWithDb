#pragma checksum "C:\Users\f\source\repos\ASP.NET\Lesson.3\shop\shop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d5eff6b490e3c06a97d8ffc5de0d4e7aab42861"
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
#line 1 "C:\Users\f\source\repos\ASP.NET\Lesson.3\shop\shop\Views\_ViewImports.cshtml"
using shop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\f\source\repos\ASP.NET\Lesson.3\shop\shop\Views\_ViewImports.cshtml"
using shop.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d5eff6b490e3c06a97d8ffc5de0d4e7aab42861", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c380da82700876ce82bd25054a47f3c7bbb67e8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\f\source\repos\ASP.NET\Lesson.3\shop\shop\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--SLIDER START-->
<div class=""slider"">
    <div id=""rev_slider_1_1_wrapper"" class=""rev_slider_wrapper fullscreen-container"" data-alias=""slider-shop"" data-source=""gallery"" style=""background:rgba(255,255,255,0);padding:0px;"">
        <!-- START REVOLUTION SLIDER 5.4.8.1 fullscreen mode -->
        <div id=""rev_slider_1_1"" class=""rev_slider fullscreenbanner"" style=""display:none;"" data-version=""5.4.8.1"">
            <ul>

                <!-- SLIDE  -->
");
#nullable restore
#line 15 "C:\Users\f\source\repos\ASP.NET\Lesson.3\shop\shop\Views\Home\Index.cshtml"
                foreach (var item in Model.Slider)
                {
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <li data-index=""rs-3"" data-transition=""fade"" data-slotamount=""default"" data-hideafterloop=""0"" data-hideslideonmobile=""off"" data-easein=""default"" data-easeout=""default"" data-masterspeed=""300"" data-thumb=""assets/100x50_44515-slider-bg-3.jpg"" data-rotate=""0"" data-saveperformance=""off"" data-title=""Slide 3"" data-param1="""" data-param2="""" data-param3="""" data-param4="""" data-param5="""" data-param6="""" data-param7="""" data-param8="""" data-param9="""" data-param10="""" data-description="""">
                        <!-- MAIN IMAGE -->
                        <img");
            BeginWriteAttribute("src", " src=\"", 1185, "\"", 1205, 1);
#nullable restore
#line 20 "C:\Users\f\source\repos\ASP.NET\Lesson.3\shop\shop\Views\Home\Index.cshtml"
WriteAttributeValue("", 1191, item.ImageUrl, 1191, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <!-- LAYER NR. 11 -->
                        <div class=""tp-caption   tp-resizeme rs-parallaxlevel-2""
                         id=""slide-3-layer-1""
                         data-x=""['center','center','center','center']"" data-hoffset=""['0','0','0','0']""
                         data-y=""['middle','middle','middle','middle']"" data-voffset=""['-120','-115','-114','-114']""
                         data-fontsize=""['16','14','14','14']""
                         data-width=""none""
                         data-height=""none""
                         data-whitespace=""nowrap""
                         data-type=""text""
                         data-responsive_offset=""on""
                         data-frames='[{""delay"":10,""speed"":2000,""frame"":""0"",""from"":""y:[-100%];z:0;rX:0deg;rY:0;rZ:0;sX:1;sY:1;skX:0;skY:0;"",""mask"":""x:0px;y:0px;s:inherit;e:inherit;"",""to"":""o:1;"",""ease"":""Power3.easeInOut""},{""delay"":""wait"",""speed"":280,""frame"":""999"",""to"":""opacity:0;"",""ease"":""Power3.easeInOut""}]'
         ");
            WriteLiteral(@"                data-textAlign=""['inherit','inherit','inherit','inherit']""
                         data-paddingtop=""[0,0,0,0]""
                         data-paddingright=""[0,0,0,0]""
                         data-paddingbottom=""[0,0,0,0]""
                         data-paddingleft=""[0,0,0,0]""
                         style=""z-index: 5; white-space: nowrap; font-size: 16px; line-height: 22px; font-weight: 500; color: #eaeaef;font-family:'Poppins', sans-serif;"">
                            ");
#nullable restore
#line 39 "C:\Users\f\source\repos\ASP.NET\Lesson.3\shop\shop\Views\Home\Index.cshtml"
                       Write(item.MainTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>

                        <!-- LAYER NR. 12 -->
                        <div class=""tp-caption   tp-resizeme rs-parallaxlevel-3""
                         id=""slide-3-layer-2""
                         data-x=""['center','center','center','center']"" data-hoffset=""['0','0','0','0']""
                         data-y=""['middle','middle','middle','middle']"" data-voffset=""['-52','-52','-52','-52']""
                         data-fontsize=""['60','60','50','40']""
                         data-width=""none""
                         data-height=""none""
                         data-whitespace=""nowrap""
                         data-type=""text""
                         data-responsive_offset=""on""
                         data-frames='[{""delay"":10,""speed"":2000,""frame"":""0"",""from"":""z:0;rX:0;rY:0;rZ:0;sX:0.9;sY:0.9;skX:0;skY:0;opacity:0;"",""to"":""o:1;"",""ease"":""Power2.easeOut""},{""delay"":""wait"",""speed"":280,""frame"":""999"",""to"":""opacity:0;"",""ease"":""Power3.easeInOut""}]'
                       ");
            WriteLiteral(@"  data-textAlign=""['inherit','inherit','inherit','inherit']""
                         data-paddingtop=""[0,0,0,0]""
                         data-paddingright=""[0,0,0,0]""
                         data-paddingbottom=""[0,0,0,0]""
                         data-paddingleft=""[0,0,0,0]""
                         style=""z-index: 6; white-space: nowrap; font-size: 60px; line-height: 16px; font-weight: 500; color: #ffffff; letter-spacing: 0px;font-family:'Poppins', sans-serif;"">
                            ");
#nullable restore
#line 60 "C:\Users\f\source\repos\ASP.NET\Lesson.3\shop\shop\Views\Home\Index.cshtml"
                       Write(item.Tiitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>

                        <!-- LAYER NR. 13 -->
                        <div class=""tp-caption   tp-resizeme rs-parallaxlevel-2""
                         id=""slide-3-layer-3""
                         data-x=""['center','center','center','center']"" data-hoffset=""['0','0','0','0']""
                         data-y=""['middle','middle','middle','middle']"" data-voffset=""['5','5','5','5']""
                         data-fontsize=""['18','18','16','16']""
                         data-width=""none""
                         data-height=""none""
                         data-whitespace=""nowrap""
                         data-type=""text""
                         data-responsive_offset=""on""
                         data-frames='[{""delay"":10,""speed"":2000,""frame"":""0"",""from"":""y:[100%];z:0;rX:0deg;rY:0;rZ:0;sX:1;sY:1;skX:0;skY:0;opacity:0;"",""mask"":""x:0px;y:[100%];s:inherit;e:inherit;"",""to"":""o:1;"",""ease"":""Power2.easeInOut""},{""delay"":""wait"",""speed"":280,""frame"":""999"",""to"":""opacity:0;"",""ease""");
            WriteLiteral(@":""Power3.easeInOut""}]'
                         data-textAlign=""['inherit','inherit','inherit','inherit']""
                         data-paddingtop=""[0,0,0,0]""
                         data-paddingright=""[0,0,0,0]""
                         data-paddingbottom=""[0,0,0,0]""
                         data-paddingleft=""[0,0,0,0]""
                         style=""z-index: 7; white-space: nowrap; font-size: 18px; line-height: 22px; font-weight: 400; color: #eaeaef; font-family:'Poppins', sans-serif;"">
                            ");
#nullable restore
#line 81 "C:\Users\f\source\repos\ASP.NET\Lesson.3\shop\shop\Views\Home\Index.cshtml"
                       Write(item.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>

                        <div class=""tp-caption rev-btn  rs-parallaxlevel-2""
                         id=""slide-3-layer-4""
                         data-x=""['center','center','center','center']"" data-hoffset=""['0','0','0','0']""
                         data-y=""['middle','middle','middle','middle']"" data-voffset=""['82','82','73','70']""
                         data-width=""none""
                         data-height=""none""
                         data-whitespace=""nowrap""
                         data-type=""text""
                         data-responsive_offset=""on""
                         data-responsive=""off""
                         data-frames='[{""delay"":10,""speed"":2000,""frame"":""0"",""from"":""x:-50px;opacity:0;"",""to"":""o:1;"",""ease"":""Power3.easeInOut""},{""delay"":""wait"",""speed"":280,""frame"":""999"",""to"":""opacity:0;"",""ease"":""Power3.easeInOut""}]'
                         data-textAlign=""['inherit','inherit','inherit','inherit']""
                         data-paddingtop=""[0,");
            WriteLiteral(@"0,0,0]""
                         data-paddingright=""[0,0,0,0]""
                         data-paddingbottom=""[0,0,0,0]""
                         data-paddingleft=""[0,0,0,0]""
                         style=""z-index: 11; max-width:960px; white-space: nowrap; font-size: 12px; line-height: 22px; font-weight: 600; color: #ffffff; letter-spacing: 0px;font-family:Poppins;"">
                            <a href=""#"" class=""btn white-trans-btn-with-white-border""> READ MORE</a>
                        </div>

                    </li>
");
#nullable restore
#line 105 "C:\Users\f\source\repos\ASP.NET\Lesson.3\shop\shop\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                

            </ul>
            <div class=""tp-bannertimer tp-bottom"" style=""visibility: hidden !important;""></div>
        </div>
    </div><!-- END REVOLUTION SLIDER -->
</div>
<!--SLIDER END-->
<!-- START PORTOLIO SECTION -->
<div class=""portfolio-section"">
    <div class=""container"">
        <div class=""row"">

            <!-- START PORTFOLIO HEADING -->
            <div class=""col-12"">
                <div class=""portfolioHeading text-center"">
                    <h1 class=""high-lighted-heading"">Our Luxurious Product</h1>
                    <p>Aenean imperdiet. Etiam ultricies nisi vel augue men tuhi spectrum alle me.</p>
                </div>
            </div>
            <!-- END PORTFOLIO HEADING -->
            <!-- START FILTERS -->
            <div class=""col-12"">
                <div class=""clearfix d-flex justify-content-center"">
                    <div id=""js-filters-blog-posts"" class=""cbp-l-filters-button cbp-1-filters-alignCenter"">
                 ");
            WriteLiteral(@"       <div data-filter=""*"" class=""cbp-filter-item-active cbp-filter-item cbp-l-filters-list-first"">All </div>
                        <div data-filter="".CausalShirts"" class=""cbp-filter-item"">Causal Shirts </div>
                        <div data-filter="".formalShirts"" class=""cbp-filter-item"">Formal Shirts </div>
                        <div data-filter="".others"" class=""cbp-filter-item cbp-l-filters-list-last"">Others </div>
                    </div>
                </div>
            </div>
            <!-- END FILTERS -->
            <!-- START PORTFOLIO IMAGES -->
            <div class=""col-12"">
                <div id=""js-grid-blog-posts"" class=""cbp"">

");
#nullable restore
#line 143 "C:\Users\f\source\repos\ASP.NET\Lesson.3\shop\shop\Views\Home\Index.cshtml"
                     foreach (var item in Model.Prodact)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""cbp-item formalShirts CausalShirts wow slideInUp"">
                            <a class=""portfolio-circle-cart"" href=""shop/shop-cart.html"">
                                <i class=""fa fa-shopping-cart""></i>
                            </a>
                            <div class=""cbp-caption-defaultWrap  owl-theme sync-portfolio-carousel owl-carousel"">
                                <div class=""item""> <a href=""shop/img/product-listing/p26.jpg"" class=""cbp-caption"" data-fancybox=""gallery2"" data-title=""Shirt Name""> <img");
            BeginWriteAttribute("src", " src=\"", 9783, "\"", 9803, 1);
#nullable restore
#line 151 "C:\Users\f\source\repos\ASP.NET\Lesson.3\shop\shop\Views\Home\Index.cshtml"
WriteAttributeValue("", 9789, item.ImageUrl, 9789, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 9804, "\"", 9810, 0);
            EndWriteAttribute();
            WriteLiteral("></a></div>\r\n                                <div class=\"item\"> <a href=\"shop/img/product-listing/p27.jpg\" class=\"cbp-caption\" data-fancybox=\"gallery2\" data-title=\"Shirt Name\"><img");
            BeginWriteAttribute("src", " src=\"", 9991, "\"", 10011, 1);
#nullable restore
#line 152 "C:\Users\f\source\repos\ASP.NET\Lesson.3\shop\shop\Views\Home\Index.cshtml"
WriteAttributeValue("", 9997, item.ImageUrl, 9997, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 10012, "\"", 10018, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></div>
                            </div>

                            <div class=""row"">
                                <div class=""col-12 text-center"">
                                    <a href=""shop/product-detail.html"" target=""_blank"" class=""cbp-l-grid-blog-title portfolio-title"">");
#nullable restore
#line 157 "C:\Users\f\source\repos\ASP.NET\Lesson.3\shop\shop\Views\Home\Index.cshtml"
                                                                                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                                </div>\r\n                                <div class=\"col-12 text-center\">\r\n                                    <div class=\"cbp-l-grid-blog-desc portfolio-des\">$");
#nullable restore
#line 160 "C:\Users\f\source\repos\ASP.NET\Lesson.3\shop\shop\Views\Home\Index.cshtml"
                                                                                Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 164 "C:\Users\f\source\repos\ASP.NET\Lesson.3\shop\shop\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"





                </div>
            </div>
            <!-- END PORTFOLIO IMAGES -->

        </div>
    </div>
</div>
<!-- END PORTOLIO SECTION -->
<!--START BANNER SECTION-->
<div class=""banner-section parallax-slide"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12 col-lg-6 offset-lg-5 text-center"">
                <div class=""banner-content-wrapper"">
                    <span>TRENDING PRODUCT OF THE WEEK</span>
                    <h1>Shirts Collections</h1>
                    <p>Aenean imperdiet. Etiam ultricies nisi vel augue men tuhi spectrum alle me</p>
                    <button type=""button"" class=""btn black-btn-with-border"">SHOP NOW</button>
                </div>
            </div>
        </div>
    </div>
</div>
<!--END BANNER SECTION-->
<!--START LATEST ARRIVALS-->
<div class=""lastest_arrivals"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12 mb-4"">
                <h1>Latest Arri");
            WriteLiteral("vals</h1>\r\n            </div>\r\n\r\n            <div class=\"col-12\">\r\n                <div class=\"lastest_featured_products owl-carousel owl-theme\">\r\n\r\n");
#nullable restore
#line 206 "C:\Users\f\source\repos\ASP.NET\Lesson.3\shop\shop\Views\Home\Index.cshtml"
                     foreach (var item in Model.Arrival)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""lastest_arrival_items item"">
                            <a href=""#"" class=""lastest-addto-cart""><i class=""fa fa-shopping-cart""></i></a>
                            <div class=""card"">
                                <span class=""product-type"">NEW</span>
                                <div class=""image-holder"">
                                    <a href=""shop/img/l1.jpg"" data-fancybox=""lastest_product"" data-title=""Shirt Name"">
                                        <img");
            BeginWriteAttribute("src", " src=\"", 12447, "\"", 12467, 1);
#nullable restore
#line 215 "C:\Users\f\source\repos\ASP.NET\Lesson.3\shop\shop\Views\Home\Index.cshtml"
WriteAttributeValue("", 12453, item.ImageUrl, 12453, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""card-img-top"" alt=""Lastest Arrivals 1"">
                                    </a>
                                </div>
                                <div class=""card-body"">
                                    <div class=""row"">
                                        <div class=""col-12 text-center"">
                                            <h5 class=""card-title"">For ");
#nullable restore
#line 221 "C:\Users\f\source\repos\ASP.NET\Lesson.3\shop\shop\Views\Home\Index.cshtml"
                                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        </div>\r\n                                        <div class=\"col-12 text-center\">\r\n                                            <p class=\"card-text\"> $");
#nullable restore
#line 224 "C:\Users\f\source\repos\ASP.NET\Lesson.3\shop\shop\Views\Home\Index.cshtml"
                                                              Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 230 "C:\Users\f\source\repos\ASP.NET\Lesson.3\shop\shop\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--END LATEST ARRIVALS-->\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
