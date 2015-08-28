<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Document</title>
</head>
<body>

    <form method="post" action="">
        <div>
            <label for="amount-of-money">Enter Amount</label>
            <input type="text" name="amount" id="amount-of-money"/>
        </div>
        <div>
            <input type="radio" name="currency" value="USD" id="usd"/>
            <label for="usd">USD</label>
            <input type="radio" name="currency" value="EUR" id="euro"/>
            <label for="euro">EUR</label>
            <input type="radio" name="currency" value="lv" id="bgn"/>
            <label for="bgn">BGN</label>
        </div>
        <div>
            <label for="compoundy">Compound Interest Amount</label>
            <input type="text" name="compound-of-money" id="compound"/>
        </div>
        <div>
            <select name="select">
                <option value="6">6 Months</option>
                <option value="12">1 Year</option>
                <option value="24">2 Years</option>
                <option value="60">5 Years</option>
            </select>
            <input type="submit" name="submit"/>
        </div>
    </form>
<?php
$enteredAmount = (float)($_POST['amount']);
$currency = $_POST['currency'];
$compound = (float)($_POST['compound-of-money']) / 12;
$time = $_POST['select'];

if(isset($_POST['submit'])){
    $result = $enteredAmount *  pow((1 + ($compound / 100)), $time);
    if($currency == "USD"){
        echo '$ ' . round($result,2);
    }else if($currency == 'EUR'){
        echo round($result,2). '€';
    }else{
        echo round($result,2) . 'лв';
    }
}
?>

</body>
</html>







