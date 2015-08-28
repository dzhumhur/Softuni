<?php
date_default_timezone_set('Europe/Sofia');

$inputDate = explode("/",$_GET['today']);
$inputDate = array_reverse($inputDate);
$date = '';
foreach ($inputDate as $digit) {
    $date .= $digit . '/';
}

$date = substr($date, 0, strlen($date) - 1);
$date = date_create($date);
$registrations = preg_split("/, /",$_GET['registrations'], -1,  PREG_SPLIT_NO_EMPTY);
$data = array();
$keys = array();
/**
 * @param $checker
 * @param $dateForPrint
 * @param $regPlate
 * @param $data
 * @param $brand
 * @param $model
 * @return mixed
 */
function addReg($checker, $dateForPrint, $regPlate, $data, $brand, $model)
{
    if ($checker === '-') {
        $data[$brand][$model]['registrations'][] = array(
            'date' => $dateForPrint,
            'plate' => $regPlate
        );
        return $data;
    } else {
        $data[$brand][$model]['registrations'][] = array(
            'date' => $dateForPrint,
            'plate' => $regPlate,
            'isValid' => false
        );
        return $data;
    }
}

foreach ($registrations as $currLine) {
    $currCar = preg_split("/\|/",$currLine, -1,  PREG_SPLIT_NO_EMPTY);
    $brand = trim($currCar[0]);
    $model = trim($currCar[1]);
    $regDateAsArray = explode('/', $currCar[2]);
    $regDateAsArray = array_reverse($regDateAsArray);
    $regDate = '';

    foreach ($regDateAsArray as $digit) {
        $regDate .= $digit . '/';
    }
    $regDate = substr($regDate, 0, strlen($regDate) - 1);
    $regDate = date_create($regDate);
    $checker = $date->diff($regDate);
    $checker = $checker->format('%R%');

    $regPlate = trim($currCar[3]);
    $dateForPrint = $currCar[2];

    if(!$data[$brand]){
        $keys[] = $brand;
        $data[$brand][$model] = array(
            'registrations' => array()
        );
        $data = addReg($checker, $dateForPrint, $regPlate, $data, $brand, $model);
    }else{
        if (!$data[$brand][$model]) {
            $data[$brand][$model] = array(
                'registrations' => array()
            );
            $data = addReg($checker, $dateForPrint, $regPlate, $data, $brand, $model);
        }
        else{
            $data = addReg($checker, $dateForPrint, $regPlate, $data, $brand, $model);
        }


    }
}
$result = array();
sort($keys);
ksort($data);
$count = -1;
foreach ($data as $key) {
    $count++;
    ksort($key);
   $result[$keys[$count]] = $key;

}
echo json_encode($result);
//var_dump($data['Ford']);
