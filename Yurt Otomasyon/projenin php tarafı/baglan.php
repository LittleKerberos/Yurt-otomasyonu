<?php 

try 
{
	$db = new PDO("mysql:host=localhost;dbname=yurt;charset=utf8",'root','12345678');
	//echo "Veritabanı Bağlantısı Başarılı";
} 
catch (Exception $e) 
{
	echo $e->getMessage();
}


 ?>