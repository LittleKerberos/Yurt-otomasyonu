<?php 
ob_start();
session_start();

include '../netting/baglan.php';

$ayarsor = $db->prepare("SELECT * FROM ayar WHERE ayar_id=:id");
$ayarsor = $db->prepare("SELECT * FROM menu WHERE menu_id=:id");
$ayarsor = $db->prepare("SELECT * FROM menu WHERE film_id=:id");
$ayarsor->execute(array(
  'id' =>1
));
$ayarcek = $ayarsor->fetch(PDO::FETCH_ASSOC);

$kullanicisor = $db->prepare("SELECT * FROM veli WHERE username=:username");
$kullanicisor->execute(array(
  'username' => $_SESSION['username']
));
$say =$kullanicisor->rowCount();
$kullanicicek = $kullanicisor->fetch(PDO::FETCH_ASSOC);


if ($say==0) 
{
  header("location:login.php?durum=izinsiz");
  exit;
}
 ?>

<!DOCTYPE html>
<html lang="en">
  <head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <!-- Meta, title, CSS, favicons, etc. -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>Veli Template</title>

    <!-- Bootstrap -->
    <link href="../vendors/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet">
    <!-- Font Awesome -->
    <link href="../vendors/font-awesome/css/font-awesome.min.css" rel="stylesheet">
    <!-- NProgress -->
    <link href="../vendors/nprogress/nprogress.css" rel="stylesheet">

     <script src="https://cdn.ckeditor.com/4.11.1/standard/ckeditor.js"></script>

    <!-- Custom Theme Style -->
    <link href="../build/css/custom.min.css" rel="stylesheet">
    
  </head>

  <body class="nav-md">
    <div class="container body">
      <div class="main_container">
        <div class="col-md-3 left_col">
          <div class="left_col scroll-view">
            <div class="navbar nav_title" style="border: 0;">
              <a href="index.php" class="site_title"><span> Veli | Öğrenci Takip </span></a>
            </div>

            <div class="clearfix"></div>

            <!-- menu profile quick info -->
            <div class="profile clearfix">
              <div class="profile_pic">
                <img src="https://www.erpilic.com.tr/NDC/Admin/Images/adminlogo.png" alt="..." class="img-circle profile_img">
              </div>
              <div class="profile_info">
                <span>Hoşgeldin</span>
                <h2><?php echo $kullanicicek['veli_ad']; echo $kullanicicek['veli_soyad']?></h2>
              </div>
              <div class="clearfix"></div>
            </div>
            <!-- /menu profile quick info -->

            <br />

 <div id="sidebar-menu" class="main_menu_side hidden-print main_menu">
              <div class="menu_section">
                <h3>Genel</h3>
                 <ul class="nav side-menu">
                  <!--öğrenci bilgileri--->
                  <li><a><i class="fa fa-cogs"></i> Öğrenci - Veli Bilgileri  <span class="fa fa-cogs"></span></a>
                     <ul class="nav child_menu">
                       <li><a href="ogrenciBilgi.php?id=<?php echo $kullanicicek['id']; ?>">Kişisel Bilgiler</a></li>
                       <li><a href="ogrenciYurtBİlgi.php?id=<?php echo $kullanicicek['id']; ?>">Yurt Bilgileri</a></li>
                       <li><a href="ogrenciVeliBilgi.php?id=<?php echo $kullanicicek['id']; ?>">Veli Bilgileri</a></li>
                    </ul>  
                 </li>
                  <!--İZİM YOKLAMA--->
                   <li><a><i class="fa fa-cogs"></i> İzin / Yoklama  <span class="fa fa-cogs"></span></a>
                        <ul class="nav child_menu">
                          <li><a href="veliOgrenci.php?id=<?php echo $kullanicicek['id']; ?>">İzinler</a></li>
                          <li><a href="yoklama.php?id=<?php echo $kullanicicek['id']; ?>">Yoklama</a></li>
                       </ul>
                   </li>  
                  <!--ÖDEME--->
                  <li><a href="odeme.php?id=<?php echo $kullanicicek['id']; ?>"><i class="fa fa-money"></i> Ödeme <span class="label label-success pull-right"></span></a></li>   
                </ul>
              </div>
            </div>
          
            <!-- /menu footer buttons -->
            <div class="sidebar-footer hidden-small">
              <a data-toggle="tooltip" data-placement="top" title="Settings">
                <span class="glyphicon glyphicon-cog" aria-hidden="true"></span>
              </a>
              <a data-toggle="tooltip" data-placement="top" title="FullScreen">
                <span class="glyphicon glyphicon-fullscreen" aria-hidden="true"></span>
              </a>
              <a data-toggle="tooltip" data-placement="top" title="Lock">
                <span class="glyphicon glyphicon-eye-close" aria-hidden="true"></span>
              </a>
              <a data-toggle="tooltip" data-placement="top" title="Logout">
                <span class="glyphicon glyphicon-off" aria-hidden="true"></span>
              </a>
            </div>
            <!-- /menu footer buttons -->
          </div>
        </div>

        <!-- top navigation -->
        <div class="top_nav">
          <div class="nav_menu">
            <nav>
              <div class="nav toggle">
                <a id="menu_toggle"><i class="fa fa-bars"></i></a>
              </div>

              <ul class="nav navbar-nav navbar-right">
                <li class="">
                  <a href="javascript:;" class="user-profile dropdown-toggle" data-toggle="dropdown" aria-expanded="false">
                    <img src="https://www.erpilic.com.tr/NDC/Admin/Images/adminlogo.png" alt=""><?php echo $kullanicicek['veli_ad']; echo $kullanicicek['veli_soyad']?>
                    <span class=" fa fa-angle-down"></span>
                  </a>
                  <ul class="dropdown-menu dropdown-usermenu pull-right">
                    <li><a href="javascript:;"> Profile</a></li>
                  
                    <li><a href="logout.php"><i class="fa fa-sign-out pull-right"></i> Güvenli Çıkış</a></li>
                  </ul>
                </li>

              </ul>
            </nav>
          </div>
        </div>
        <?php   
require_once "class.log.php";
$txt= $kullanicicek['username'];
$log = new Log();
$log->add( $txt." GİRİŞ YAPTI");
         ?>