<?php
error_reporting(0);
?>
<?php 
include 'list.php';
include '../netting/baglan.php';
$kullanicisor = $db->prepare("SELECT * FROM veli WHERE id=:id");
$kullanicisor->execute(array(
  'id' => $_GET['id']
));

$id= $_GET['id'];

$kullanicicek = $kullanicisor->fetch(PDO::FETCH_ASSOC);

$sorgu = "SELECT * FROM tbl_taksit where veli_id=$id";
$stmt = sqlsrv_query( $conn, $sorgu);   

if($stmt === false) 
{
    die( print_r( sqlsrv_errors(), true) );
}
while( $row = sqlsrv_fetch_array($stmt, SQLSRV_FETCH_ASSOC) )
{
    $ad=$row['ogr_ad'];
    $kalanTaksit=$row['kalanTaksit']-1;
    if ($kalanTaksit<0)
    {
     echo '';    

     header("Refresh: 0.001; url=index.php");
    echo '<script>alert("TÜM BORÇLARINIZ ÖDENDİ ANASAYFAYA YÖNLENDİRİYORSUNUZ...")</script>';
    } 
}

$sorgu = "SELECT * FROM tbl_borclar where ogr_id=$id";
$stmt = sqlsrv_query( $conn, $sorgu);   
if($stmt === false) 
{
    die( print_r( sqlsrv_errors(), true) );
}
while( $row = sqlsrv_fetch_array($stmt, SQLSRV_FETCH_ASSOC) )
{
    $kalan=$row['ogr_kalanBorc'] ;
     if ($kalan==0)
    {
    header("Refresh: 0.001; url=index.php");
    echo '<script>alert("TÜM BORÇLARINIZ ÖDENDİ ANASAYFAYA YÖNLENDİRİYORSUNUZ...")</script>';
    } 
}
$miktar=$_POST['odenenMiktar'];
if ($miktar<=0 or $miktar>$kalan)
{
 $alert=0;
}
else
{
function getData()
{
  $data=array();
  $data[2]=$_POST['ogr_ad'];
  $data[3]=$_POST['ogr_soyad'];
  $data[4]=$_POST['taksitZamani'];
  $data[5]=$_POST['odenenMiktar'];
  $data[6]=$_POST['veli_id'];
  $data[7]=$_POST['kalanTaksit'];
  return $data;
}
if (isset($_POST['odemeyap'])) 
{
  $info=getData();
  $insert="INSERT INTO [tbl_taksit]
   (
   [ogr_ad]
  ,[ogr_soyad]
  ,[taksitZamani]
  ,[odenenMiktar]
  ,[veli_id] 
  ,[kalanTaksit]
)  
VALUES('$info[2]','$info[3]','$info[4]','$info[5]','$info[6]',$info[7])";
$stmt = sqlsrv_query( $conn, $insert, $info);
}
$kalan-=$miktar;
$sql = "
UPDATE tbl_borclar SET
ogr_kalanBorc = '{$kalan}'
WHERE ogr_id=$id 
";
$stmt = sqlsrv_query( $conn, $sql);
if( $stmt === false ) {
die( print_r( sqlsrv_errors(), true));
}
else
{
  header("Refresh: 0.001; url=index.php");
}
sqlsrv_close($conn);
}


 ?>
 <!DOCTYPE html>
 <html>
 <head>
  <meta charset="utf-8">
  <title></title>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.4.1/css/all.css" integrity="sha384-5sAR7xN1Nv6T6+dT2mhtzEpVJvfS3NScPQTrOxhwjIuvcA67KV2R5Jz6kr4abQsz" crossorigin="anonymous">
    <link href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700" rel="stylesheet">
    <meta charset="utf-8">
 </head>
 <style>
      html, body 
      {
      min-height: 100%;
      }
      body, div, form, input, select, p { 
      padding: 0;
      margin: 0;
      outline: none;
      font-family: Roboto, Arial, sans-serif;
      font-size: 16px;
     color: #eee;

      }
      h1, h2 {
      text-transform: uppercase;
      font-weight: 400;
      }
      h2 {
      margin: 0 0 0 8px;
      }
      .main-block {
      display: flex;
      flex-direction: column;
      justify-content: center;
      align-items: center;
      height: 100%;
      padding: 25px;
      }
      .left-part, form {
      padding: 25px;
      }
      .left-part {
      text-align: center;
      }
      .fa-graduation-cap {
      font-size: 72px;
      }
      form {
      background: rgba(0, 0, 0, 0.7); 
      }
      .title {
      display: flex;
      align-items: center;
      margin-bottom: 20px;
      }
      .info {
      display: flex;
      flex-direction: column;
      }
      input, select {
      padding: 5px;
      margin-bottom: 30px;
      background: transparent;
      border: none;
      border-bottom: 1px solid #eee;
      }
      input::placeholder {
      color: #eee;
      }
      option:focus {
      border: none;
      }
      option {
      background: black; 
      border: none;
      }
      .checkbox input {
      margin: 0 10px 0 0;
      vertical-align: middle;
      }
      .checkbox a {
      color: #26a9e0;
      }
      .checkbox a:hover {
      color: #85d6de;
      }
      .btn-item, button {
      padding: 10px 5px;
      margin-top: 20px;
      border-radius: 5px; 
      border: none;
      background: #26a9e0; 
      text-decoration: none;
      font-size: 15px;
      font-weight: 400;
      color: #fff;
      }
      .btn-item {
      display: inline-block;
      margin: 20px 5px 0;
      }
      button {
      width: 100%;
      }
      button:hover, .btn-item:hover {
      background: #85d6de;
      }
      @media (min-width: 568px) {
      html, body {
      height: 100%;
      }
      .main-block {
      flex-direction: row;
      height: calc(100% - 50px);
      }
      .left-part, form {
      flex: 1;
      height: auto;
      }
      }
    </style>
