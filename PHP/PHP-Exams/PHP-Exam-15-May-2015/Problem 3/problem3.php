<?php
$input = json_decode($_GET['jsonTable']);
echo "<ul>";
foreach ($input as $currLine) {
    foreach ($currLine as $currStr) {
        $numbers = preg_split("/[^\d+]/", $currStr, -1,  PREG_SPLIT_NO_EMPTY);
        $digits = '';
        foreach ($numbers as $digit) {
            $digits .= $digit;
        }
        if($digits === ''){
           continue;
        }
        $number = intval($digits);
        $isFib = isFibNumber($number);
        if($isFib){
            echo "<li style=\"color: #3DD459\">$number - is a Fibonacci number</li>";
        }else{
            echo "<li style=\"color: #FF5900\">$number - is not a Fibonacci number</li>";
        }
    }

}
echo "</ul>";

function isFibNumber($number){
   $first = 0;
   $second = 1;
   $isFind = false;
    for ($j = 0; $j < 30; $j++) {
        $third = $first + $second;
        if($third == $number){
            $isFind = true;
            break;
        }else{
            $first = $second;
            $second = $third;
        }
    }
        return $isFind;
    }
