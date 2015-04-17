function solve(args){
    var start = Number(args[0]);
    var end = Number(args[1]);
    var result = '<table>' + '\n' + '<tr><th>Num</th><th>Square</th><th>Fib</th></tr>' + '\n';
    for (var i = start; i <= end; i++) {
        result += '<tr><td>' + i + '</td><td>' + i*i + '</td><td>' + isFib(i) + '</td></tr>\n';
    }
    result += '</table>';

     function isFib(currentNum){
         var first = 0;
         var second = 1;
         var isFind = false;

         for (var i = 0; i < 30; i++) {
             var third = first + second;
             if(third === currentNum){
                 isFind = true;
                 break;
             }else{
                 first = second;
                 second = third;
             }
         }
         if(isFind){
             return 'yes';
         }else{
             return 'no';
         }
     }
    return result;
}
var arr= [2,6];
console.log(solve(arr));

