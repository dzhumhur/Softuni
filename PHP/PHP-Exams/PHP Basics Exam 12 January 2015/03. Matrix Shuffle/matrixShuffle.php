<?php
$size = $_GET['size'];
$text = $_GET['text'];
$n = $size;
$index = 0;
$matrix = array();
$x = 0;
$y = 0;

for ($i = 0; $i < $size; $i++) {
    $matrix[] = array();
}
while ($n > 0)
{
    for ($i = $y; $i <= $y + $n - 1; $i++) // Go right.
    {
        $matrix[$x][$i] = $text[$index];
        $index++;
    }

    for ($j = $x + 1; $j <= $x + $n - 1; $j++) //Go down.
    {
        $matrix[$j][$y + $n - 1] = $text[$index];
        $index++;
    }

    for ($i = $y + $n - 2; $i >= $y; $i--) // Go left.
    {
        $matrix[$x + $n - 1][$i] = $text[$index];
        $index++;
    }

    for ($i = $x + $n - 2; $i >= $x + 1; $i--) // Go up.
    {
        $matrix[$i][$y] = $text[$index];
        $index++;
    }
    $x++;
    $y++;
    $n -= 2;
}
$firstCheck = array();
$secondCheck = array();
$result = '';
for ($row = 0; $row < count($matrix); $row++) {
    for ($col = 0; $col < count($matrix[$i]); $col++) {
        if(($row % 2 == 0 && $col % 2 == 0) || ($row % 2 !== 0 && $col % 2 !== 0)){
            $firstCheck[] = $matrix[$row][$col];
        }
    }
}
for ($row = 0; $row < count($matrix); $row++) {
    for ($col = 0; $col < count($matrix[$i]); $col++) {
        if(($row % 2 == 0 && $col % 2 !== 0) || ($row % 2 !== 0 && $col % 2 == 0)){
            $secondCheck[] = $matrix[$row][$col];
        }
    }
}
for ($i = 0; $i < count($firstCheck); $i++) {
    $result .= $firstCheck[$i];
}
for ($i = 0; $i < count($secondCheck); $i++) {
    $result .= $secondCheck[$i];
}
$trimmedResult = trim($result);
$trimmedResult = preg_replace("/[^a-zA-Z]/", "", $trimmedResult);
$isPalindrome = false;
for ($i = 0; $i < strlen($trimmedResult); $i++) {
    $first = strtolower($trimmedResult[$i]);
    $last = strtolower($trimmedResult[strlen($trimmedResult) - $i - 1]);
    if($first === $last){
        $isPalindrome = true;
    }else{
        $isPalindrome = false;
        break;
    }
}
if($isPalindrome){
    echo "<div style='background-color:#4FE000'>$result</div>";
}else{
    echo "<div style='background-color:#E0000F'>$result</div>";
}
