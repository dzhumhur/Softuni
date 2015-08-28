<style>
    table, td{
        border: 1px solid black;
    }
</style>
<form action="" method="get">
    <label for="input">Input string:</label>
    <input type="text" name="input" id="input"/>
    <input type="submit" name="button" value="Submit"/>
</form>
<?php
$input = explode(", ", $_GET['input']);

function calcSum ($digits){
    $sum = 0;
    foreach ($digits as $digit) {
        $sum += intval($digit);
    }
    return $sum;

}
if(isset($_GET['button'])){
    echo "<table>";
    foreach ($input as $element) {
        echo "<tr>";
        if(is_numeric($element)){
            $digits = str_split($element);
            $currSum = calcSum($digits);
            echo "<td>$element</td><td>$currSum</td>";
        }else{
            echo "<td>$element</td><td>I cannot sum that</td>";
        }
        echo "</tr>";
    }
    echo "</table>";
}
