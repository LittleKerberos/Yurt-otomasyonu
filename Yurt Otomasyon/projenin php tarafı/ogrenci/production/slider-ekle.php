<?php
 include 'header.php'; 

if ($_GET["durum"]=="no") {
  ?>
  <script type="text/javascript">
    alert("Lütfen resim yükleyiniz.");
  </script>
  <?php
}
 ?>

        <div class="right_col" role="main">
          <div class="">
            <div class="page-title">
              <div class="title_left">
                <h3>Ayarlar</h3>
              </div>

            </div>

            <div class="clearfix"></div>

            <div class="row">
              <div class="col-md-12 col-sm-12 col-xs-12">
         
            
                  <div class="x_content">
                      <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="x_panel">
                  <div class="x_title">
                    <h2>Slider Ekleme<small>
                                       
                    </small></h2>
                     
                    <div class="clearfix"></div>
                  </div>

        <div class="x_content">

        <form action="../netting/islem.php" enctype="multipart/form-data" method="POST" id="demo-form2" data-parsley-validate class="form-horizontal form-label-left">

          <div class="form-group">
                  <label class="control-label col-md-3 col-sm-3 col-xs-12" for="first-name">Resim Seç <span class="required">*</span>
                  </label>
                    <div class="col-md-6 col-sm-6 col-xs-12">
                      <input type="file" id="first-name"  name="slider_resimyol" class="form-control  col-md-7 col-xs-12">
                    </div>
               </div>

               <div class="form-group">
                  <label class="control-label col-md-3 col-sm-3 col-xs-12" for="first-name">Ad<span class="required">*</span>
                  </label>
                    <div class="col-md-6 col-sm-6 col-xs-12">
                      <input type="text" id="first-name"  name="slider_ad" placeholder="Adını Giriniz" class="form-control col-md-7 col-xs-12">
                    </div>
               </div>

               <div class="form-group">
                  <label class="control-label col-md-3 col-sm-3 col-xs-12" for="first-name">Link<span class="required">*</span>
                  </label>
                    <div class="col-md-6 col-sm-6 col-xs-12">
                      <input type="text" id="first-name"  name="slider_link" placeholder="Link Giriniz" class="form-control col-md-7 col-xs-12">
                    </div>
               </div>

               <div class="form-group">
                  <label class="control-label col-md-3 col-sm-3 col-xs-12" for="first-name">Sıra<span class="required">*</span>
                  </label>
                    <div class="col-md-6 col-sm-6 col-xs-12">
                      <input type="text" id="first-name"  name="slider_sira" placeholder="Sırasını Giriniz" class="form-control col-md-7 col-xs-12">
                    </div>
               </div>
               <div class="form-group">
                  <label class="control-label col-md-3 col-sm-3 col-xs-12" for="first-name">Yazar<span class="required">*</span>
                  </label>
                    <div class="col-md-6 col-sm-6 col-xs-12">
                      <input type="text" id="first-name"  name="slider_yazar" placeholder="Yazar giriniz" class="form-control col-md-7 col-xs-12">
                    </div>
               </div>
               <div class="form-group">
                  <label class="control-label col-md-3 col-sm-3 col-xs-12" for="first-name">Yorum<span class="required">*</span>
                  </label>
                    <div class="col-md-6 col-sm-6 col-xs-12">
                      <input type="text" id="first-name"  name="slider_yorum" placeholder="Yorum giriniz" class="form-control col-md-7 col-xs-12">
                    </div>
               </div>
               <div class="form-group">
                  <label class="control-label col-md-3 col-sm-3 col-xs-12" for="first-name">Firma Adi<span class="required">*</span>
                  </label>
                    <div class="col-md-6 col-sm-6 col-xs-12">
                      <input type="text" id="first-name"  name="slider_calistigiyer" placeholder="Firma Adi giriniz" class="form-control col-md-7 col-xs-12">
                    </div>
               </div>
              <div class="form-group">
                <label class="control-label col-md-3 col-sm-3 col-xs-12" for="first-name">Durum<span class="required">*</span>
                </label>
                <div class="col-md-6 col-sm-6 col-xs-12">
                 <select id="heard" class="form-control" name="slider_durum" required>
            <option value="1">Aktif</option>
           <option value="0" >Pasif</option>
                 </select>
               </div>
             </div>

               
             <input type="hidden" name="slider_id" value="<?php echo $slidercek['slider_id']; ?>">
               <div align="right" class="col-md-6 col-sm-6 col-xs-12 col-md-offset-3">
                    <button type="submit" name="sliderkaydet" class="btn btn-primary">Kaydet</button>
                </div>
          </form>
             
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