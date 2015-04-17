function solve(input) {

    var result = input.match(/[\w\-_]{3,15}/g);
    console.log(JSON.stringify(result));

}
solve('user 0n_3 %$%^ user-12 muser_14');