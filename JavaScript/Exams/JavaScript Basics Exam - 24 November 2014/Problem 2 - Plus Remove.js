function solve(args){
    var checkerMatrix = [],
        resultMatrix = [];
    args.forEach(function(row){
        checkerMatrix.push(row.toLowerCase().split(''));
        resultMatrix.push(row.split(''));
    });
    for (var row = 0; row < checkerMatrix.length - 2; row++) {
        for (var col = 1; col < checkerMatrix[row].length; col++) {
            var currentChar = checkerMatrix[row][col];
            var isPlus = checkerMatrix[row + 1][col - 1] === currentChar &&
                        checkerMatrix[row + 1][col] === currentChar &&
                        checkerMatrix[row + 1][col + 1] === currentChar &&
                        checkerMatrix[row + 2][col] === currentChar;
            var check = checkerMatrix[row + 2][col];
            if(isPlus){
                resultMatrix[row][col] = ' ';
                resultMatrix[row + 1][col - 1] = ' ';
                resultMatrix[row + 1][col] = ' ';
                resultMatrix[row + 1][col + 1] = ' ';
                resultMatrix[row + 2][col] = ' ';
            }
        }
    }
    var result = [];
    resultMatrix.forEach(function(element){
        result.push(element.join('').split(' ').join(''));
    });
    result.forEach(function(element){
        console.log(element);
    })
}

var input1 = [
    'ab**l5',
    'bBb*555',
    'absh*5',
    'ttHHH',
    'ttth'
],
 input2 = [
     '888**t*',
     '8888ttt',
     '888ttt<<',
     '*8*0t>>hi'
 ],
 input3 = [
     '@s@a@p@una',
     'p@@@@@@@@dna',
     '@6@t@*@*ego',
     'vdig*****ne6',
     'li??^*^*'
 ];
solve(input2);

