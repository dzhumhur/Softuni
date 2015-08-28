<?php
$input = $_GET['array'];
$inputAsArray = preg_split("/\r?\n/", $input);
$result = '';
$currArray = array();
foreach ($inputAsArray as $currLine) {
    $currSplitedLine = str_split($currLine);
    $currArray[] = $currSplitedLine;
}
$result = '';
for ($i = 0 ; $i < count($currArray); $i++) {
    $checkRow = $i;
    for ($j = 0; $j < count($currArray[$i]); $j++) {
        $checkCol = $j;
        $currChar = $currArray[$i][$j];
        switch($currChar){
            case '>':
                $checkCol++;
                $currChar = $currArray[$i][$checkCol];
                if($currChar === null){
                    continue;
                }
                while(($currChar !== '>' && $currChar !== '<' && $currChar !== '^' && $currChar !== 'v')){

                    $currArray[$i][$checkCol] = ' ';

                    $checkCol++;
                    $currChar = $currArray[$i][$checkCol];
                    if($checkCol > count($currArray[$i]) - 1){
                        break;
                    }
                };
            break;
            case '<':
                $checkCol--;
                $currChar = $currArray[$i][$checkCol];
                if($currChar === null){
                    continue;
                }
                while(($currChar !== '>' && $currChar !== '<' && $currChar !== '^' && $currChar !== 'v')){
                    $currArray[$i][$checkCol] = ' ';
                    $checkCol--;
                    $currChar = $currArray[$i][$checkCol];
                    if($checkCol < 0){
                        break;
                    }
                };
            break;
            case '^':
                $checkRow--;
                $currChar = $currArray[$checkRow][$j];
                if($currChar === null){
                    continue;
                }
                while(($currChar !== '>' && $currChar !== '<' && $currChar !== '^' && $currChar !== 'v')){

                    $currArray[$checkRow][$j] = ' ';
                    $checkRow--;
                    $currChar = $currArray[$checkRow][$j];
                    if($checkRow < 0){
                        break;
                    }
                };
            break;
            case 'v':
                $checkRow++;
                $currChar = $currArray[$checkRow][$j];
                if($currChar === null){
                    continue;
                }
                while(($currChar !== '>' && $currChar !== '<' && $currChar !== '^' && $currChar !== 'v')){

                    $currArray[$checkRow][$j] = ' ';
                    $checkRow++;
                    $currChar = $currArray[$checkRow][$j];
                    if($checkRow > count($currArray) - 1){
                        break;
                    }
                };
            break;
        }

    }

}
//var_dump(count($currArray));
for ($i = 0; $i < count($currArray); $i++) {
    echo "<p>";
    for ($j = 0; $j < count($currArray[$i]); $j++) {
        echo htmlspecialchars($currArray[$i][$j]);
    }
    echo "</p>";
    echo "\n";
}