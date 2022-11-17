
<?php
$serverName = "LAPTOP-BSDGJ678"; //mssql server name buraya gelecek.
$connectionInfo = array( "Database"=>"YurtOtomasyonDatabase"); //db name buraya gelecek.
$conn = sqlsrv_connect($serverName, $connectionInfo);


if ($conn) 
{
}
else
{
 die(print_r(sqlsrv_errors(), true));
}
// loop results with `sqlsrv_fetch_array`

?>