<?php
$text = $_GET['text'];
$artist = $_GET['artist'];
$property = $_GET['property'];
$order = $_GET['order'];

$songs = preg_split("/\r\n/", $text, -1,  PREG_SPLIT_NO_EMPTY);
$allData = [];
foreach ($songs as $currLine) {
    $lineAsArray = explode("|", $currLine);
    $name = trim($lineAsArray[0]);
    $genre = trim($lineAsArray[1]);
    $artists = explode(", ", trim($lineAsArray[2]));
    sort($artists);
    $downloads = trim(intval($lineAsArray[3]));
    $rating = trim(floatval($lineAsArray[4]));
    if(in_array($artist,$artists)){
        $allData[]= array
        (
            'name' => $name,
            'genre' => $genre,
            'artists' => $artists,
            'downloads' => $downloads,
            'rating' => $rating
        );
    }
}
usort($allData, function($el1, $el2) use($order, $property){
   if($el1[$property] == $el2[$property]){
       return strcmp($el1['name'], $el2['name']);
   } 
   if($order == "ascending"){
       return $el1[$property] > $el2[$property] ? 1 : -1;
   }else{
       return $el1[$property] < $el2[$property] ? 1 : -1;
   }
});

echo "<table>\n";
echo "<tr><th>Name</th><th>Genre</th><th>Artists</th><th>Downloads</th><th>Rating</th></tr>\n";
foreach ($allData as $line) {
    $resultName = $line['name'];
    $resultGenre = $line['genre'];
    $resultArtist = implode(", ", $line['artists']);
    $resultDownloads = $line['downloads'];
    $resultRating = $line['rating'];
    echo "<tr>";
    echo "<td>".htmlspecialChars($resultName).
        "</td><td>".htmlspecialchars($resultGenre).
        "</td><td>".htmlspecialchars($resultArtist).
        "</td><td>".htmlspecialchars($resultDownloads).
        "</td><td>".htmlspecialchars($resultRating).
        "</td>";
    echo "</tr>\n";
}
echo "</table>";

