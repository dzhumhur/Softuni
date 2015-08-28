<?php
$input = $_GET['fruit'];
$sum = 0;
$fruit = str_split($input);
for ($char = 0; $char < count($fruit); $char++) {
    $currChar = ord($fruit[$char]);
    $sum += $currChar;
}
$firstDigit = 0;
$secondDigit = 0;
$firstDigit = substr($sum,0,1);
$secondDigit = substr($sum,strlen($sum) - 1, strlen($sum));
$firstDigit = intval($firstDigit);
$secondDigit = intval($secondDigit);
$result = '>>';
for ($i = 0; $i < $firstDigit; $i++) {
    $result .= htmlspecialchars('-');
}
$result .= htmlspecialchars('(');
$result .= htmlspecialchars($input) . htmlspecialchars(')');
for ($i = 0; $i < $secondDigit; $i++) {
    $result .= htmlspecialchars('-');
}
$result .= '>';
echo $result;
