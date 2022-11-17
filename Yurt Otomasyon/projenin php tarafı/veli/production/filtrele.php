<table style=" margin-right: 62em; width:95%; background:rgb(62, 68, 82); color:white;" id="datatable-responsive" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0" >
                      <thead >
                        <tr>
                          <th>ad</th>
                          <th>soyad</th>
                          <th>oda no</th>
                          <th>yatak no</th>
                          <th>gi̇di̇ş sebep</th>
                          <th>gi̇di̇ş tari̇hi̇</th>
                          <th>dönüş tari̇hi̇</th>
                        </tr>
                      </thead>

                      <tbody>
                        <?php 
                        $sorgu = "select * from tbl_izinler where veli_id=$id";
            $stmt = sqlsrv_query( $conn, $sorgu);   
            if($stmt === false) 
            {
                die( print_r( sqlsrv_errors(), true) );
            }
            while( $row = sqlsrv_fetch_array($stmt, sqlsrv_fetch_assoc) )
            { 
              ?>
                        <tr style="background:orange; color:white;">
                          <td class="ortalama"> <?php echo"",$row['ogr_ad'] ?> </td>
                          <td class="ortalama"><?php echo"",$row['ogr_soyad']; ?></td>
                          <td class="ortalama"><?php echo"",$row['ogr_odano']; ?></td>
                          <td class="ortalama"><?php echo"",$row['ogr_yatakno']; ?></td>
                          <td class="ortalama"><?php echo"",$row['gidissebep']; ?></td>
                          <td class="ortalama"><?php echo"",date_format($row['gidistarih'], 'd/m/y'); ?></td>
                          <td class="ortalama"><?php echo"",date_format($row['donustarih'], 'd/m/y'); ?></td>                  
                        </tr>
                       <?php 
                        }
                        ?>
                      
                      </tbody>
                    </table>
                    <h3> <?php echo $ad , " ",  $soyad," adlı öğrencinin yoklama bilgileri"; ?> </h3>
                             <table style=" margin-right: 62em; width:95%; background:rgb(62, 68, 82); color:white;" id="datatable-responsive" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0" >
                      <thead >
                        <tr>
                          <th>ad</th>
                          <th>soyad</th>
                          <th>oda no</th>
                          <th>yatak no</th>
                          <th>tari̇h</th>
                          <th>var - yok</th>
                        </tr>
                      </thead>

                      <tbody>


                        <?php 
                        $sorgu = "select * from tbl_yoklama where veli_id=$id";
            $stmt = sqlsrv_query( $conn, $sorgu);   
            if($stmt === false) 
            {
                die( print_r( sqlsrv_errors(), true) );
            }
            while( $row = sqlsrv_fetch_array($stmt, sqlsrv_fetch_assoc) )
            { 
              ?>
                        <tr style="background:orange; color:white;">
                          <td class="ortalama"> <?php echo"",$row['ad'] ?> </td>
                          <td class="ortalama"><?php echo"",$row['soyad']; ?></td>
                          <td class="ortalama"><?php echo"",$row['odano']; ?></td>
                          <td class="ortalama"><?php echo"",$row['yatakno']; ?></td>
                          <td class="ortalama"><?php echo"",date_format($row['tarih'], 'd/m/y'); ?></td>
                          <td class="ortalama"><?php if ($row['yoklamadurum']==true)
                           {
                            echo "var";
                          }
                          else
                          {
                            echo "yok";
                          }
                        ?></td>                
                        </tr>

                       <?php 
                        }
                        ?>
                      
                      </tbody>
                    </table>
