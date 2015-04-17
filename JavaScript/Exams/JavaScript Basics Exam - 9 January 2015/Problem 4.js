function solve(args){
    var criteria = args.pop();
    var collection = [];
    var currentObject = {};

    for (var element in args) {
        var currLine = args[element].split(/\.*\*\.*/g),
            name = currLine[0],
            luggage = currLine[1],
            isFood = currLine[2],
            isDrink = currLine[3],
            isFragile = currLine[4],
            weight = Number(currLine[5]),
            transferredWith = currLine[6],
            type = 'other';

        if (!currentObject[name]) {
            currentObject[name] = {};
        }
        if (isFood == 'true') {
            type = 'food';
        } else if (isDrink == 'true') {
            type = 'drink';
        }

        currentObject[name][luggage] = {
            'kg': weight,
            'fragile': isFragile == 'true',
            'type': type,
            'transferredWith': transferredWith
        };
        //console.log(currentObject);
    }
    if(criteria == 'luggage name') {
        var outputNameSort = {};
        Object.keys(currentObject).forEach(function(key){
            outputNameSort[key] = {};
            var sortedInnerKeys = Object.keys(currentObject[key]).sort();

            console.log();
        })
    } else if(criteria == 'weight'){
        criteriaIsWeight()
    } else{
        criteriaIsStrict()
    }

    function criteriaIsStrict(){

    }
    function criteriaIsWeight(){

    }
    function criteriaIsLuggageName(){


    }
}

var input = [
    'Yana Slavcheva.*.clothes.*.false.*.false.*.false.*.2.2.*.backpack',
    'Yana Slavcheva.*.shoes.*.false.*.false.*.false.*.2.2.*.backpack',
    'Kiko.*.socks.*.false.*.false.*.false.*.0.2.*.backpack',
    'Kiko.*.banana.*.true.*.false.*.false.*.3.2.*.backpack',
    'Kiko.*.sticks.*.false.*.false.*.false.*.1.6.*.ATV',
    'Kiko.*.glasses.*.false.*.false.*.true.*.3.*.ATV',
    'Manov.*.socks.*.false.*.false.*.false.*.0.3.*.ATV',
    'luggage name'
];
solve(input);
