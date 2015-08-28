<form action="" method="get">
    <div>
        <label for="text">Text: </label>
        <textarea name="text" id="text" cols="30" rows="4"></textarea>
    </div>
    <div>
        <label for="banlistss">Banlist: </label>
        <input type="text" name="banlist" id="banlistss"/>
    </div>
    <input type="submit" name="submit" style='margin: 3px;'/>
</form>
<?php

$text = $_GET['text'];
$banlist = explode(", ",$_GET['banlist']);
if(isset($_GET['submit'])){
    foreach ($banlist as $ban){
        $asterisks = str_repeat("*", strlen($ban));

        $text = str_replace($ban, $asterisks, $text);
    }
    echo $text;
}

