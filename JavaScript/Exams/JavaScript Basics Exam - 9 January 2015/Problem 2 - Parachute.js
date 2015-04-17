function solve(args){
    var checkChar, char, isFindParachutist = false, isFindResult = false;

    for (var row in args) {
        var currentLine = args[row];
        checkChar = currentLine.indexOf('o');
        if(checkChar > -1) {
            char = checkChar;
            isFindParachutist = true;
            continue;
        }
        if(isFindParachutist){
            var wind = (currentLine.match(/>/g) || []).length - (currentLine.match(/</g) || []).length;
            char += wind;
            var currChar = args[row][char];
            logResult();
        }
        if(isFindResult){
            break;
        }
    }
    function logResult() {
        switch (currChar) {
            case '_':
                console.log('Landed on the ground like a boss!');
                console.log(row + ' ' + char);
                isFindResult = true;
                break;
            case '~':
                console.log('Drowned in the water like a cat!');
                console.log(row + ' ' + char);
                isFindResult = true;
                break;
            case '/':
            case '|':
            case '\\':
                console.log('Got smacked on the rock like a dog!');
                console.log(row + ' ' + char);
                isFindResult = true;
            default:
                break;
        }
    }
}

var input = [
    '>>>>>>>>>>>o<<<<<<<<<<<<<',
    '----------~~~------------',
    '--------~/~~~\\~----------',
    '-------~/~---~\\~---------',
    '------~/~-----~\\~--------',
    '-----~/~-------~\\~-------',
    '----~/~---------~\\~------',
    '---~/~-----------~\\~-----',
    '--~/~-------------~\\~----',
    '-~/~---------------~\\~---'
];

solve(input);