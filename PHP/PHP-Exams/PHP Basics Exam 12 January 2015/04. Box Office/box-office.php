<?php
$list = $_GET['list'];
$minSeats = $_GET['minSeats'];
$maxSeats = $_GET['maxSeats'];
$filter = $_GET['filter'];
$order = $_GET['order'];
$rows = explode("\r\n", $list);
$movies = array();
$pattern = "/(.*?)\((.*?)\)-\s*(.*?)\s*\/\s*(\d+)/";
foreach ($rows as $row) {
    preg_match_all($pattern, $row, $matches);
    if(empty($matches[0])){
        continue;
    }
    $stars = explode(", ", $matches[3][0]);
    $seats = intval($matches[4][0]);
    $genre = trim($matches[2][0]);
    $compare = strcmp($genre, $filter);
    if(($seats >= $minSeats && $seats <= $maxSeats) && (($compare === 0) || ($filter === "all"))){
        $movies[] = array(
            'name' => trim($matches[1][0]),
            'genre' => trim($matches[2][0]),
            'stars' => $stars,
            'seats' => intval($seats)
        );
    }
}
usort($movies, function($movie1, $movie2) use($order){
    $compareName = strcmp($movie1['name'], $movie2['name']);
    if($compareName === 0){
        return $movie1['seats'] > $movie2['seats'];
    }
    if($order === 'ascending'){
        return $movie1['name'] > $movie2['name'] ? 1 : -1;
    }else{
        return $movie1['name'] < $movie2['name'] ? 1 : -1;
    }
});
foreach ($movies as $movie) {
    echo "<div class=\"screening\">";
    echo "<h2>".htmlspecialchars($movie['name'])."</h2>";
    echo "<ul>";
    foreach ($movie['stars'] as $star) {
        echo "<li class=\"star\">" .htmlspecialchars(trim($star)). "</li>";
    }
    echo "</ul>";
    echo "<span class=\"seatsFilled\">".$movie['seats']." seats filled</span>";
    echo "</div>";
}


