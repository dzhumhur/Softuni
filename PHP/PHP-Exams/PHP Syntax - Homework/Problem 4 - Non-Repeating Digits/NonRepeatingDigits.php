<?php
$input = 155;
$isFind = false;
if($input > 987){
    $input = 987;
}
$arr = [];
for($i = 102; $i <= $input; $i++){
    $firstDigit = (int) ($i / 100);
    $secondDigit = (int) (($i / 10) % 10);
    $thirdDigit = (int) ($i % 10);
    if(($firstDigit != ($secondDigit && $thirdDigit)) && ($secondDigit != $thirdDigit)){
        $arr[] = $i;
        $isFind = true;
    }
}

if($isFind){
    echo join(', ', $arr);
}else{
    echo 'no';
}
?>