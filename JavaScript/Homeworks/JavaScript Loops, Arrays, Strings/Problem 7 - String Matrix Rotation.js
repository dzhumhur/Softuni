function solve(arr){
    var newArr = [];
    for (var i = 1; i < arr.length; i++) {
        newArr[i-1] = arr[i];
    }
    var comand = arr[0].match(/[\d]+/g);
    var radius = parseInt(comand[0]) % 360;
    var maxLength = 0;
    for (var obj in newArr) {
        if(newArr[obj].length > maxLength){
            maxLength = newArr[obj].length;
        }
    }
    var rotateMatrix = '';
    switch(radius){
        case 0: rotateMatrix = turn0(newArr); break;
        case 90: rotateMatrix = turn90(newArr); break;
        case 180: rotateMatrix = turn180(newArr); break;
        case 270: rotateMatrix = turn270(newArr); break;
        default: break;
    }
    function turn0(matrix){
        var result = '';
        for (var row in matrix) {
            for (var col in matrix[row]) {
                result += matrix[row][col];
            }
            result += '\n';
        }
        return result;
    }

    function turn90(matrix){
        var result = '';
        for (var row = 0; row < maxLength; row++) {
            for (var col = newArr.length - 1; col >= 0; col--) {
                if(matrix[col][row] !== undefined){
                    result += matrix[col][row];
                }
                else{
                    result += ' ';
                }
            }
            result += '\n';
        }
        return result;
    }

    function turn180(matrix){
        var result = '';
        for (var col = newArr.length - 1; col >= 0; col--){
        for (var row = maxLength - 1; row >= 0; row--) {
                if(matrix[col][row] !== undefined){
                    result += matrix[col][row];
                }
                else{
                    result += ' ';
                }
            }
            result += '\n';
        }
        return result;
    }

    function turn270(matrix){
        var result = '';
        for (var col = maxLength - 1; col >= 0; col--){
            for (var row = 0; row < newArr.length; row++) {
                if(matrix[row][col] !== undefined){
                    result += matrix[row][col];
                }
                else{
                    result += ' ';
                }
            }
            result += '\n';
        }
        return result;
    }
    //return rotateMatrix;
    console.log(rotateMatrix);
}

var arr = ['Rotate(270)',
'hello',
'softuni',
'exam'];
solve(arr);
