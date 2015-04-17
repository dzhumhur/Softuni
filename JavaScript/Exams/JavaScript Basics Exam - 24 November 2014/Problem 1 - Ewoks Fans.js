function solve(args){
    var start = new Date('01.01.1900');
    var end = new Date('01.01.2015');
    var checkDate = new Date('05.25.1973');

    var isBigHater = new Date('05.24.1973');
    var isBigFan = new Date('12.31.2014');
    var isFindBigHater = false;
    var isFindBigFan = false;
    var haters = [];
    var fans = [];
    for (var element in args) {
        var check = args[element];
        var getDates = check.split('.');
        var newDate = getDates[1] + '.' + getDates[0] + '.' + getDates[2];
        var date = new Date(newDate);


        if(date > start && date <= isBigHater ){
            //isBigHater = date;
            isFindBigHater =  true;
            haters.push(date);
        }else{
            if(date >= checkDate && date < end){
                //isBigFan = date;
                isFindBigFan = true;
                fans.push(date);
            }
        }
    }
    var adefanDates = function(a, b){
        if(a > b) {
            return 1;
        }
        if(a < b){
            return -1;
        }
        return 0;
    };
    haters = haters.sort(adefanDates);
    fans = fans.sort(adefanDates);

    var hater = haters[0];
    var fan = fans[fans.length - 1];
    if((!isFindBigFan) && (!isFindBigHater)){
        console.log('No result');
    }else{
        if(isFindBigFan){
            console.log('The biggest fan of ewoks was born on ' + fan.toString().substring(0,15));
        }else{
            console.log();
        }
        if(isFindBigHater){
            console.log('The biggest hater of ewoks was born on ' +  hater.toString().substring(0, 15));
        }else{
            console.log();
        }
    }
}

var input = [
    '22.03.2014',
    '17.05.1933',
    '10.10.1954'
];

var input2 = ['22.03.2000'];

var input3 = [
    '22.03.1700',
    '01.07.2020'
];

var input4 = [
    '25.11.2002',
    '19.06.2001',
    '18.12.1966',
    '29.03.1955'
];

var input5 = [
    '27.06.1926',
    '01.08.1985',
    '20.10.1949',
    '16.05.2004',
    '10.12.2022',
    '27.12.1974',
    '20.09.1896',
    '06.09.1949',
    '20.07.1933',
    '23.05.2014',
    '27.10.1926',
    '15.12.2027',
    '26.01.1947',
    '03.09.1869',
    '05.05.1983',
    '15.09.1970',
    '03.02.1852',
    '08.09.1974',
    '14.02.1942',
    '21.02.1917',
    '02.11.2010',
    '01.06.2042',
    '04.02.1946',
    '17.01.2044',
    '02.07.1897',
    '25.01.1983',
    '21.07.1925',
    '28.02.1997',
    '25.05.1990',
    '09.07.1875',
    '23.09.1861',
    '09.04.1978',
    '23.02.1937',
    '22.03.1869',
    '22.01.1883',
    '07.06.1874',
    '18.03.1856',
    '28.05.2047',
    '05.12.2015',
    '14.03.1995',
    '07.02.1954',
    '27.07.1911',
    '22.07.1874',
    '03.05.2036',
    '15.01.1918',
    '06.08.1904',
    '26.02.1947',
    '10.04.1984',
    '11.01.1922',
    '15.02.1935',
    '15.11.1884',
    '13.01.2003',
    '11.09.1914',
    '13.10.2010',
    '15.09.1895',
    '06.12.2000',
    '05.02.1909',
    '09.05.1951',
    '27.06.1963',
    '15.01.1888'
];

var input7 = [
    '09.04.1978',
    '23.02.1937',
    '22.03.1869',
    '22.01.1883',
    '07.06.1874',
    '18.03.1856',
    '28.05.2047',
    '05.12.2015',
    '14.03.1995',
    '07.02.1954',
    '27.07.1911',
    '22.07.1874',
    '03.05.2036',
    '15.01.1918',
    '06.08.1904',
    '26.02.1947',
    '10.04.1984',
    '11.01.1922',
    '15.02.1935',
    '15.11.1884',
    '13.01.2003',
    '11.09.1914',
    '13.10.2010',
    '15.09.1895',
    '06.12.2000',
    '05.02.1909',
    '09.05.1951',
    '27.06.1963',
    '15.01.1888'
];
solve(input5);