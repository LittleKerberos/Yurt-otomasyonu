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
                    <h3> <?php echo $ad ," Adlı Öğrencinin Bilgileri";?> </h3>               
                  <ul class="nav navbar-right panel_toolbox">            
        <div class="x_content">
           <table style=" margin-right: 65em; width:98%; background:rgb(62, 68, 82); color:white;" id="datatable-responsive" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0" >
                      <thead >
                        <tr>
                          <th>VELİ AD</th>
                          <th>VELİ SOYAD</th>
                          <th>MESLEK</th>
                          <th>TEL NO</th>
                          <th>İŞ NO</th>
                        </tr>
                      </thead>

                      <tbody>

                        <?php 
                        $sorgu = "SELECT * FROM tbl_ogrenci where veli_id=$id";
						$stmt = sqlsrv_query( $conn, $sorgu);   
						if($stmt === false) 
						{
						    die( print_r( sqlsrv_errors(), true) );
						}
 						while( $row = sqlsrv_fetch_array($stmt, SQLSRV_FETCH_ASSOC) )
 						{ 
 							?>
                        <tr style="background:orange; color:white;">
                          <td class="ortalama"> <?php echo"",$row['ogr_veliAd'] ?> </td>
                          <td class="ortalama"><?php echo"",$row['ogr_veliSoyad']; ?></td>
                          <td class="ortalama"><?php echo"",$row['ogr_veliMeslek']; ?></td>
                          <td class="ortalama"><?php echo"",$row['ogr_veliTelNo']; ?></td> 
                          <td class="ortalama"> <?php echo"",$row['ogr_veliIsNo'] ?> </td>             
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