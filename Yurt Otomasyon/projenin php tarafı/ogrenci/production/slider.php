<?php 
include 'header.php'; 
include '../netting/baglan.php';

$slidersor = $db->prepare("SELECT * FROM slider");
$slidersor->execute();

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
                    <h3>slider Listeleme</h3>
                    <ul class="nav navbar-right panel_toolbox">

                      <div align="right"><a href="slider-ekle.php"><button class="btn btn-success btn-xs">Yeni Ekle</button></a></div>
                    </ul>
                    <div class="clearfix"></div>
                  </div>

                  

        <div class="x_content">

          <!-- Div İçerik Başlangıç-->

           <table id="datatable-responsive" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0" width="100%">
                      <thead>
                        <tr>
                          <th>S.No</th>
                          <th>Resim</th>
                          <th>Yorum</th>
                          <th>Yazar</th>
                          <th>Firma</th>
                          <th>Sıra</th>
                          <th>Durum</th>
                          <th>yeni ekle</th>

                         
                          <th></th>
                          <th></th>
                        </tr>
                      </thead>

                      <tbody>

                        <?php 
                        $say=0;

                          while($slidercek = $slidersor->fetch(PDO::FETCH_ASSOC)) { $say++?>

                            <tr>
                          <td><?php echo $say ?></td>
                        <td><img width="100" height="100" src="../../<?php echo $slidercek['slider_resimyol']; ?>"></td>
                          <td><?php echo $slidercek['slider_yorum']; ?></td>
                          <td><?php echo $slidercek['slider_yazar']; ?></td>
                          <td><?php echo $slidercek['slider_calistigiyer']; ?></td>
                          <td><?php echo $slidercek['slider_sira']; ?></td>

                          <form action="../netting/islem.php" enctype="multipart/form-data" method="POST" id="demo-form3" data-parsley-validate class="form-horizontal form-label-left">
                          <td><center><?php
                             
                            if ($slidercek['slider_durum']==1) {?>
                              <button type="submit" name="saktif" class="btn btn-success btn-xs">aktif</button>
                              <input type="hidden" name="id" value="aktif">
                              <input type="hidden" name="slider_id" value="<?php echo $slidercek['slider_id']; ?>">
                              
                            <?php } else {?>
                              <input type="hidden" name="id" value="pasif">
                              <input type="hidden" name="slider_id" value="<?php echo $slidercek['slider_id']; ?>">
                              <button type="submit" method="POST" name="spasif"
                               class="btn btn-mutet btn-xs">pasif</button>
                              <?php } ?>
                          </td></center>
                          </form>
                          <td><center><a href="slider-duzenle.php?slider_id=<?php echo $slidercek['slider_id']; ?>"><button class="btn btn-primary btn-xs">Düzenle</button></a></center></td>
                         
                          <td><center><a href="../netting/islem.php?slider_id=<?php echo $slidercek['slider_id']; ?>&slidersil=ok"><button class="btn btn-danger btn-xs">Sil</button></a></center></td>
                           <td><<div align="right"><a href="slider-ekle.php"><button class="btn btn-success btn-xs">Yeni Ekle</button></a></div></td>


                        </tr>

                         <?php }
                         ?>
                       
                      
                      </tbody>
                    </table>

       
             
                  </div>
                </div>
              </div>
              </div>


              </div>
            </div>
          </div>
        </div>
        <!-- /page content -->
<?php include 'footer.php'; ?>