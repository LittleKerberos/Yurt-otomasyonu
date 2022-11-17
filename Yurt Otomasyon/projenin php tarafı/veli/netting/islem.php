<?php 
ob_start();
session_start();

include 'baglan.php';


if (isset($_POST['veligiris'])) 
{
$username = $_POST['username'];
$password = sha1($_POST['password']);
$kullanicisor = $db->prepare("SELECT * FROM veli WHERE username=:username and password=:password");
$kullanicisor->execute(array(
	'username' => $username,
	'password' => $password	
	));
	echo $say = $kullanicisor->rowCount();	
	if ($say==1) 
	{
		$_SESSION['username']=$username;
		header("location: ../production/index.php");
		exit;
	}
	else
	{
		header("location: ../production/login.php?durum=no");
		exit;
	}	
}

if (isset($_POST['odemeyap'])) 
{
$kullanicisor = $db->prepare("SELECT * FROM kullanici WHERE kullanici_mail=:mail and kullanici_password=:password and kullanici_yetki=:yetki");
$kullanicisor->execute(array(
	'mail' => $kullanici_mail,
	'password' => $kullanici_password,
	'yetki' => 5
	
	));
	echo $say = $kullanicisor->rowCount();	
	if ($say==1) 
	{
		$_SESSION['kullanici_mail']=$kullanici_mail;
		header("location: ../production/index.php");
		exit;
	}
	else
	{
		header("location: ../production/login.php?durum=no");
		exit;
	}
}
?>
