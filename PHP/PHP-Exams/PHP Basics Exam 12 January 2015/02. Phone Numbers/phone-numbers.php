<?php
$input = $_GET['numbersString'];
$pattern = "/(\b[A-Z][A-Za-z]*)[^a-zA-Z0-9\+]*?(\+?[0-9]+[0-9()\/\-\s\.]*[0-9]+)/";
preg_match_all($pattern, $input, $data);
$names = array();
$numbers = array();
var_dump($data[]);
if(empty($data[0])){
    echo "<p>No matches!</p>";
}else{

    for($i = 1; $i < count($data); $i++ ){
        for($j = 0; $j < count($data[$i]); $j++){
            if($i == 1){
                $names[] = $data[$i][$j];
            }else{
                $currNumbers = preg_replace("/[^+0-9]*/","",$data[$i][$j]);
                $numbers[] = $currNumbers;
            }
        }
    }
    echo "<ol>";
    foreach ($names as $key => $value) {
        $name = $value;
        $phoneNumber = $numbers[$key];
        echo "<li><b>$name:</b> $phoneNumber</li>";
    }
    echo "</ol>";
}