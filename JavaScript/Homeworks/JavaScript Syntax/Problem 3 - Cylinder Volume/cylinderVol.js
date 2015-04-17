function calcCylinderVol(arr){
    var r = arr[0];
    var h = arr[1];
    var volumeOfcCylinder = Math.PI * r * r * h;
    console.log(volumeOfcCylinder.toFixed(3));
}
var arr = [2,4];
calcCylinderVol(arr);

arr = [5,8];
calcCylinderVol(arr);

arr = [12,3];
calcCylinderVol(arr);