<?php

$arrows = $_GET['arrows'];
$arrow1 = $_GET['arrows1'];
$arrow2 = $_GET['arrows2'];
$arrow3 = $_GET['arrows3'];
$pattern = "/(>>>----->>)|(>>----->)|(>----->)/";
preg_match_all($pattern, $arrows, $matches1);
preg_match_all($pattern, $arrow1, $matches2);
preg_match_all($pattern, $arrow2, $matches3);
preg_match_all($pattern, $arrow3, $matches4);
$big = 0;
$medium = 0;
$small = 0;
foreach ($matches1[0] as $mat1) {

        if($mat1 === '>>>----->>'){
            $big++;
        }else if($mat1 === '>>----->'){
            $medium++;
        }else if($mat1 === '>----->'){
            $small++;
        }

}
foreach ($matches2[0] as $mat2) {
        if($mat2 === '>>>----->>'){
            $big++;
        }else if($mat2 === '>>----->'){
            $medium++;
        }else if($mat2 === '>----->'){
            $small++;
        }

}
foreach ($matches3[0] as $mat3) {
        if($mat3 === '>>>----->>'){
            $big++;
        }else if($mat3 === '>>----->'){
            $medium++;
        }else if($mat3 === '>----->'){
            $small++;
        }

}
foreach ($matches4[0] as $mat4) {
        if($mat4 === '>>>----->>'){
            $big++;
        }else if($mat4 === '>>----->'){
            $medium++;
        }else if($mat4 === '>----->'){
            $small++;
        }

}
$result = $small.$medium.$big;
$result = intval($result);
$resultToBin = decbin($result);
$convertedBin = strrev($resultToBin);
$lastResultAsBin = $resultToBin.$convertedBin;
$lastResultAsDec = bindec($lastResultAsBin);
echo $lastResultAsDec;



