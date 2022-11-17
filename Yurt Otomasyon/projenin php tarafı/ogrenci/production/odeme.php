<?php 
include 'list.php';
include '../netting/baglan.php';
$kullanicisor = $db->prepare("SELECT * FROM veli WHERE id=:id");
$kullanicisor->execute(array(
  'id' => $_GET['id']
));

$id= $_GET['id'];


$kullanicicek = $kullanicisor->fetch(PDO::FETCH_ASSOC);

$sorgu = "SELECT * FROM tbl_ogrenci where veli_id=$id";
$stmt = sqlsrv_query( $conn, $sorgu);   

if($stmt === false) 
{
    die( print_r( sqlsrv_errors(), true) );
}
while( $row = sqlsrv_fetch_array($stmt, SQLSRV_FETCH_ASSOC) )
{
    $ad=$row['ogr_ad'] ;
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
                  <div class="x_title"><br>
                 <a href="index.php" style="padding: 5px;"> <button style="border-radius: 5px; height:40px; background-color: limegreen;" type="button" class="btn btn-success">Panele Dön</button></a> <br>
                  	<h1 style="text-align:center; color:rgb(62, 68, 82); font-size:32px;">ÇANAKKALE ONSEKİZ MART DEVLET YURDU</h1>
                    <h3> <?php echo $ad , " Adlı Öğrencinin Bilgileri"; ?> </h3>

                  
                     
                    <ul class="nav navbar-right panel_toolbox">            
        <div class="x_content">
           <table style=" margin-right: 60em; width:98%; background:rgb(62, 68, 82); color:white;" id="datatable-responsive" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0" >
                      <thead >
                        <tr>
                          <th>AD</th>
                          <th>SOYAD</th>
                          <th>TAKSİT ZAMANI</th>
                          <th>ODENEN MİKTAR</th>
                          <th>KALAN TAKSİT</th>
                        </tr>
                      </thead>

                      <tbody>

                        <?php 
                        $sorgu = "SELECT * FROM tbl_taksit where veli_id=$id";
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
                          <td class="ortalama"><?php echo"",date_format($row['taksitZamani'], 'd/m/y'); ?></td>
                          <td class="ortalama"><?php echo"",$row['odenenMiktar']; ?></td>
                          <td class="ortalama"><?php echo"",$row['kalanTaksit']; ?></td>
                        </tr>
                       <?php 
                       	}
                        ?>
                      
                      </tbody>


                        <table style=" margin-right: 62em; width:98%; background:rgb(62, 68, 82); color:white; font-family: monospace; font-size:14px;" id="datatable-responsive" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0" >
                      <thead >
                        <tr>
                          <th>KALAN PARA</th>
                        </tr>
                      </thead>

                      <tbody>
                        <?php       
                          $sorgu = "SELECT * FROM tbl_borclar WHERE ogr_id=$id";                
            $stmt = sqlsrv_query( $conn, $sorgu);   
            if($stmt === false) 
            {
                die( print_r( sqlsrv_errors(), true) );
            }
            while( $row = sqlsrv_fetch_array($stmt, SQLSRV_FETCH_ASSOC) )
            { 
              ?>
                        <tr style="background:orange; color:white;">
                          <td style="font-size:18px; " class="ortalama"> <?php echo"",$row['ogr_kalanBorc'] ?> </td>            
                        </tr>
                       <?php 
                        }
                        ?>
                      
                      </tbody>
                    </table>
                    <li><a href="odemeyap.php?id=<?php echo $kullanicicek['id']; ?>" style="padding: 5px;"> <button style="border-radius: 5px; height:40px; background-color: blueviolet;" type="button" class="btn btn-primary">ÖDEME YAP</button></li></a> <br>                  
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