function solve(input) {
//\b[A-Za-z0-9\.\_\-]+\@[A-Za-z]+\.[a-z]{2,}
// [A-Za-z0-9\.\-\_]+\@\w+\.\w+
    var result = input.match(/[A-Za-z0-9\.\-\_]+\@\w+\.\w+/g);
    console.log(JSON.stringify(result));

}
solve("meil SLO4AENOS.NeMisLA@Eliomenad.com mail");
