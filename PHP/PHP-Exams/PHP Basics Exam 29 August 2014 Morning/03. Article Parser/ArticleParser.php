<?php
date_default_timezone_set('Europe/Sofia');
$input = $_GET['text'];
$pattern = "/^([\w\s\-]+?)\%([\w\s\.\-]+?);(\d{2}-\d{2}-\d{4})-\s*(.{0,100})\s*/m";
preg_match_all($pattern, $input,$matches);
for($i = 0; $i < count($matches[0]); $i++){
    $articleName = trim($matches[1][$i]);
    $author = trim($matches[2][$i]);
    $seconds = strtotime($matches[3][$i]);
    $month = date('F', $seconds);
    $articleSummary = trim($matches[4][$i]) . "...";
    echo "<div>\n";
    echo "<b>Topic:</b> <span>".htmlspecialchars($articleName)."</span>\n";
    echo "<b>Author:</b> <span>".htmlspecialchars($author)."</span>\n";
    echo "<b>When:</b> <span>$month</span>\n";
    echo "<b>Summary:</b> <span>".htmlspecialchars($articleSummary)."</span>\n";
    echo "</div>\n";
}