<?php 
include 'header.php'; 
include '../netting/baglan.php';
$haksor = $db->prepare("SELECT * FROM hakkimizda");
$haksor->execute();
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
                    <ul class="nav navbar-right panel_toolbox">
                    </ul>
                    <div class="clearfix"></div>
                  </div>

                  

        <div class="x_content">

          <!-- Div İçerik Başlangıç-->

           <table id="datatable-responsive" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0" width="100%">
                      <thead>
                        <tr>
                          <th>S.No</th>
                          <th>Hakkımızda İcerik</th>
                          <th>Hakkımızda Sıra</th>
                          <th></th>
                          <th></th>
                        </tr>
                      </thead>

                      <tbody>

                        <?php 
                        $say=0;

                          while($menucek = $menusor->fetch(PDO::FETCH_ASSOC)) { $say++?>

                        <tr>
                          <td><?php echo $say ?></td>
                          <td><?php echo $menucek['menu_ad']; ?></td>
                          <td><?php echo $menucek['menu_url']; ?></td>
                          <td><?php echo $menucek['menu_sira']; ?></td>
                          <form action="../netting/islem.php" enctype="multipart/form-data" method="POST" id="demo-form3" data-parsley-validate class="form-horizontal form-label-left">
                          <td><center><?php
                             
                            if ($menucek['menu_durum']==1) {?>
                              <button type="submit" name="maktif" class="btn btn-success btn-xs">aktif</button>
                              <input type="hidden" name="id" value="aktif">
                              <input type="hidden" name="menu_id" value="<?php echo $menucek['menu_id']; ?>">
                            <?php } else {?>
                              <input type="hidden" name="id" value="pasif">
                              <input type="hidden" name="menu_id" value="<?php echo $menucek['menu_id']; ?>">
                              <button type="submit" method="POST" name="mpasif"
                               class="btn btn-mutet btn-xs">pasif</button>
                              <?php } ?>
                          </td>
                        </center>
                          </form>


                         <td><center><a href="menu-duzenle.php?menu_id=<?php echo $menucek['menu_id']; ?>&eski_sira=<?php echo $menucek['menu_sira']?>"><button class="btn btn-primary btn-xs">Düzenle</button></a></center></td> 
                          <td><center><a href="../netting/islem.php?menu_id=<?php echo $menucek['menu_id']; ?>&menusil=ok"><button class="btn btn-danger btn-xs">Sil</button></a></center></td>
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