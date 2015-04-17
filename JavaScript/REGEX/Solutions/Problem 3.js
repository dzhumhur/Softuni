function solve(input) {

    var result = input.match(/[A-Z][a-z]+ [A-Z][a-z]+ [A-Z][a-z]+/g);
    console.log(JSON.stringify(result));

}
solve("Pesho Peshev Peshev");