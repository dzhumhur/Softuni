function solve(arr){
    var counterI = 0,
        counterL = 0,
        counterJ = 0,
        counterO = 0,
        counterZ = 0,
        counterS = 0,
        counterT = 0;

    var newArr = arr.slice();
    var objResult = {
        'I': findI(newArr),
        'L': findL(newArr),
        'J': findJ(newArr),
        'O': findO(newArr),
        'Z': findZ(newArr),
        'S': findS(newArr),
        'T': findT(newArr)
    };

    function findI(arr){
            if(arr.length >= 4){
                for (var row = 0; row < newArr.length - 3; row++) {
                    for (var col = 0; col < newArr[row].length; col++) {
                        if((arr[row][col] === 'o') &&
                            (arr[row+1][col] === 'o' &&
                            arr[row+2][col] === 'o' &&
                            arr[row+3][col] === 'o')){
                            counterI++;
                        }
                    }
                }
            }
            return counterI;
    }
    function findL(arr){
            if(arr.length >= 3){
                for (row = 0; row < newArr.length - 2; row++) {
                    for (col = 0; col < newArr[row].length - 1; col++) {
                        if((arr[row][col] === 'o') &&
                            (arr[row+1][col] === 'o' &&
                             arr[row + 2][col] === 'o' &&
                            arr[row+2][col+1] === 'o')){
                            counterL++;
                        }
                    }
                }
            }
            return counterL;
    }
    function findJ(arr){
        if(arr.length >= 3){
            for (row = 0; row < newArr.length - 2; row++) {
                for (col = 1; col < newArr[row].length; col++) {
                    if((arr[row][col] === 'o') &&
                        (arr[row+1][col] === 'o' &&
                        arr[row + 2][col] === 'o' &&
                        arr[row+2][col - 1] === 'o')){
                        counterJ++;
                    }
                }
            }
        }
        return counterJ;
    }
    function findO(arr){
        if(arr.length >= 2){
            for (row = 0; row < newArr.length - 1; row++) {
                for (col = 0; col < newArr[row].length; col++) {
                    if((arr[row][col] === 'o') &&
                        (arr[row+1][col] === 'o' &&
                        arr[row + 1][col+1] === 'o' &&
                        arr[row][col + 1] === 'o')){
                        counterO++;
                    }
                }
            }
        }
        return counterO;
    }
    function findZ(arr){
        if(arr.length >= 2){
            for (row = 0; row < newArr.length - 1; row++) {
                for (col = 0; col < newArr[row].length - 2; col++) {
                    if((arr[row][col] === 'o') &&
                        (arr[row][col+1] === 'o' &&
                        arr[row + 1][col+1] === 'o' &&
                        arr[row+1][col + 2] === 'o')){
                        counterZ++;
                    }
                }
            }
        }
        return counterZ;
    }
    function findS(arr){
        if(arr.length >= 2){
            for (row = 0; row < newArr.length - 1; row++) {
                for (col = newArr[row].length - 1; col >= 2; col--) {
                    if((arr[row][col] === 'o') &&
                        (arr[row][col-1] === 'o' &&
                        arr[row + 1][col-1] === 'o' &&
                        arr[row+1][col - 2] === 'o')){
                        counterS++;
                    }
                }
            }
        }
        return counterS;
    }
    function findT(arr){
        if(arr.length >= 2){
            for (row = 0; row < newArr.length - 1; row++) {
                for (col = 0; col < newArr[row].length - 1 ; col++) {
                    if((arr[row][col] === 'o') &&
                        (arr[row][col+1] === 'o' &&
                        arr[row][col+2] === 'o' &&
                        arr[row+1][col+1] === 'o')){
                        counterT++;
                    }
                }
            }
        }
        return counterT;
    }

    return JSON.stringify(objResult);
}
