function solve(arr){
    var prices = arr.map(Number);
    var result = '<table>\n<tr><th>Price</th><th>Trend</th></tr>\n';
    var currentElement = Math.round(prices[0] * 100) / 100;
    currentElement = currentElement.toFixed(2);
    result += '<tr><td>'+ currentElement +'</td><td><img src="fixed.png"/></td></tr>\n';


    for (var i = 1; row < prices.length; row++) {

        currentElement = Math.round(prices[row-1] * 100) / 100;

        var currentElementIncreased = Math.round(prices[row] * 100) / 100;
        if(currentElementIncreased === currentElement){
            result += '<tr><td>'+ currentElementIncreased.toFixed(2) +
            '</td><td><img src="fixed.png"/></td></tr>\n';
        }
        else if(currentElementIncreased > currentElement){
            result += '<tr><td>'+ currentElementIncreased.toFixed(2) +
            '</td><td><img src="up.png"/></td></tr>\n';
        }
        else if(currentElementIncreased < currentElement){
            result += '<tr><td>'+ currentElementIncreased.toFixed(2) +
            '</td><td><img src="down.png"/></td></tr>\n';
        }
    }
    result += '</table>'
    //return result;
    console.log(result);
}
var firstArr = ['36.333',
    '36.5',
    '37.019',
    '35.4',
    '35',
    '35.001',
    '36.225'];

var secondArr = ['1.33',
'1.35',
'2.25',
'13.00',
'0.5',
'0.51',
'0.5',
'0.5',
'0.33',
'1.05',
'1.346',
'20',
'900',
'1500.1',
'1500.10',
'2000'];

solve(firstArr);
console.log();
console.log();
console.log();
solve(secondArr);