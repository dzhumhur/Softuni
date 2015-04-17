function solve(args){
    var result = {'students':[], 'trainers':[]};
    var checkers = args[0].split('^'),
        firstCheck = checkers[0],
        studentsData = [],
        trainersData = [],
        element = 0;
    var currObj = {};
    for (var i = 1; i < args.length; i++) {
        currObj = JSON.parse(args[i]);
        if(currObj.role === 'student'){
            var id = currObj.id,
                firstName = currObj.firstname,
                lastName = currObj.lastname,
                level = currObj.level,
                certification = currObj.certificate;
            var sumGrades = 0;
            for (element in currObj.grades) {
               sumGrades += parseFloat(currObj.grades[element]);
            }
            sumGrades = sumGrades / currObj.grades.length;
            sumGrades = sumGrades.toFixed(2);

            result.students.push({
                level: level,
                id: id,
                firstname: firstName,
                lastname: lastName,
                averageGrade:sumGrades,
                certificate: certification
            });
        }else{
            id = currObj.id;
            firstName = currObj.firstname;
            lastName = currObj.lastname;
            var courses = currObj.courses, lectures = parseInt(currObj.lecturesPerDay);
            result.trainers.push({
                'id': id,
                'firstname': firstName,
                'lastname': lastName,
                'courses': courses,
                'lecturesPerDay': lectures});
        }
    }
    studentsData = result.students;
    switch(firstCheck){
        case 'name':
            studentsData.sort(function(a,b){
                if(a.firstname === b.firstname){
                    return a.lastname.localeCompare(b.lastname);
                }else{
                   return a.firstname.localeCompare(b.firstname)
                }
            });
            break;
        case 'level':
            studentsData.sort(function(a,b){
                if(a.level === b.level){
                    return a.id - b.id;
                }else{
                   return a.level - b.level;
                }
            });
            break;
    }
    result.students = studentsData;

    trainersData = result.trainers;
    trainersData = trainersData.sort(function(x,y){
        var funcA = x.courses.length;
        var funcB = y.courses.length;
        if(funcA === funcB){
            return x.lecturesPerDay - y.lecturesPerDay;
        }else{
            return funcA - funcB;
        }
    });
    result.trainers = trainersData;

    for (element in result.students) {
        delete result.students[element].level;
    }

    console.log(JSON.stringify(result));
    //console.log(result);
}


var input1 = [
    'level^courses',
    '{"id":0,"firstname":"Angel","lastname":"Ivanov","town":"Plovdiv","role":"student","grades":["5.89"],"level":2,"certificate":false}',
    '{"id":1,"firstname":"Mitko","lastname":"Nakova","town":"Dimitrovgrad","role":"trainer","courses":["PHP","Unity Basics"],"lecturesPerDay":6}',
    '{"id":2,"firstname":"Bobi","lastname":"Georgiev","town":"Varna","role":"student","grades":["5.59","3.50","4.54","5.05","3.45"],"level":4,"certificate":false}',
    '{"id":3,"firstname":"Ivan","lastname":"Ivanova","town":"Vidin","role":"trainer","courses":["JS","Java","JS OOP","Database","OOP","C#"],"lecturesPerDay":7}',
    '{"id":4,"firstname":"Mitko","lastname":"Petrova","town":"Sofia","role":"trainer","courses":["Database","JS Apps","Java"],"lecturesPerDay":2}'
];

