function findYoungestPerson(array){
    var str = [];
    var youngest = Number.MAX_VALUE;

    for (var obj in array) {
        if(array[obj].hasSmartphone){
            str.push(array[obj]);
        }
    }
    for (var agePeople in str) {
        if(str[agePeople].age < youngest){
            youngest = str[agePeople].age;
        }
    }
    for (var element in str) {
        if(str[element].age == youngest){
            console.log('The youngest people is %s %s', str[element].firstname,str[element].lastname);
        }
    }
}
var people = [
    { firstname : 'George', lastname: 'Kolev', age: 32, hasSmartphone: false },
    { firstname : 'Vasil', lastname: 'Kovachev', age: 40, hasSmartphone: true },
    { firstname : 'Bay', lastname: 'Ivan', age: 81, hasSmartphone: true },
    { firstname : 'Baba', lastname: 'Ginka', age: 40, hasSmartphone: false }];

findYoungestPerson(people);
