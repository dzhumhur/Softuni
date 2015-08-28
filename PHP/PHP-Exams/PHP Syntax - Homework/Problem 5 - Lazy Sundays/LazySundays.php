<?php
$startDate = strtotime('1 April 2015');
$endDate = strtotime('30 April 2015');
$secondsPerDay = 86400;
$arr = [];

for($date = $startDate; $date <= $endDate; $date += $secondsPerDay){
    $dayOfWeek = date('l', $date);
    if($dayOfWeek == 'Sunday'){
        $arr[] = date('jS F o', $date);
    }
}

foreach($arr as $currentDay){
    echo $currentDay."\n";
}
?>