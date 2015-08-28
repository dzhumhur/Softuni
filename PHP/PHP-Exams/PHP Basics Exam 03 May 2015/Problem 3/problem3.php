<?php
$input = $_GET['code'];
$varPattern = '/(\$[A-Za-z0-9_]+)/';
$loopsPattern = "/(for\s+.[^{]+)|(foreach\s+.[^{]+)|(while\s+.[^{]+)/";
$conditionPattern = "/(i\s*f\s*.[^{]+)|(e\s*l\s*s\s*e\s*if\s*.[^{]+)/";
preg_match_all($varPattern, $input, $unSortVars);
preg_match_all($loopsPattern, $input, $unSortLoops);
preg_match_all($conditionPattern, $input, $unSortConds);
$vars = array_count_values($unSortVars[0]);
$lastLoops = $unSortLoops[0];
$whileLoops = [];
$forLoops = [];
$foreachLoops = [];
foreach ($lastLoops as $loop) {
    $loop = trim($loop);
    $currLoop = explode(" ", $loop);
    if($currLoop[0] === 'while'){
        $whileLoops[] = $loop;
    }else if($currLoop[0] === 'for'){
        $forLoops[] = $loop;
    }else if($currLoop[0] === 'foreach'){
        $foreachLoops[] = $loop;
    }
}
$conditions = [];
if(!empty($unSortConds[0])){
    foreach ($unSortConds[0] as $cond) {
        $conditions[] = trim($cond);
    }
}
$result = array(
  'variables' => $vars,
    'loops' => array(
        'while' => $whileLoops,
        'for' => $forLoops,
        'foreach' => $foreachLoops
    ),
    'conditionals' => $conditions
);
echo (json_encode($result));