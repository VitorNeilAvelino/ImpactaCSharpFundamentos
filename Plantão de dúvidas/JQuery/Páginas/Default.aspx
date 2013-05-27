<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/MasterPages/Home.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Events._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
<!--     <script src="Scripts/jquery.cycle.all.latest.js" type="text/javascript"></script> -->
   <script src="Scripts/jquery-ui-1.8.18.custom.min.js" type="text/javascript"></script> 
    <script src="Scripts/jquery.mousewheel.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery.smoothdivscroll-1.2-min.js" type="text/javascript"></script>
    <script src="Scripts/jquery.smoothDivScroll-1.2.js" type="text/javascript"></script> 
    <script src="Scripts/Home.js" type="text/javascript"></script>
    <link href="Styles/smoothDivScroll.css" rel="stylesheet" type="text/css" />
   
	<link rel="shortcut icon" href="/images/vitrine/favicon.ico">
	<link rel="apple-touch-icon" href="/images/vitrine/apple-touch-icon.png">

	<!-- jQuery (required) -->
	<!-- <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.7/jquery.min.js"></script> -->
	<script>	    window.jQuery || document.write('<script src="Scripts/Vitrine/jquery.min.js"><\/script>')</script>

	<!-- Demo stuff -->
<!--	<link rel="stylesheet" href="Styles/Vitrine/page.css"> -->

	<!-- Anything Slider -->
	<link rel="stylesheet" href="Styles/Vitrine/anythingslider.css">
	<script src="Scripts/Vitrine/jquery.anythingslider.js"></script>

	<!-- AnythingSlider optional extensions -->
	<!-- <script src="js/jquery.anythingslider.fx.js"></script> -->
	<!-- <script src="js/jquery.anythingslider.video.js"></script> -->

	<!-- Define slider dimensions here -->
	<style>
	#slider { width: 700px; height: 390px; }
	</style>



<script type="text/javascript">

    //test();
    
    $(document).ready(function () {

        /*
        $('.slideshow').cycle({
        fx: 'fade',
        speed: 1000,
        timeout: 4000,
        pause: 1
        });
        */

        // DOM Ready
        



        $("#GaleriaScroll").smoothDivScroll({
            mousewheelScrolling: true,
            manualContinuousScrolling: true,
            visibleHotSpotBackgrounds: "always",
            autoScrollingMode: "onstart"
        });


    });  





</script>

</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
 <!--
 <div id="Vitrine" class="slideshow" style="width: 100%; height: 400px; padding: 40px, 50px, 40px, 50px; margin: 40px, 50px, 40px, 50px; background-color:Aqua;">teste</div>
  -->
   <div id="vitrine" style="float:left; width: 80% !important; height: 400px !important;">
  
   </div>
   <div id="Novidades" style="float:left; width: 20% !important; height: 400px !important; background-color: Orange;">
   <div id="Novidades_Title" style="width: 100%; height: 10%">
   Novidades:
   <hr style="height: 2px !important; color: Window;" />
   
   </div>
   <div id="Novidades_Body" class="Novidades_Body" style="text-align:left; width: 100%; height: 90%">
    Erro ao carregar novidades
   </div>
   </div>

 

 <div class="Separacao" style="float: left; width: 100%; height: 100px;">&nbsp;</div>
 <div id="GaleriaScroll" class="Galerias" style="float: left; width: 100%; height: 225px; background-color: Transparent;">
 <div class="divGal1" style="float:left; width: 200px; height: 225px; background-color: White;"><img style="width: 200px !important; height: 100%;" src="Galerias/76 Sevensixclub.jpg" /></div>
 <div class="divesp1" style="float:left; width: 20px; height: 225px; background-color: Transparent;">&nbsp;</div>
 <div class="divGal2" style="float:left; width: 200px; height: 225px; background-color: White;"><img style="width: 200px !important; height: 100%;" src="Galerias/Balada-em-foz.jpg" /></div>
 <div class="divesp2" style="float:left; width: 200px; height: 225px; background-color: Transparent;">&nbsp;</div>
 <div class="divGal3" style="float:left; width: 200px; height: 225px; background-color: White;"><img style="width: 200px !important; height: 100%;" src="Galerias/Baladas-goias.jpg" /></div>
 <div class="divesp3" style="float:left; width: 20px; height: 225px; background-color: Transparent;">&nbsp;</div>
 <div class="divGal4" style="float:left; width: 200px; height: 225px; background-color: White;"><img style="width: 200px !important; height: 100%;" src="Galerias/baladas-sorocaba.jpg" /></div>
 <div class="divesp3" style="float:left; width: 20px; height: 225px; background-color: Transparent;">&nbsp;</div>
  <div class="divGal1" style="float:left; width: 200px; height: 225px; background-color: White;"><img style="width: 200px !important; height: 100%;" src="Galerias/baladas abelvolks4.jpg" /></div>
 <div class="divesp1" style="float:left; width: 20px; height: 225px; background-color: Transparent;">&nbsp;</div>
 <div class="divGal2" style="float:left; width: 200px; height: 225px; background-color: White;"><img style="width: 200px !important; height: 100%;" src="Galerias/dsc_0212blog.jpg" /></div>
 <div class="divesp2" style="float:left; width: 20px; height: 225px; background-color: Transparent;">&nbsp;</div>
 <div class="divGal3" style="float:left; width: 200px; height: 225px; background-color: White;"><img style="width: 200px !important; height: 100%;" src="Galerias/hqdefault.jpg" /></div>
 <div class="divesp3" style="float:left; width: 20px; height: 225px; background-color: Transparent;">&nbsp;</div>
 <div class="divGal4" style="float:left; width: 200px; height: 225px; background-color: White;"><img style="width: 200px !important; height: 100%;" src="Galerias/tocando-stand-pioneer.jpg" /></div>
 <div class="divesp3" style="float:left; width: 20px; height: 225px; background-color: Transparent;">&nbsp;</div>
 </div>
 <!--

 <div style=" float:left; width: 100%; height: 150px;">&nbsp;</div>
 <div style="float:left; width: 100%; height: 450px; background-color: Blue;">
 <div style="float:left; width: 32%; height: 450px; background-color: gray; border: 1px;">
 
 
 
 </div>
  <div style="float:left; width: 2%; height: 450px; background-color: transparent;"></div>
 <div style="float:left; width: 32%; height: 450px; background-color: gray; border: 1px;">
 
 
 
 </div>
 <div style="float:left; width: 2%; height: 450px; background-color: transparent;"></div>
 <div style="float:left; width: 32%; height: 450px; background-color: gray; border: 1px;">
 
 
 
 </div>
 
 </div>

 -->

 <div runat="server" class="DivHiddenVitrine" id="DivHiddenVitrine" style="display: none !important">&nbsp;</div>

<script type="text/javascript" language="javascript">
   // alert("teste");
   RenderVitrineHome();
    // alert()
    //AutoStartOn();

   

   $(document).ready(function () {
       $('#slider').anythingSlider({
           // theme : 'metallic',
           expand: true,
           autoPlay: true
       });
   });

  GetTopNovidades();
</script>

</asp:Content>
