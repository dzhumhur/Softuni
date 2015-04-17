function solve(input) {

    var result = input.match(/((?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()\-_=+]){8,20})/g);
    console.log(JSON.stringify(result));

}
solve("Iliqn Iliqnov Jr.");