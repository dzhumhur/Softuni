<?php
date_default_timezone_set('Europe/Sofia');
$currentDate = strtotime($_GET['currentDate']);;
$messages = explode("\r\n", $_GET['messages']);
$allMessages = array();
$latestTime = 0;
foreach ($messages as $message) {
    $currMessage = explode(" / ", $message);
    $messageText = $currMessage[0];
    $messageTime = strtotime($currMessage[1]);
    $allMessages[$messageText] = $messageTime;
    if($messageTime > $latestTime){
        $latestTime = $messageTime;
    }
}
uasort($allMessages, function($a, $b) {
    if ($a == $b) {
        return 0;
    }
    return ($a < $b) ? -1 : 1;
});
foreach ($allMessages as $key => $value) {
    echo "<div>".htmlspecialchars($key)."</div>"."\n";
}
$timestamp = getTimeMark($latestTime, $currentDate);
echo "<p>Last active: <time>$timestamp</time></p>";

function getTimeMark($lastTime, $currentTime) {
    $timeDiff = $currentTime - $lastTime;
    $timeStamp = '';

    $lastDay = date('z', $lastTime);
    $currentDay = date('z', $currentTime);
    if ($lastDay == $currentDay) {
        if ($timeDiff < 60) {
            $timeStamp = "a few moments ago";
        } else if ($timeDiff < 60 * 60) {
            $minutes = floor($timeDiff / 60);
            $timeStamp = "$minutes minute(s) ago";
        } else if ($timeDiff < 24 * 60 * 60) {
            $hours = floor($timeDiff / (60 * 60));
            $timeStamp = "$hours hour(s) ago";
        }
    }
    else if ($lastDay + 1 == $currentDay) {
        $timeStamp = "yesterday";
    } else {
        $timeStamp = date("d-m-Y", $lastTime);
    }
    return $timeStamp;
}
