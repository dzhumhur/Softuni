<?php
$input = $_GET['code'];
$varPattern = '/(\$[^\s|=|\-|\;\+\[\]\"()]+)/';
$loopsPattern = '/(for \(.*?\))|(while \(.*?\))|(foreach \(.*?\))/';
$conditionPattern = '/(if \(.*?\))|(else if \(.*?\))/';
preg_match_all($varPattern, $input, $unSortVars);
preg_match_all($loopsPattern, $input, $unSortLoops);
preg_match_all($conditionPattern, $input, $unSortConds);
$vars = array_count_values($unSortVars[0]);
$lastLoops = $unSortLoops[0];
var_dump($lastLoops);
$conditions = $unSortConds[0];
$result = array(
    'variables' => $vars,
    'loops' => array(
        'while' => '',
        'for' => '',
        'foreach' => ''
    ),
    'conditionals' => $conditions
);
echo (json_encode($result));