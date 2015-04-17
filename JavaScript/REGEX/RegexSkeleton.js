function solve(input) {

    var result = input.match(/([A-Z][a-z\s]+)+(\.?)/g);
    console.log(JSON.stringify(result));

}
solve("Iliqn Iliqnov Jr.");
