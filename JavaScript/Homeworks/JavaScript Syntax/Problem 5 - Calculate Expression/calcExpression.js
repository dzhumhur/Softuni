function calcExpression(value){
    var result = eval(value);
    document.getElementById('output').innerHTML = result;
}