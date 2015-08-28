<?php
$text = $_GET['text'];
$minSize = $_GET['minFontSize'];
$maxSize = $_GET['maxFontSize'];
$step = intval($_GET['step']);
$isIncrementing = true;

//if(isset($_GET['submit'])){
    $currFontSize = $minSize;
    $chars = str_split($text);
    foreach ($chars as $char) {
        $currCharValue = ord($char);

        if(($currCharValue >= 65 && $currCharValue <= 90) ||
            ($currCharValue >= 97 && $currCharValue <= 122)){
            $isOdd = isOddOrEven($currCharValue);
            if($isOdd){
                $forPrint = "<span style='font-size:$currFontSize;text-decoration:line-through;'>".htmlspecialchars($char)."</span>";
                echo $forPrint;
            }else{
                $forPrint = "<span style='font-size:$currFontSize;'>".htmlspecialchars($char)."</span>";
                echo $forPrint;
            }
            if($isIncrementing){
                $currFontSize += $step;
            }else {
                $currFontSize -= $step;
            }
            if($currFontSize >= $maxSize || $currFontSize <= $minSize){
                $isIncrementing = !$isIncrementing;
            }

        }else{
            $isOdd = isOddOrEven($currCharValue);
            if($isOdd){
                $forPrint = "<span style='font-size:$currFontSize;text-decoration:line-through;'>".htmlspecialchars($char)."</span>";
                echo $forPrint;
            }else{
                $forPrint = "<span style='font-size:$currFontSize;'>".htmlspecialchars($char)."</span>";
                echo $forPrint;
            }
        }
//    }
}
function isOddOrEven($number){
    if($number % 2 == 0){
        return true;
    }else{
        return false;
    }
}