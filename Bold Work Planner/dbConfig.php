<?php

$host="kamb.dev.fast.sheridanc.on.ca"; // Host name
$db_username="kamb_ben"; // Mysql username
$db_password="webprogramming!@#$%"; // Mysql password
$db_name="kamb_webprogramming"; // Database name
$tbl_name="phonebook"; // Table name

$link = mysqli_connect($host, $db_username, $db_password, $db_name);

if($link === false){
die("ERROR: Could not connect. "
. mysqli_connect_error());
}
?>