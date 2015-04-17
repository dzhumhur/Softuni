function solve(arr){

    //var currentRes = [];
    arr = arr.filter(function (element){
        return element instanceof Object &&
            !(element instanceof Array);
    })
    //for (var element in arr) {
    //    if(arr[element]instanceof Object  && !(arr[element]instanceof Array)){
    //         currentRes.push(arr[element]);
    //    }
    //}
    console.log(arr);
    //console.log(currentRes);

    //var regex = /\{.*?\}/g;
    //var result = '';
    //var string = JSON.stringify(arr);
    //result = string.match(regex);
    //console.log(result);

}
var arr = [
    "Pesho",
    4,
    4.21,
    { name : 'Valyo', age : 16 },
    { type : 'fish', model : 'zlatna ribka' },
    [1,2,3],
    "Gosho",
    { name : 'Penka', height: 1.65}
];
solve(arr);