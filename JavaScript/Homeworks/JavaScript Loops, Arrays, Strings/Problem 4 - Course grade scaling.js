function solve(arr){
    for (var element in arr) {
        arr[element]['score'] *= 1.1;
        arr[element]['score'] = Math.round(arr[element]['score']*10)/10;
        if(arr[element]['score'] >= 100){
           arr[element]['hasPassed'] = true;
        }else{
            arr[element]['hasPassed'] = false;
        }
    }
    arr = arr.filter(function(element){
        return element['hasPassed'] === true;
    });
    arr = arr.sort(function(x,y){
        return x.name > y.name;
    })
    console.log(arr);
}
var arr = [
    {
        'name' : 'Пешо',
        'score' : 91
    },
    {
        'name' : 'Лилия',
        'score' : 290
    },
    {
        'name' : 'Алекс',
        'score' : 343
    },
    {
        'name' : 'Габриела',
        'score' : 400
    },
    {
        'name' : 'Жичка',
        'score' : 70
    }
];
solve(arr);