//var input2 = [
//    'name^courses',
//    {"id":0,"firstname":"Angel","lastname":"Ivanov","town":"Plovdiv","role":"student","grades":["5.89"],"level":2,"certificate":false},
//    {"id":1,"firstname":"Mitko","lastname":"Nakova","town":"Dimitrovgrad","role":"trainer","courses":["PHP","Unity Basics"],"lecturesPerDay":6},
//    {"id":2,"firstname":"Angel","lastname":"Georgiev","town":"Varna","role":"student","grades":["5.59","3.50","4.54","5.05","3.45"],"level":4,"certificate":false},
//    {"id":3,"firstname":"Ivan","lastname":"Ivanova","town":"Vidin","role":"trainer","courses":["JS","Java","JS OOP","Database","OOP","C#"],"lecturesPerDay":7},
//    {"id":4,"firstname":"Mitko","lastname":"Petrova","town":"Sofia","role":"trainer","courses":["Database","JS Apps"],"lecturesPerDay":2}
//];
//
//var input3 = [
//    'level^courses',
//    {"id":0,"firstname":"Hristiqn","lastname":"Petrov","town":"Sofia","role":"student","grades":["4.06","5.17"],"level":5,"certificate":false},
//    {"id":1,"firstname":"Angel","lastname":"Petrov","town":"Sofia","role":"trainer","courses":["Java","JS OOP"],"lecturesPerDay":6},
//    {"id":2,"firstname":"Gergana","lastname":"Nakov","town":"Sliven","role":"trainer","courses":["Java","JS OOP","SDA"],"lecturesPerDay":5},
//    {"id":3,"firstname":"Angel","lastname":"Nakova","town":"Burgas","role":"trainer","courses":["Database","JS OOP","JS","C#","iOS","HTML/CSS"],"lecturesPerDay":6},
//    {"id":4,"firstname":"Petq","lastname":"Nakova","town":"Petrich","role":"student","grades":["5.14"],"level":4,"certificate":true},
//    {"id":5,"firstname":"Julieta","lastname":"Petrov","town":"Svishtov","role":"trainer","courses":["iOS","OOP","JS","C#","Java"],"lecturesPerDay":6},
//    {"id":6,"firstname":"Ivan","lastname":"Ivanov","town":"Stara Zagora","role":"student","grades":["5.28","2.15","4.25","4.95"],"level":2,"certificate":true},
//    {"id":7,"firstname":"Gergana","lastname":"Daskalov","town":"Sofia","role":"trainer","courses":["PHP","ASP.NET","SDA"],"lecturesPerDay":5},
//    {"id":8,"firstname":"Qvor","lastname":"Dimitrov","town":"Sevlievo","role":"student","grades":["4.30","3.14","4.09","4.08","2.25"],"level":5,"certificate":true},
//    {"id":9,"firstname":"Petq","lastname":"Nakov","town":"Gabrovo","role":"trainer","courses":["JS Apps","Java","JS","iOS","SDA","HTML/CSS"],"lecturesPerDay":9},
//    {"id":10,"firstname":"Bobi","lastname":"Nakov","town":"Gabrovo","role":"student","grades":["3.80"],"level":1,"certificate":false}
//];
//var input4 = [
//    'level^courses',
//    {"id":0,"firstname":"Alex","lastname":"Daskalov","town":"Burgas","role":"student","grades":["2.00","4.65","5.09","3.95"],"level":2,"certificate":true},
//    {"id":1,"firstname":"Rosen","lastname":"Georgieva","town":"Sofia","role":"student","grades":["3.76","4.81","4.73"],"level":3,"certificate":true},
//    {"id":2,"firstname":"Zornica","lastname":"Dimitrova","town":"Varna","role":"student","grades":["3.46","4.72","5.21"],"level":2,"certificate":true},
//    {"id":3,"firstname":"Svetlin","lastname":"Nakova","town":"Pernik","role":"student","grades":["3.44","3.27","4.20","4.34","4.29"],"level":3,"certificate":true},
//    {"id":4,"firstname":"Julieta","lastname":"Petrova","town":"Varna","role":"trainer","courses":["Database","OOP","ASP.NET"],"lecturesPerDay":3},
//    {"id":5,"firstname":"Yuliq","lastname":"Petrov","town":"Pernik","role":"student","grades":["2.84","5.15","2.22"],"level":5,"certificate":false},
//    {"id":6,"firstname":"Zornica","lastname":"Daskalov","town":"Petrich","role":"student","grades":["5.16","3.24"],"level":4,"certificate":false},
//    {"id":7,"firstname":"Niki","lastname":"Dimitrova","town":"Ruse","role":"trainer","courses":["Java","PHP","iOS","C#","JS Apps"],"lecturesPerDay":5},
//    {"id":8,"firstname":"Angel","lastname":"Dimitrova","town":"Veliko Tyrnowo","role":"student","grades":["4.25","2.13"],"level":1,"certificate":false},
//    {"id":9,"firstname":"Ivailo","lastname":"Georgiev","town":"Veliko Tyrnowo","role":"trainer","courses":["Database","OOP"],"lecturesPerDay":4},
//    {"id":10,"firstname":"Hristiqn","lastname":"Petrova","town":"Varna","role":"trainer","courses":["JS Apps","SDA","iOS","OOP"],"lecturesPerDay":8},
//    {"id":11,"firstname":"Svetlin","lastname":"Nakova","town":"Burgas","role":"student","grades":["3.58","5.90","3.85"],"level":1,"certificate":false},
//    {"id":12,"firstname":"Kosio","lastname":"Georgieva","town":"Sliven","role":"student","grades":["4.34","2.53","3.20","4.20"],"level":3,"certificate":false},
//    {"id":13,"firstname":"Ivailo","lastname":"Nakova","town":"Sevlievo","role":"trainer","courses":["iOS","Database","HTML/CSS","C#","JS Apps"],"lecturesPerDay":6},
//    {"id":14,"firstname":"Ivailo","lastname":"Petrov","town":"Svishtov","role":"trainer","courses":["Unity Basics","OOP","C#","HTML/CSS"],"lecturesPerDay":6},
//    {"id":15,"firstname":"Bobi","lastname":"Georgiev","town":"Ruse","role":"student","grades":["3.28","4.95","4.07"],"level":3,"certificate":false},
//    {"id":16,"firstname":"Zornica","lastname":"Daskalov","town":"Burgas","role":"student","grades":["5.58"],"level":4,"certificate":false},
//    {"id":17,"firstname":"Deyan","lastname":"Dimitrova","town":"Svishtov","role":"trainer","courses":["iOS","JS Apps","JS OOP","PHP","OOP"],"lecturesPerDay":6},
//    {"id":18,"firstname":"Petq","lastname":"Daskalov","town":"Dimitrovgrad","role":"trainer","courses":["C#","JS","OOP"],"lecturesPerDay":2},
//    {"id":19,"firstname":"Gergana","lastname":"Nakov","town":"Vidin","role":"trainer","courses":["ASP.NET","HTML/CSS"],"lecturesPerDay":3},
//    {"id":20,"firstname":"Gergana","lastname":"Georgieva","town":"Dimitrovgrad","role":"student","grades":["3.38"],"level":4,"certificate":false},
//    {"id":21,"firstname":"Nasko","lastname":"Petrova","town":"Stara Zagora","role":"student","grades":["3.11","5.94","3.28","2.42"],"level":4,"certificate":true},
//    {"id":22,"firstname":"Vlado","lastname":"Dimitrov","town":"Svishtov","role":"student","grades":["2.23","5.74","2.01"],"level":3,"certificate":true},
//    {"id":23,"firstname":"Pesho","lastname":"Georgieva","town":"Petrich","role":"student","grades":["4.50","4.77","4.00","4.73"],"level":5,"certificate":false},
//    {"id":24,"firstname":"Vlado","lastname":"Nakov","town":"Petrich","role":"trainer","courses":["ASP.NET","JS","Database"],"lecturesPerDay":10},
//    {"id":25,"firstname":"Bobi","lastname":"Nakov","town":"Sofia","role":"trainer","courses":["JS Apps","OOP"],"lecturesPerDay":8},
//    {"id":26,"firstname":"Hristo","lastname":"Ivanov","town":"Gabrovo","role":"trainer","courses":["ASP.NET","Database","JS"],"lecturesPerDay":1},
//    {"id":27,"firstname":"Julieta","lastname":"Dimitrova","town":"Plovdiv","role":"trainer","courses":["JS OOP","Unity Basics"],"lecturesPerDay":1},
//    {"id":28,"firstname":"Qvor","lastname":"Petrov","town":"Sofia","role":"student","grades":["4.46","3.81","5.60","5.04"],"level":2,"certificate":true},
//    {"id":29,"firstname":"Hristiqn","lastname":"Dimitrova","town":"Plovdiv","role":"student","grades":["2.99","4.76","3.00","3.07"],"level":3,"certificate":true},
//    {"id":30,"firstname":"Vlado","lastname":"Dimitrova","town":"Veliko Tyrnowo","role":"student","grades":["3.09","2.72","4.55","4.90"],"level":4,"certificate":false},
//    {"id":31,"firstname":"Hristiqn","lastname":"Daskalov","town":"Ruse","role":"trainer","courses":["SDA","Database","JS Apps","C#","Java","JS OOP"],"lecturesPerDay":1},
//    {"id":32,"firstname":"Julieta","lastname":"Georgiev","town":"Vidin","role":"trainer","courses":["HTML/CSS","OOP","Java","Database","JS Apps","JS OOP"],"lecturesPerDay":6},
//    {"id":33,"firstname":"Alex","lastname":"Nakov","town":"Sevlievo","role":"trainer","courses":["Database","C#","JS Apps","SDA"],"lecturesPerDay":2},
//    {"id":34,"firstname":"Mariq","lastname":"Dimitrov","town":"Burgas","role":"student","grades":["2.38","3.80"],"level":2,"certificate":true}
//];
solve(input1);