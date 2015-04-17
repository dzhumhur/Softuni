function solve(args) {
    var criteria = args.pop().replace(" ", "");
    var collection = [];

    for (var row in args) {
        var data = args[row].split(/\.*\*\.*/g);
        var name = data[0];
        var posessionName = data[1];
        var isFood = data[2];
        var isDrink = data[3];
        var isFragile = data[4];
        var weight = Number(data[5]);
        var transferedWith = data[6];
        var type = "other";
        if (isFood == "true") type = "food";
        else if (isDrink == "true") type = "drink";
        var possesion = {
            luggagename: posessionName, // this key name will be used for sorting later
            weight: weight, // this key name will be used for sorting later too
            isFragile: isFragile == "true",
            type: type,
            transferredWith: transferedWith
        };
        var found = false;
        for (var k in collection) {
            if (collection[k]["name"] == name) {
                for (var p in collection[k]["possessions"]) {
                    if (collection[k]["possessions"][p]["name"] == posessionName) {
                        delete collection[k]["possessions"][p]
                        break;
                    }
                }
                collection[k]["possessions"].push(possesion);
                found = true;
            }
        }

        if (!found) {
            var tourist = {
                name: name,
                possessions: []
            };
            tourist.possessions.push(possesion);
            collection.push(tourist);
        }
    }
    function mySort(a, b)
    {
        if (criteria == 'strict') {
            return 0;
        }

        return a[criteria] > b[criteria];
    }

    collection.forEach(function(tourist) {

        tourist.possessions.sort(mySort);
    });
    var result = {};
    collection.forEach(function(tourist) {
        result[tourist.name] = {};
        tourist.possessions.forEach(function(possesion) {
            result[tourist.name][possesion.luggagename] = {
                kg: possesion.weight,
                fragile: possesion.isFragile,
                type: possesion.type,
                transferredWith: possesion.transferredWith
            }
        })
    });
    console.log(JSON.stringify(result));
}

solve ([
    'Yana Slavcheva...*..clothes..*false*false......*...false..*..2.2..*.backpack',
    'Kiko..*...socks..*false*false......*...false..*..0.2..*.backpack',
    'Kiko....*...banana..*true*false......*...false..*..3.2..*.backpack',
    'Kiko......*...sticks..*false.....*false......*...false..*..1.6..*.ATV',
    'Kiko*...glasses..*false*...false......*...true..*..3..*.ATV',
    'Manov..*...socks..*false*false....*...false..*0.3..*.ATV',
    'luggage name']);