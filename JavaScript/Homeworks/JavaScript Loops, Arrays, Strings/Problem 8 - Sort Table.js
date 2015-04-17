function solve(arr){
    var result = [];
    //var regex = /(<td>)([.0-9]+)/g;
    for (var i = 2, j = 0; i < arr.length - 1; i++,j++) {
        var rowData = arr[i];
        var regex = /<td>.*?<\/td><td>(.*?)<\/td>/g;
        var match = regex.exec(rowData);
        var price = Number(match[1]);
        var row = { price: price, data: rowData };
        result.push(row);
    }
    result.sort(function(a, b){
        if(a.price !== b.price){
            return a.price - b.price;
        }else{
            if(a.data === b.data){
                return false;
            }else{
                if(a.data < b.data){
                    return false;
                }else{
                    return true;
                }
            }
        }
    });
    var lastResult = arr[0] + '\n' + arr[1] + '\n';
    for (var index in result) {
        lastResult += result[index].data + '\n';
    }
    lastResult += '</table>'
    return lastResult;
    //console.log(numbers.sort());
}

var arr = ['<table>',
'<tr><th>Product</th><th>Price</th><th>Votes</th></tr>',
'<tr><td>Vodka Finlandia 1 l</td><td>19.35</td><td>+12</td></tr>',
'<tr><td>Ariana Radler 0.5 l</td><td>1.19</td><td>+33</td></tr>',
'<tr><td>Laptop HP 250 G2</td><td>629</td><td>+1</td></tr>',
'<tr><td>Kamenitza Grapefruit 1 l</td><td>1.85</td><td>+7</td></tr>',
'<tr><td>Ariana Grapefruit 1.5 l</td><td>1.85</td><td>+7</td></tr>',
'<tr><td>Coffee Davidoff 250 gr.</td><td>11.99</td><td>+11</td></tr>',
'</table>'];
solve(arr);