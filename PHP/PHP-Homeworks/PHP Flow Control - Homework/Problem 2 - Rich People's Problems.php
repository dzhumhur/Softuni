<style>
    table, thead, td{
        border: 1px solid black;
    }
    thead, #color, #cars{
        padding: 2px;
    }
    thead{
        font-weight: bold;
    }
</style>
<form action="" method="get">
    <label for="input">Enter cars</label>
    <input type="text" name="input" id="input"/>
    <input type="submit" name="button" value="Show result"/>
</form>
<?php
$colors = array('yellow', 'red', 'green', 'blue', 'black', 'white', 'brown', 'pink');
$input = explode(', ', $_GET['input']);
if(isset($_GET['button'])){
    echo "<table><thead><td>Car</td><td>Color</td><td>Count</td></thead>";
    for($i = 0; $i < count($input); $i++){
        $randomColor = rand(0, count($colors) - 1);
        $randomCount = rand(1, 5);

        echo "<tr><td id='cars'>$input[$i]</td><td id='color'>$colors[$randomColor]</td><td>$randomCount</td></tr>";
    }
    echo "</table>";
}

