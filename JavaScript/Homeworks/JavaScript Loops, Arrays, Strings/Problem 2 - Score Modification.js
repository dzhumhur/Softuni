function solve(arr){
    var newArr = arr.filter(function(i){
        return (i>0 && i<400);
    });

    for (var element in newArr) {
        newArr[element] = newArr[element] - newArr[element]*.2;
    }

    newArr.sort(function(x,y){
        return x>y;
    });
    console.log(newArr);
}

var arr = [200, 120, 23, 67, 350, 420, 170, 212, 401, 615, -1];
solve(arr);