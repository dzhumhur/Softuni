function calcSupply(arr){
    var age = arr[0];
    var maxAge = arr[1];
    var food = arr[2];
    var foodPerDay = arr[3];
    var years = (maxAge - age) * 365;
    var result = years * foodPerDay;
    console.log('%dkg of %s would be enough until I am %d years old \n',result, food, maxAge);
}

var arr = [38, 118, 'chocolate', 0.5];
calcSupply(arr);

arr = [20, 87, 'fruits', 2];
calcSupply(arr);

arr = [16, 102, 'nuts', 1.1];
calcSupply(arr);