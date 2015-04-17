function solve(arr){
    var newArr = arr.filter(isNumber);

    function isNumber(a){
        return !isNaN(a);
    }

    newArr.sort(function(x,y){
        return x>y;
    })

    var minValue = newArr[0];
    var maxValue = newArr[newArr.length - 1];

    Array.prototype.occurs = function(arg) {
        var counter = 0;

        for (var i = 0; i < this.length; i++) {
            if (this[i] === arg)
                counter++;
        }
        return counter;
    };
    var maxOccur = 0;
    var occursestNum = 0;
    for (var element in newArr) {
        var currentOccurs = newArr.occurs(newArr[element]);
        if(currentOccurs >= maxOccur){
            maxOccur = currentOccurs;
            occursestNum = newArr[element];
        }
    }
    console.log('Min number: %d', minValue);
    console.log('Max number: %d', maxValue);
    console.log('Most frequent number: %d', occursestNum);
    console.log(newArr.reverse());
}
var arr = ["Pesho", 2, "Gosho", 12, 2, "true", 9, undefined, 0, "Penka", { bunniesCount : 10}, [10, 20, 30, 40]];
solve(arr);