<body style="background:orange;">
<div class="main-block">
      <div class="left-part">
        <i class="fas fa-graduation-cap"></i>
        <h1>ÇANAKKALE ONSEKİZ MART ÜNVİVERSİTESİ DEVLET YURDU</h1>
        <p style="font-size:24px;  font-family: sans-serif;">Ödeme Ekranı</p>
        <div class="btn-group">
          <a class="btn-item " href="index.php">PANELE DÖN</a><br><br>

                      <table style="width: 100%;" id="datatable-responsive" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0" >
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
                        <tr style="background:white; color:black;">
                          <td style="font-size:26px; font-family: monospace; text-align: center;" class="ortalama"> <?php echo"",$row['ogr_kalanBorc'] 


                        ?> </td>            
                        </tr>
                       <?php 
                        }
                        ?>
                      
                      </tbody>
                    </table>
                    <br><br>  
            <table style="width:100%;" id="datatable-responsive" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0" >
                <thead >
                  <tr>
                    <th>KALAN TAKSİT</th>
                  </tr>
                </thead>

                <tbody>
           <?php 
             $sorgu = "SELECT * FROM tbl_taksit where  veli_id=$id order by id desc ";
            $stmt = sqlsrv_query( $conn, $sorgu);   
            if($stmt === false) 
            {
                die( print_r( sqlsrv_errors(), true) );
            }
            $row = sqlsrv_fetch_array($stmt, SQLSRV_FETCH_ASSOC)  
              ?>
          <tr style="background:white; color:black;">
            <td style="font-size:26px; font-family: monospace; text-align: center;" class="ortalama"><?php echo"",$row['kalanTaksit']; ?></td>
          </tr>
         <?php 
          ?>
                      
           </tbody>
          </table>
        </div>
      </div>
      <form method="POST">
        <div class="title">
          <i class="fas fa-pencil-alt"></i> 
          <h2>ÖDEME EKRANI</h2>
        </div>
        <div class="info">
          <input type="hidden" id="veli_id" name="veli_id" value="<?php echo $kullanicicek['id'];?>" >
          <input class="fname" type="text" name="ogr_ad" id="ogr_ad" placeholder="Adınız">
          <input type="text" name="ogr_soyad" id="ogr_soyad" placeholder="Soyadınız">
          <input style="background:white; color:black;" type="date" id ="taksitZamani" name="taksitZamani" placeholder="taksit Zamanı">
          <input type="text" id="odenenMiktar"name="odenenMiktar" placeholder="Ödenecek Miktar">      
        <input type="hidden" id="kalanTaksit" name="kalanTaksit" value="<?php echo "$kalanTaksit" ?>">
          <label for=""> ÖDEME TÜRÜ</label>
        <select>
            <option value="course-type" selected>Havale</option>
            <option value="short-courses">EFT</option>
            <option value="short-courses">SWIFT</option>
            <option value="short-courses">Nakit</option>
        </select>

        </div>
        <div class="checkbox">
          <input type="checkbox" name="checkbox"><span>Okudum Onaylıyorum <a href="https://www.w3docs.com/privacy-policy"></a></span>
        </div>
          <button type="submit" name="odemeyap" class="btn btn-success" style="margin-left:1px; ">ÖDEME YAP</button>
      </form>

         
  </body> 
</html>