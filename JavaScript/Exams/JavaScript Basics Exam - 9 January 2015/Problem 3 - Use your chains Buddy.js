function solve(args){
    var input = args[0],
        regex = /<p>(.*?)<\/p>/g,
        txtBtwTags,
        match,
        result = '';
    while(match = regex.exec(input)){
        txtBtwTags = match[1];
        txtBtwTags = txtBtwTags.replace(/[^a-z0-9]+/g, ' ');
        for (var c in txtBtwTags) {
            var currentChar = txtBtwTags[c];
            if((currentChar >= 'a') && (currentChar <= 'm')){
                currentChar = (currentChar.charCodeAt(0)) + 13;
                result  += String.fromCharCode(currentChar);
            } else if((currentChar > 'm') && (currentChar <= 'z')){
                currentChar = (currentChar.charCodeAt(0)) - 13;
                result  += String.fromCharCode(currentChar);
            } else{
                result += currentChar;
            }
        }
    }
    console.log(result);
}
var input = [
    '<html><head><title></title></head><body><h1>hello</h1><p>znahny!@#%&&&&****</p><div><button>dsad</button></div><p>grkg^^^^%%%)))([]12</p></body></html>'
];
solve(input);
