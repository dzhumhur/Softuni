function calcDelta(a,b,c){
    var root = Math.pow(b, 2) - 4 * a * c;
    var x1 = (-b - Math.sqrt(root)) / (2 * a);
    var x2 = (-b + Math.sqrt(root)) / (2 * a);
    if(root < 0){
        console.log("No real rots");
    }else{
        if(root === 0){
            console.log("X = " + x1);
        }else{
            console.log("X1 = " + x1);
            console.log("X2 = " + x2);
        }
    }
}

var firstNumber = 2;
var secondNumber = 5;
var thirdNumber = -3;
calcDelta(firstNumber, secondNumber, thirdNumber );

console.log();

firstNumber = 2;
secondNumber = -4;
thirdNumber = 2;
calcDelta(firstNumber, secondNumber, thirdNumber );

console.log();

firstNumber = 4;
secondNumber = 2;
thirdNumber = 1;
calcDelta(firstNumber, secondNumber, thirdNumber );
