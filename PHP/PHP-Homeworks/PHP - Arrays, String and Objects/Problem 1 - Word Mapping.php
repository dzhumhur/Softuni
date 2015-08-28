<style>
    textarea{
        display: block;
    }
    table, td{
        border: 2px solid gray;
        background-color: darkgray;
    }
</style>
<form action="" method="get">
    <textarea name="input" id="text-area" cols="40" rows="3"></textarea>
    <input type="submit" name="submit"/>
</form>
<?php
    $normalInput = trim($_GET['input']);
    $input = preg_split("/[\\W\\s]+/", $normalInput);
    $result = [];
    if(isset($_GET['submit'])) {
        foreach ($input as $element) {
            if ($element !== '') {
                $element = strtolower($element);
                $result[] = $element;
            }
        }
        $result = array_count_values($result);
        echo "<table>";
        foreach ($result as $key => $currWord) {
            echo "<tr><td>$key</td><td>$currWord</td></tr>";
        }
        echo "</table>";
    }