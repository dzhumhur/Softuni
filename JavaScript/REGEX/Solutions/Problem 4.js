function solve(input) {

    var result = input.match(/[0-9./-]+/g);
    console.log(JSON.stringify(result));

}
solve("Rodih se  na 10.10.1987 i rojdeniq mi den e 2.12.2004");
solve('Koi den sme dnes? Mii 3-24-2015');
solve('blabla03/24/2015vla');