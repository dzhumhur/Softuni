<style>
    table,td{
        border: 1px solid black;
    }
    span{
        font-weight: bold;
    }
</style>
<?php
$sum = 0;
echo "<table><thead><td>Number</td><td>Square</td></thead>";
for($i = 0; $i <= 100; $i+=2) {
    $squareRootOfNumber = round(sqrt($i), 2);
    $sum += $squareRootOfNumber;
    echo "<tr><td>$i</td><td>$squareRootOfNumber</td></tr>";
}
echo "<tr><td><span>Total:</span></td><td>$sum</td></tr>";
echo "</table>";