var canvas = document.getElementById('canvas');
var context = canvas.getContext('2d');
var centerX1 = canvas.width / 2;
var centerY1 = canvas.height / 2;
var radius = 80;
context.beginPath();
context.arc(centerX1 + 18, centerY1 + 68, radius, 0, 2 * Math.PI, false);
context.fillStyle = '#95CDD9';
context.fill();
context.lineWidth = 5;
context.strokeStyle = '#275A65';
context.stroke();



var centerX = -14;
var centerY = 50;
radius = 10;
context.save();
context.translate(canvas.width / 2, canvas.height / 2);
context.scale(2, 1);
context.beginPath();
context.arc(centerX, centerY, radius, 0, 2 * Math.PI, false);
context.restore();
context.fillStyle = '#95CDD9';
context.fill();
context.lineWidth = 2;
context.strokeStyle = '#275A65';
context.stroke();


var centerX2 = 20;
var centerY2 = 50;
radius = 10;
context.save();
context.translate(canvas.width / 2, canvas.height / 2);
context.scale(2, 1);
context.beginPath();
context.arc(centerX2, centerY2, radius, 0, 2 * Math.PI, false);
context.restore();
context.fillStyle = '#95CDD9';
context.fill();
context.lineWidth = 2;
context.strokeStyle = '#275A65';
context.stroke();

context.beginPath();
context.arc(65, 200, 6, 0, 2 * Math.PI, false);
context.fillStyle = '#275A65';
context.fill();
context.lineWidth = 2;
context.strokeStyle = '#275A65';
context.stroke();

context.beginPath();
context.arc(135, 200, 6, 0, 2 * Math.PI, false);
context.fillStyle = '#275A65';
context.fill();
context.lineWidth = 2;
context.strokeStyle = '#275A65';
context.stroke();

context.beginPath();
context.lineJoin="round";
context.moveTo(110,200);
context.lineTo(90,240);
context.lineTo(110,240);
context.stroke();


var centerX3 = 6;
var centerY3 = 230;
radius = 15;
context.save();
context.translate(canvas.width / 2, canvas.height / 2);
context.scale(2.5, 0.5);
context.beginPath();
context.arc(centerX3, centerY3, radius, 0,  2 * Math.PI, false);
context.restore();
context.fillStyle = '#95CDD9';
context.fill();
context.lineWidth = 2;
context.strokeStyle = '#275A65';
context.stroke();

context.save();
context.beginPath();
context.scale(3,0.8);
context.arc(40, 180, 30, 0, Math.PI*2);
context.fillStyle = '#3F6C98';
context.fill();
context.strokeStyle = 'black';
context.stroke();
context.restore();


context.beginPath();
context.lineJoin="round";
context.moveTo(80,27);
context.lineTo(80,130);
context.bezierCurveTo(80, 150, 160, 150, 160, 130);
context.lineTo(160,130);
context.lineTo(160,27);
context.fillStyle = '#3F6C98';
context.fill();
context.strokeStyle = 'black';
context.stroke();

centerX3 = 10;
centerY3 = -120;
radius = 20;
context.save();
context.translate(canvas.width / 2, canvas.height / 2);
context.scale(2, 1);
context.beginPath();
context.arc(centerX3, centerY3, radius, 0,  2 * Math.PI, false);
context.restore();
context.fillStyle = '#3F6C97';
context.fill();
context.lineWidth = 2;
context.strokeStyle = 'black';
context.stroke();


