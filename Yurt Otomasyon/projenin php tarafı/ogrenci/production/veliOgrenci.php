<?php
error_reporting(0);
?>
<?php 
include 'list.php';
include '../netting/baglan.php';
    sqlsrv_query($conn, "SET NAMES utf8");
    sqlsrv_query($conn, "SET CHARACTER SET utf8");
    sqlsrv_query($conn, "SET COLLECTION_CONNECTION='utf8_turkish_ci'");



$kullanicisor = $db->prepare("SELECT * FROM veli WHERE id=:id");
$kullanicisor->execute(array(
  'id' => $_GET['id']
));

$id= $_GET['id'];


$kullanicicek = $kullanicisor->fetch(PDO::FETCH_ASSOC);

$sorgu = "SELECT * FROM tbl_izinler where veli_id=$id";
$stmt = sqlsrv_query( $conn, $sorgu);   

if($stmt === false) 
{
    die( print_r( sqlsrv_errors(), true) );
}
while( $row = sqlsrv_fetch_array($stmt, SQLSRV_FETCH_ASSOC) )
{
    $ad=$row['ogr_ad'];
    $soyad=$row['ogr_soyad'];
}  
  
  $tarih1=$_POST['tarih1'];
  $tarih2=$_POST['tarih2'];

  if (isset($_POST['tum'])) 
  {
    $tarih1="";
  }
   ?>
 <!DOCTYPE html>
 <html>
 <head>
 	<meta charset="utf-8">
 	<title></title>
 	    <link href="../vendors/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet">
    <!-- Font Awesome -->
    <link href="../vendors/font-awesome/css/font-awesome.min.css" rel="stylesheet">
 </head>
 <style>
 	
 	.ortalama{
 		text-align: center;
 	}
 </style>
 <body>
   <div class="right_col" role="main">
          <div class="">
            <div class="page-title">
              <div class="title_left">
               
              </div>

            </div>

            <div class="clearfix"></div>

            <div class="row">
              <div class="col-md-12 col-sm-12 col-xs-12">
         
            
                  <div class="x_content">
                      <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="x_panel">
                  <div class="x_title">
                  	<h1 style="text-align:center; color:rgb(62, 68, 82); font-size:32px;">ÇANAKKALE ONSEKİZ MART DEVLET YURDU</h1>
                    <h3> <?php echo $ad , " ",  $soyad," Adlı Öğrencinin İzin Bilgileri"; ?> </h3>

                  
                     
                    <ul class="nav navbar-right panel_toolbox">            
        <div class="x_content">
                          <form action="#" method="post">             
                          <label>BAŞLANGIÇ <input type="date" name="tarih1" id="tarih1" ></label>
                          <label>BİİTİŞ <input type="date" name="tarih2" id="tarih2" ></label>
                           <button  style="width:10%; height:40px; margin-left:10px; border-radius: 10px; font-family: monospace; font-size:18px;" type="submit" name="filtrele" class="btn btn-primary" style="margin-left:1px; ">FİLTRELE</button> 
                          <button  style="width:15%; height:40px; margin-left:10px; border-radius: 10px; font-family: monospace; font-size:18px;" type="submit" name="tum" class="btn btn-primary" style="margin-left:1px; ">TÜM KAYITLAR</button> 
                        </form><br>

               
<h1>İZİN TABLO</h1>
 <table style=" margin-right: 62em; width:95%; background:rgb(62, 68, 82); color:white;" id="datatable-responsive" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0" >
                      <thead >
                        <tr>
                          <th>AD</th>
                          <th>SOYAD</th>
                          <th>ODA NO</th>
                          <th>YATAK NO</th>
                          <th>GİDİŞ SEBEP</th>
                          <th>GİDİŞ TARİHİ</th>
                          <th>DÖNÜŞ TARİHİ</th>
                        </tr>
                      </thead>

                      <tbody>
                        <?php       
                        $tarih1;                   
                        if (empty($tarih1))
                        {
                         $sorgu = "SELECT * FROM tbl_izinler WHERE veli_id=$id";
                        }
                        else
                        {
                          $sorgu = "SELECT * FROM tbl_izinler WHERE gidisTarih BETWEEN '{$tarih1}' and '{$tarih2}' and veli_id=$id";
                        }                 
            $stmt = sqlsrv_query( $conn, $sorgu);   
            if($stmt === false) 
            {
                die( print_r( sqlsrv_errors(), true) );
            }
            while( $row = sqlsrv_fetch_array($stmt, SQLSRV_FETCH_ASSOC) )
            { 
              ?>
                        <tr style="background:orange; color:white;">
                          <td class="ortalama"> <?php echo"",$row['ogr_ad'] ?> </td>
                          <td class="ortalama"><?php echo"",$row['ogr_soyad']; ?></td>
                          <td class="ortalama"><?php echo"",$row['ogr_odaNo']; ?></td>
                          <td class="ortalama"><?php echo"",$row['ogr_yatakNo']; ?></td>
                          <td class="ortalama"><?php echo"",$row['gidisSebep']; ?></td>
                          <td class="ortalama"><?php echo"",date_format($row['gidisTarih'], 'd/m/y'); ?></td>
                          <td class="ortalama"><?php echo"",date_format($row['donusTarih'], 'd/m/y'); ?></td>                  
                        </tr>
                       <?php 
                        }
                        ?>
                      
                      </tbody>
                    </table>


   

                                <li><a href="index.php" style="padding: 5px;"> <button style="border-radius: 5px; height:40px; background-color: limegreen;" type="button" class="btn btn-success">Panele Dön</button></li></a>                 
                            </div>
                </div>
              </div>
              </div>

              </div>
            </div>
          </div>
        </div> 
</body>
        </html>