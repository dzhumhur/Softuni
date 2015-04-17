function solve(args){
    var allowedJumps = Number(args[0]);
    var lengthOfTheTrack = Number(args[1]);
    var numberOfFleas = args.length - 2;
    var pist = [];
    var string = '';
    var jumpDistParticipant = [];
    var participantName = [];
    var starPositions = [];
    var upperLettersOfParticipant = [];
    var winner = '';
    var isFindWinner = false;
    var result = [];

    for (var k = 2; k < args.length; k++) {
       var currLine = args[k].split(', ');
        var name = currLine[0];
        var jumpDistance = currLine[1];
        jumpDistParticipant.push(Number(jumpDistance));
        participantName.push(name);
        starPositions.push(Number(0));
        var letter = name[0].toUpperCase();
        upperLettersOfParticipant.push(letter);
    }
    for (var i = 0; i < numberOfFleas; i++) {
        for (var j = 0; j < lengthOfTheTrack; j++) {
            string += '.';
        }
        pist.push(string);
        string = '';
    }



    for (var m = 0; m < allowedJumps; m++) {
        if(!isFindWinner){
            for (var n = 0; n < jumpDistParticipant.length; n++) {
                starPositions[n] += Number(jumpDistParticipant[n]);
                if(!isFindWinner){
                    if(starPositions[n] >= lengthOfTheTrack - 1) {
                        winner = participantName[n];
                        isFindWinner = true;
                        break;
                    }
                }
            }
        }
    }
    for (var s = 0; s < starPositions.length; s++) {
        if(starPositions[s] >= lengthOfTheTrack){
            starPositions[s] = lengthOfTheTrack - 1;
        }
    }
    var isLastWinn = false;
    for (var p = 0; p < starPositions.length - 1; p++) {
        if(starPositions[p] != starPositions[p+1]){
            isLastWinn = true;
        }
    }
    if(!isLastWinn){
        winner = participantName[participantName.length - 1];
    }



    string = '';
    var printed = false;
    for (var row = 0; row < participantName.length; row++) {
        for (var col = 0; col < lengthOfTheTrack; col++) {
            if(!printed){
                if(starPositions[row] > col){
                    string += '.';
                }else{
                    string += upperLettersOfParticipant[row];
                    printed = true;
                }
            }else{
                string += '.';
            }

        }
        printed = false;
        result.push(string);
        string = '';
    }
    var dies = '';
    for (i = 0; i < lengthOfTheTrack; i++) {
        dies += '#'
    }
    console.log(dies);
    console.log(dies);
    for (var i = 0; i < result.length; i++) {
        console.log(result[i]);
    }
    console.log(dies);
    console.log(dies);
    console.log('Winner: ' + winner);

}

var input = [
    10,
    20,
    'angel, 9',
    'Boris, 13',
    'Georgi, 3',
    'Dimitar, 7'
];

var input2 = [
    3,
    5,
    'cura, 1',
    'Pepi, 1',
    'UlTraFlea, 1',
    'BOIKO, 1'
];

var input3 = [
    '3',
    '40',
    'S, 5',
    'L, 1',
    'O, 7',
    'C, 3',
    'H, 10',
    'A, 12',
    'I, 5',
    'N, 8',
    'O, 0',
    'S, 6'
];
solve(input3);

