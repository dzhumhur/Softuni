<?php
date_default_timezone_set('Europe/Sofia');
$listOfDates = $_GET['list'];
$currDate = new DateTime($_GET['currDate']);
$splitedDates =  preg_split("/\r?\n/", $listOfDates, -1,  PREG_SPLIT_NO_EMPTY);
$validDates = [];
foreach ($splitedDates as $date) {
    try {
        $validDates[] = new DateTime(trim($date));
    } catch (Exception $e) {
        continue;
    }
}
sort($validDates);
echo "<ul>";
foreach ($validDates as $validDate) {
    if( $validDate < $currDate){
        echo "<li><em>".$validDate->format("d/m/Y")."</em></li>";
    }else{
        echo "<li>".$validDate->format("d/m/Y")."</li>";
    }
}
echo "</ul>";
