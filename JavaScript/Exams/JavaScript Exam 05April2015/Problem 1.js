function solve(args){
    var sum = 0;
    for (var element in args) {
        var currLine = args[element].split(' ');
        var checkCoin = currLine[0].toLowerCase();
        var coin;
        var isCoin = false;
        var isNumber = false;

        if((checkCoin == 'coin') || (checkCoin == 'coins')){
            coin = checkCoin;
            isCoin = true;

        }
        var number = currLine[1];
        var value = 0;
        if(!isNaN(number) && (number % 1 === 0) && (number > 0)){
            value = number;
            isNumber = true;
        }

        if(isCoin && isNumber){
            sum += Number(value);
        }


        //console.log(coin);
        //console.log(number);
        //console.log();
    }

    sum = parseInt(sum);
    var string = '' + sum;
    var lastDigit = string[string.length - 1];
    var predPosleden = string[string.length - 2];
    lastDigit = Number(lastDigit);
    predPosleden = Number(predPosleden);

    var golds = parseInt(sum / 100);
    var silvers = 0;
    var bronze = 0;
    if(sum < 10){
        bronze = sum;
    }
    else if(sum < 100){
        bronze = sum % 10;
        sum /= 10;
        sum = parseInt(sum);
        silvers =  sum % 10;

    }else{
        bronze = parseInt(sum % 10);
        golds = parseInt(sum / 100);
        silvers = parseInt(sum / 10) % 10;

    }
    console.log('gold : ' + golds);
    console.log('silver : ' + silvers);
    console.log('bronze : ' + bronze);
}

var input = [
    'COin 0',
    'coin 0',
    'coin 0',
    'coin 0',
    'coin 1',
    'coin 50',
    'coin 100',
    'coin 200',
    'coin -500',
    'cigars 1'
];

var input2 = [
    'coin 1',
    'coin two',
    'coin 5',
    'coin 10.50',
    'coin 20',
    'coin 50',
    'coin hundred',
    'cigars 1'
];


solve(input);