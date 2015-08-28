<?php
$input = $_GET['conferences'];
$page = $_GET['page'];
$pageSize = $_GET['pageSize'];
$pattern = "/\[(.*?)\]/";
preg_match_all($pattern, $input, $splittedInput);
$rowPattern = "/(^\d{4,}[-|\/]\d{2,}[-|\/]\d{2,}\b), (#[A-Za-z\.-]+), '(.*?)', ([A-Za-z-,]+), (\d+), (\d+)/";
foreach ($splittedInput[1] as $currLine) {
    preg_match_all($rowPattern, $currLine, $currMatches);
    if(empty($currMatches[0])){
        continue;
    }else{
        var_dump($currMatches);
    }
}


//
//echo "<table border=\"1\" cellpadding=\"5\">";
//echo "<tr><th>Date</th><th>Event name</th><th>Event hash</th><th>Days left</th><th>Seats left</th></tr>";
//echo "<tr><td>-</td><td>-</td><td>-</td><td>-</td><td>-</td></tr>";
//echo "</table>";