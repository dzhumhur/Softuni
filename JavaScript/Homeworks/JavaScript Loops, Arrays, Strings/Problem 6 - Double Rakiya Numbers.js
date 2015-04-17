function solve(arr){
    var start = Number(arr[0]);
    var end = Number(arr[1]);
    var isFind = false;
    var checker = '';
    var result = '<ul>\n';
    for (var i = start; i <= end; i++) {
            var currentNumber = ""+i;
            for (var j = 0; j < currentNumber.length - 3; j++) {
                for (var k = j+2; k < currentNumber.length - 1; k++) {
                    if(currentNumber[j] === currentNumber[k] && currentNumber[j+1] === currentNumber[k+1]){
                        if(currentNumber != checker){
                            isFind = true;
                            result += '<li><span class='+'\'rakiya\''+'>'+ Number(currentNumber) +'</span>'+
                            '<a href="view.php?id='+ Number(currentNumber)+'>View</a></li>\n';
                        }
                        checker = currentNumber;
                    }
                }
            }
            if(!isFind){
                result += '<li><span class='+'\'num\''+'>'+i+'</span></li>\n';
            }
        isFind = false;

    }
    result += '</ul>';
    return result;
    //console.log(result);
}

//var arr = [55555, 55560];
//solve(arr);