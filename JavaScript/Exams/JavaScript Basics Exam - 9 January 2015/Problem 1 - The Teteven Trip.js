/*
 We take "BMW petrol 1 320.5". We have a base 
 consumption of 10l per 100km. For petrol c = 1, 
 so the consumption stays 10l per 100km. Extra fuel
 for luggage is 320.5*0.01l = 3.205l. So now the base
 fuel consumption is 10 + 3.205 = 13.205l per 100km.
 Route 1 has 110 km in total. The total consumption 
 is calculated by 110km*(13.205l/100km) = 14.5255l. 
 The extra snow consumption is 0.3*13.205 = 3.962l per 100km. 
 Now we add 10km*(3.962l/100km) = 0.3962l. The total amount
 is now 0.3962 + 14.5255 = 14.9217l. When rounded the total
 fuel consumption is 15l.
 */
function solve(args){

    function calcSpentFuel() {
        if (route == 1) {
            currentSpent = normalSpent + luggageWeight;
            spentforRoute1 = route1 * (currentSpent / 100);
            extraSnowConsump = 0.3 * currentSpent;
            extraSnowConsump = 10 * (extraSnowConsump / 100);
            totalSpent = Math.round(spentforRoute1 + extraSnowConsump);
        } else {
            currentSpent = normalSpent + luggageWeight;
            spentforRoute1 = route2 * (currentSpent / 100);
            extraSnowConsump = 0.3 * currentSpent;
            extraSnowConsump = 35 * (extraSnowConsump / 100);
            totalSpent = Math.round(spentforRoute1 + extraSnowConsump);
        }
    }

    for (var element in args) {
        var currentLine = args[element].split(' '),
            carModel = currentLine[0],
            typeOfFuel = currentLine[1],
            route = currentLine[2],
            luggageWeight = (currentLine[3]*0.01),
            route1 = 110,
            route2 = 95,
            currentSpent = 0,
            extraSnowConsump = 0,
            totalSpent = 0,
            spentforRoute1 = 0,
            normalSpent = 10;

        switch(typeOfFuel){
            case 'petrol':
                break;
            case 'gas':
                    normalSpent *= 1.2;
                break;
            case 'diesel':
                    normalSpent *= 0.8;
                break;
        }
        calcSpentFuel();
        console.log(carModel + ' ' + typeOfFuel + ' ' + route + ' ' + totalSpent);
    }
}
var input1 = [
  'BMW petrol 1 320.5',
  'Golf petrol 2 150.75',
  'Lada gas 1 202',
  'Mercedes diesel 2 312.54'
];
solve(input1);