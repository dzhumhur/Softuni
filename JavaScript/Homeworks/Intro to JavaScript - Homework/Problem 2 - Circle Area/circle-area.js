function calcCircleArea(r){
    return Math.PI*r*r;
}
for (var i = 0; i < 3; i++) {
    var r = prompt();
    calcCircleArea(r);
    document.writeln("<p>r = " + r +"; area = "+ calcCircleArea(r) + "</p>");
}
