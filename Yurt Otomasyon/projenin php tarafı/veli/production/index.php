<?php 
include 'header.php'; 
include '../netting/baglan.php';

$kullanicisor = $db->prepare("SELECT * FROM veli WHERE username=:username");
$kullanicisor->execute(array(
  'username' => $_SESSION['username']
));
$say =$kullanicisor->rowCount();
$kullanicicek = $kullanicisor->fetch(PDO::FETCH_ASSOC);

?>
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
                    <h3>Veli Paneli </h3>
                    <h2><?php echo $kullanicicek['veli_ad']; echo $kullanicicek['veli_soyad']?></h2>

                     
                    <ul class="nav navbar-right panel_toolbox">
                    </ul>
                    <div class="clearfix"></div>
                  </div>                    
<?php 
include 'footer.php'; ?>
