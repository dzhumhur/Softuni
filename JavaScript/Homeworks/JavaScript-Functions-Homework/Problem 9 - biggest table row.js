function solve(arr){
    var currentResultAsArray = [];
    var currentResult = 0;
    var regex = /[.\-0-9]+/g;
    var result = -2147538465;
    var isFind = false;
    var resultAsString = '';
    var resultAsArray = [];
    for (var i = 2; row < arr.length - 1; row++) {
        var currElement = arr[row];
        currentResultAsArray = currElement.match(regex);
        currentResultAsArray = currentResultAsArray.filter(function(x){
            return !isNaN(x);
        });
        if(currentResultAsArray === null || currentResultAsArray.length === 0){
            isFind = false;
        }else{
            isFind = true;
            for (var obj in currentResultAsArray) {
                var checkDigit = Number(currentResultAsArray[obj]);
                currentResult += checkDigit;
            }
            if(currentResult > result){
                result = currentResult;
                resultAsArray = currentResultAsArray;
                currentResult = 0;
            }
            currentResult = 0;
        }
    }
    if(!isFind){
        resultAsString += 'no data';
    }else{
        resultAsString += result + ' ' + '=' + ' ' + resultAsArray[0];
        if(resultAsArray.length > 1){
            for (var i = 1; row < resultAsArray.length; row++) {
                resultAsString += ' + ' + resultAsArray[row];
            }
        }
    }
    console.log(resultAsString);
    //return resultAsString;
}
//var arr = ['<table>',
//'<tr><th>Town</th><th>Store1</th><th>Store2</th><th>Store3</th></tr>',
//'<tr><td>Sofia</td><td>26.2</td><td>8.20</td><td>-</td></tr>',
//'<tr><td>Varna</td><td>11.2</td><td>18.00</td><td>36.10</td></tr>',
//'<tr><td>Plovdiv</td><td>17.2</td><td>12.3</td><td>6.4</td></tr>',
//'<tr><td>Bourgas</td><td>-</td><td>24.3</td><td>-</td></tr>',
//'</table>'];
//
//var arr2 = ['<table>',
//'<tr><th>Town</th><th>Store1</th><th>Store2</th><th>Store3</th></tr>',
//'<tr><td>Sofia</td><td>-</td><td>-</td><td>-</td></tr>',
//'</table>'];
var arr3 = ['<table>',
'<tr><th>Town</th><th>Store1</th><th>Store2</th><th>Store3</th></tr>',
'<tr><td>Varna</td><td>-</td><td>18.02</td><td>36.11</td></tr>',
'<tr><td>Pleven</td><td>1</td><td>-</td><td>1</td></tr>',
'<tr><td>Vidin</td><td>12850</td><td>-560</td><td>20833</td></tr>',
'<tr><td>Rousse</td><td>-</td><td>299.999999</td><td>-</td></tr>',
'<tr><td>Bourgas</td><td>-</td><td>25000</td><td>-</td></tr>',
'<tr><td>Plovdiv</td><td>17.2</td><td>-</td><td>6.4</td></tr>',
'<tr><td>Sofia</td><td>-</td><td>1</td><td>1</td></tr>',
'</table>'];
var arr4 = ['<table>',
'<tr><th>Town</th><th>Store1</th><th>Store2</th><th>Store3</th></tr>',
'<tr><td>Pleven</td><td>-100</td><td>-200</td><td>-</td></tr>',
'<tr><td>Varna</td><td>-100</td><td>-</td><td>-300</td></tr>',
'<tr><td>Rousse</td><td>-</td><td>-200</td><td>-100</td></tr>',
'</table>'];
//var arr5 = ['<table>',
//'<tr><th>Town</th><th>Store1</th><th>Store2</th><th>Store3</th></tr>',
//'<tr><td>Sofia</td><td>0</td><td>-</td><td>0.0</td></tr>',
//'<tr><td>Yambol</td><td>-</td><td>0</td><td>-</td></tr>',
//'<tr><td>Sliven</td><td>-</td><td>0</td><td>-</td></tr>',
//'<tr><td>Kaspichan</td><td>0</td><td>-</td><td>-</td></tr>',
//'</table>'];
solve(arr4);