function solve(arr){
    var myArray = arr.slice();
    for (var row = 0; row < myArray.length - 1; row++) {
        for (var col = 1; col < myArray[row].length; col++) {
            if(arr[row][col] === arr[row+1][col-1] &&
                arr[row][col] === arr[row+1][col] &&
                arr[row][col] === arr[row+1][col+1]) {
                myArray[row] = setAsterisks(myArray[row], col);
                myArray[row + 1] = setAsterisks(myArray[row+1], col-1);
                myArray[row + 1] = setAsterisks(myArray[row+1], col+1);
                myArray[row + 1] = setAsterisks(myArray[row+1],col);
            }
        }
    }
    var result = '';
    for (var row = 0; row < myArray.length; row++) {
        result += myArray[row] + '\n';
    }
    function setAsterisks(str, pos){
        var newStr = str.substr(0, pos) + '*' + str.substr(pos+1);
        return newStr;
    }
    //return result;
    console.log(result);
}
var arr = ['abcdexgh', 'bbbdxxxh', 'abcxxxxx'];
solve(arr);

