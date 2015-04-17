function solve(args){
    var directions = args[0].split(', ');
    var matrix = [];
    var countOfCarrots = 0,
        countOfCabbage = 0,
        countOfLettuce = 0,
        countOfTurnip = 0,
        wallHits = 0;
    var walls = [];
    for (var i = 1; i < args.length; i++) {
        var currLine = args[i].split(', ');
      matrix.push(currLine);
    }
    var row = 0;
    var col = 0;
    var passedCells = [];
    var regex = /({!})|({\*})|({&})|({#})/g;
    var match;
    var cell = '';
    for (var direction = 0; direction < directions.length; direction++) {
        var currDirection = directions[direction];
        switch(currDirection){
            case 'right':

                if(col + 1 < matrix[row].length){
                    cell = matrix[row][col + 1]
                    walls.push(cell);
                    col = col + 1;
                    match = cell.match(regex);
                    wallHits++;
                    for (var currVegetable in match) {
                        var vegetable = match[currVegetable];
                       switch(vegetable){
                           case '{!}': countOfCarrots++; break;
                           case '{*}': countOfCabbage++; break;
                           case '{&}':countOfLettuce++ ; break;
                           case '{#}': countOfTurnip++; break;
                           default: break;
                       }

                    }

                }else{
                    cell = matrix[row][col];
                }
                break;

            case 'up':
                    if(row-1>=0){
                        cell = matrix[row - 1][col];
                        walls.push(cell);

                        row = row - 1;
                        match = cell.match(regex);
                        wallHits++;
                        for (currVegetable in match) {
                            vegetable = match[currVegetable];
                            switch(vegetable){
                                case '{!}': countOfCarrots++; break;
                                case '{*}': countOfCabbage++; break;
                                case '{&}':countOfLettuce++ ; break;
                                case '{#}': countOfTurnip++; break;
                                default: break;
                            }

                        }

                    }else{
                        cell = matrix[row][col];
                    }


                break;

            case 'down':

                if(row + 1 < matrix.length){
                    cell = matrix[row + 1][col];
                    walls.push(cell);

                    row = row + 1;
                    match = cell.match(regex);
                    wallHits++;
                    for (currVegetable in match) {
                        vegetable = match[currVegetable];
                        switch(vegetable){
                            case '{!}': countOfCarrots++; break;
                            case '{*}': countOfCabbage++; break;
                            case '{&}':countOfLettuce++ ; break;
                            case '{#}': countOfTurnip++; break;
                            default: break;
                        }

                    }

                }else{
                    cell = matrix[row][col];
                }
                break;

            case 'left':

                if((col - 1) >= 0){
                    cell = matrix[row][col - 1];
                    walls.push(cell);

                    col = col - 1;
                    match = cell.match(regex);
                    wallHits++;
                    for (currVegetable in match) {
                        vegetable = match[currVegetable];
                        switch(vegetable){
                            case '{!}': countOfCarrots++; break;
                            case '{*}': countOfCabbage++; break;
                            case '{&}':countOfLettuce++ ; break;
                            case '{#}': countOfTurnip++; break;
                            default: break;
                        }

                    }

                }else{
                    cell = matrix[row][col];
                }
                break;

            default: break;
        }
    }
    if(matrix.length === 1){
        wallHits = directions.length;
    }
    var object = {
        '&': countOfLettuce,
        '*': countOfCabbage,
        '#': countOfTurnip,
        '!': countOfCarrots,
        'wall hits': wallHits
    };
    console.log(JSON.stringify(object));
    var pechat = '';
    for (var obj in walls) {
        var neznam = walls[obj];
        neznam = neznam.replace('{#}', '@');
        neznam = neznam.replace('{!}', '@');
        neznam = neznam.replace('{*}', '@');
        neznam = neznam.replace('{&}', '@');
        pechat += neznam+'|';
    }
    var results = pechat.substr(0, pechat.length - 1);
    console.log(results);
}

var input = [
'right, right, down, right, up',
'asdf, as{#}aj{g}dasd, kjldk{!}fdffd, jdflk{#}jdfj',
'tr{X}yrty, zxx{*}zxc, mncvnv{&}cn, popi{!}poip',
'poiopipo, nmf{X}d{X}ei, mzoijwq, omcxzne'
];

var input2 = [
    'right, down, down, right, down, down, down, down, down, down, down',
    'a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, ',
    'a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, ',
    'a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, ',
    'a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, ',
    'a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, ',
    'a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, ',
    'a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, ',
    'a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, ',
    'a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, ',
    'a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, a{!}as, '
];

solve(input2);