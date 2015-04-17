function calc(arr){
    var bill = Number(arr[0]);
    var mood = arr[1];
    var result;

    switch(mood){
        case 'happy': result = bill*0.1; break;
        case 'married': result = bill * 0.0005; break;
        case 'drunk':
            var current = bill*0.15;
            var currAsString = current.toString();
            currAsString = currAsString.substring(0,1);
            var digit = Number(currAsString);
            result = Math.pow(current, digit);
            break;
        default: result = bill * 0.05; break;
    }
    return result.toFixed(2);
}
