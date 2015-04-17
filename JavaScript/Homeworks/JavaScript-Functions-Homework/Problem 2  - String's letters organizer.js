function solve(someString, isTrue){
    var result = [];
    var string = '';
    if(isTrue){
        for (var element in someString) {
            result.push(someString[element]);
        }
        result = result.sort(function(x,y){
            return x.toLowerCase() > y.toLowerCase();
        });
        for (var obj in result) {
            string += result[obj];
        }
    }
    else{
        for (var element in someString) {
            result.push(someString[element]);
        }
        result = result.sort(function(x,y){
            return x.toLowerCase() < y.toLowerCase();
        });
        for (var obj in result) {
            string += result[obj];
        }
    }
    console.log(string);
}
solve('HelloWorld', true);