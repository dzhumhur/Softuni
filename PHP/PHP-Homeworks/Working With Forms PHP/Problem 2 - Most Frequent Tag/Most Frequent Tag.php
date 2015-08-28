<p>Enter Tags:</p>
<form method="post" action="">
    <input type="text" name="inputs"/>
    <input type="submit" name="submit" value="Submit"/>
</form>
<?php
if(isset($_POST['submit'])) {
    $input = $_POST['inputs'];
    $currResult = explode(', ', $input);
    $result = array_count_values($currResult);
    foreach ($result as $i => $currName) {
        echo $i . ' : ' . $currName . "<br/>";
    }
}