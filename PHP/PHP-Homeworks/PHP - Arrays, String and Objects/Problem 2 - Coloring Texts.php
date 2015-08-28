<form action="" method="get">
    <textarea name="input" id="text-area" cols="40" rows="3"></textarea>
    <input type="submit" name="submit"/>
</form>
<?php
$inputAsArray = preg_split("/\\s+/", $_GET['input']);
$result = [];
foreach ($inputAsArray as $element) {
    $element = str_split($element);
    foreach ($element as $currChar) {
        $result[] = $currChar;
    }
}
foreach ($result as $char) {
    $asciiValue = ord($char);
    if($asciiValue % 2 == 0){
        echo "<span style='color: red'>$char </span>";
    }else{
        echo "<span style='color: blue'>$char </span>";
    }
}
