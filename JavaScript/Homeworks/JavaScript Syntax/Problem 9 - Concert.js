function solve(args){

  var result = {};

    for (var element in args) {
        Array.prototype.contains = function(arg){
            for(var i = 0; i < this.length; i++)
                if(this[i] === arg)
                    return true;
            return false;
        };
        var currLine = args[element].split(' | ');

        var group = currLine[0],
            city = currLine[1],
            date = currLine[2],
            stadium = currLine[3];

        if(!result[city]){
            result[city] = {};
        }
        if(!result[city][stadium]){
            result[city][stadium] = [];
        }
        if(!result[city][stadium].contains(group)){
            result[city][stadium].push(group);
        }

    }
    
    var sortedKeys = Object.keys(result).sort();

    for (var key in sortedKeys) {
        var resultKey = result[sortedKeys[key]];
        console.log(resultKey);
        console.log();
        var sortedKey = {

        };
        var stadiums = result[keys[key]];

        stadiums.sort(function(a, b){
            return a.keys[key]
        })
    }




    ////Sorting object's cities
    //var sortedObj = {};
    //var keys = [];
    //var k, j, len;
    //for (k in result) {
    //    if (result[k]) {
    //        keys.push(k);
    //    }
    //}
    //
    //keys.sort();
    //len = keys.length;
    //
    //for (j = 0; j < len; j++) {
    //    k = keys[j];
    //    sortedObj[k] = result[k];
    //}
    //
    ////Sorting cities stadiums
    //for (var city in sortedObj) {
    //    var sortedInnerObj = {},
    //    keys = [],
    //    k, j, len;
    //
    //    for (k in sortedObj[city]) {
    //        if (sortedObj[city][k]) {
    //            keys.push(k);
    //        }
    //    }
    //
    //    keys.sort();
    //    len = keys.length;
    //
    //    for (j = 0; j < len; j++) {
    //        k = keys[j];
    //        sortedInnerObj[k] = sortedObj[city][k];
    //    }
    //    sortedObj[city] = sortedInnerObj;
    //}
    //
    ////Sorting stadium's group
    //for (var city in sortedObj) {
    //    for (var stadium in sortedObj[city]) {
    //        var sortedGroup = sortedObj[city][stadium].sort();
    //        sortedObj[city][stadium] = sortedGroup;
    //
    //    }
    //}
    //console.log(JSON.stringify(sortedObj));
    
    


}

var input = [
    'ZZ Top | London | 2-Aug-2014 | Wembley Stadium',
    'Iron Maiden | London | 28-Jul-2014 | Wembley Stadium',
    'Metallica | Sofia | 11-Aug-2014 | Lokomotiv Stadium',
    'Helloween | Sofia | 1-Nov-2014 | Vassil Levski Stadium',
    'Iron Maiden | Sofia | 20-June-2015 | Vassil Levski Stadium',
    'Helloween | Sofia | 30-July-2015 | Vassil Levski Stadium',
    'Iron Maiden | Sofia | 26-Sep-2014 | Lokomotiv Stadium',
    'Helloween | London | 28-Jul-2014 | Wembley Stadium',
    'Twisted Sister | London | 30-Sep-2014 | Wembley Stadium',
    'Metallica | London | 03-Oct-2014 | Olympic Stadium',
    'Iron Maiden | Sofia | 11-Apr-2016 | Lokomotiv Stadium',
    'Iron Maiden | Buenos Aires | 03-Mar-2014 | River Plate Stadium'
];
solve(input);