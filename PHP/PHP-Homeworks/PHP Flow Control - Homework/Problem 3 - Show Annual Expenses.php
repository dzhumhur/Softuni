<style>
    table, thead, td{
        border: 1px solid black;
    }
    thead{
        font-weight: bold;
    }
</style>
<form action="" method="get">
    <label for="input">Enter number of years</label>
    <input type="text" name="input" id="input"/>
    <input type="submit" name="button" value="Show costs"/>
</form>
<?php
$years = intval($_GET['input']);
$yearsAgo = 2014 - $years;
if(isset($_GET['button'])){
    echo "<table><thead><td>Year</td><td>January</td><td>February</td><td>March</td><td>April</td><td>May</td><td>June</td>
            <td>July</td><td>August</td><td>September</td><td>October</td><td>November</td><td>December</td><td>Total:</td></thead>";
    for($i = 2014; $i > $yearsAgo; $i--){
        $sum = 0;
        echo "<tr><td>$i</td>";

        for($j = 0; $j < 12; $j++){
            $randomCount = rand(0, 999);
            $sum += $randomCount;
            echo "<td>$randomCount</td>";
        }
        echo "<td>$sum</td>";
        echo "</tr>";
    }
}

