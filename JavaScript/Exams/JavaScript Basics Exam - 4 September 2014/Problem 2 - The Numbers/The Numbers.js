function solve(str){
    var re = new RegExp('[^0-9]+');
    var currStr = str.split(re);
    var currentNum;
    var number = 0;
    var arr = [];
    var change = 0;
    for (var i = 0; i < currStr.length; i++) {

        if(currStr[i] === ''){
            continue;
        }
        else{
            number = Number(currStr[i]);
            if(number < 10){
                change = (number).toString(16).toUpperCase();
                currentNum = ('0x000' + change);
            }
            if(number < 256){
                change = (number).toString(16).toUpperCase();
                currentNum = '0x00' + change;
            }
            if(number < 4096){
                change = (number).toString(16).toUpperCase();
                currentNum = '0x0' + change;
            }
            else{
                change = (number).toString(16).toUpperCase();
                currentNum = change;
            }
        }

        arr += currentNum + '-';
    }
    var string = arr;
    var result = string.substr(0, string.length - 1);

    //return result;
    console.log(result);
}

var str = '5tffwj(//*7837xzc2---34rlxXP%$”.';
////482vMWo(*&^%$213;k!@41341((()&^>><///]42344p;e312
////5tffwj(//*7837xzc2---34rlxXP%$”.
solve(str);