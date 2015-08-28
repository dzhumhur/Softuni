<?php
$data = $_GET['data'];
$goldCounter = 0;
$silverCounter = 0;
$diamondsCounter = 0;
$pattern = "/(mine) ([A-Za-z0-9]+) ([A-Za-z0-9]+) (\d+),*/";
preg_match_all($pattern, $data, $matches);
$gsd = $matches[3];
$counts = $matches[4];
foreach ($gsd as $key=>$currElement) {
    $currElement = strtolower($currElement);
    if($currElement === 'gold'){
        $goldCounter += floatval($counts[$key]);
    }
    if($currElement === 'silver'){
        $silverCounter += floatval($counts[$key]);
    }
    if($currElement === 'diamonds'){
        $diamondsCounter += floatval($counts[$key]);
    }
}
echo "<p>*Gold: $goldCounter</p>";
echo "<p>*Silver: $silverCounter</p>";
echo "<p>*Diamonds: $diamondsCounter</p>";
