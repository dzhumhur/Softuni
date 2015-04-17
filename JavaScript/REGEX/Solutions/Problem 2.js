function solve(input) {

    var result = (/<a (href=('|")(.*)('|"))/g).exec(input);
    console.log(JSON.stringify(result[1]));

}
solve("<a href='google.com'></a>");