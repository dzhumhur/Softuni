<form action="" method="get">
    <label for="start-num">Starting Index:</label>
    <input type="number" name="start-num" id="start-num"/>
    <label for="end-num">End:</label>
    <input type="number" name="end-num" id="end-num" />
    <input type="submit" name="button" value="Submit"/>
</form>
<?php
$startNum = $_GET['start-num'];
$endNum = $_GET['end-num'];

/**
 * @param $startNum
 * @param $endNum
 */
function primesChecker($startNum, $endNum)
{
    for ($i = $startNum; $i <= $endNum; $i++) {
        $divider = 2;
        $maxDivider = intval(sqrt($i));
        $isPrime = true;
        while ($divider <= $maxDivider) {
            if ($i % $divider == 0) {
                $isPrime = false;
                break;
            }
            $divider++;
        }
        if ($i == $endNum) {
            if ($isPrime) {
                echo "<span style='font-weight: bold; color: red'>$i</span>";
            } else {
                echo "<span>$i</span>";
            }
        } else {
            if ($isPrime) {
                echo "<span style='font-weight: bold;color: red'>$i, </span>";
            } else {
                echo "<span>$i, </span>";
            }
        }
    }
}

if(isset($_GET['button'])) {
    primesChecker($startNum, $endNum);
}
