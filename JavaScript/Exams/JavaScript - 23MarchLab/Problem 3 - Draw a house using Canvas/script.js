var canvas = document.getElementById("house");
var ctx = canvas.getContext('2d');
ctx.fillStyle = '#975b5b';
ctx.beginPath();
ctx.lineWidth = 3;
ctx.moveTo(0,180);
ctx.lineTo(200,0);
ctx.lineTo(400,180);
ctx.closePath();
ctx.stroke();
ctx.fill();

ctx.beginPath();
ctx.lineWidth = 5;
ctx.moveTo(0,180);
ctx.lineTo(400,180);
ctx.lineTo(400,500);
ctx.lineTo(0,500);
ctx.closePath();
ctx.stroke();
ctx.fill();


ctx.beginPath();
ctx.fillStyle = 'black';
ctx.moveTo(20,200);
ctx.lineTo(180,200);
ctx.lineTo(180,300);
ctx.lineTo(20,300);
ctx.closePath();
ctx.stroke();
ctx.fill();

ctx.beginPath();
ctx.strokeStyle = '#975B5B';
ctx.moveTo(19,250);
ctx.lineTo(181,250);
ctx.closePath();
ctx.stroke();

ctx.beginPath();
ctx.moveTo(100,199);
ctx.lineTo(100,301);
ctx.closePath();
ctx.stroke();

ctx.beginPath();
ctx.fillStyle = 'black';
ctx.strokeStyle = 'black';
ctx.moveTo(220,200);
ctx.lineTo(380,200);
ctx.lineTo(380,300);
ctx.lineTo(220,300);
ctx.closePath();
ctx.stroke();
ctx.fill();

ctx.beginPath();
ctx.strokeStyle = '#975B5B';
ctx.moveTo(149,250);
ctx.lineTo(391,250);
ctx.closePath();
ctx.stroke();

ctx.beginPath();
ctx.moveTo(300,199);
ctx.lineTo(300,301);
ctx.closePath();
ctx.stroke();

ctx.beginPath();
ctx.fillStyle = 'black';
ctx.moveTo(220,320);
ctx.lineTo(380,320);
ctx.lineTo(380,420);
ctx.lineTo(220,420);
ctx.closePath();
ctx.stroke();
ctx.fill();



ctx.beginPath();
ctx.strokeStyle = 'black';
ctx.moveTo(30,500);
ctx.lineTo(30,380);
ctx.quadraticCurveTo(75, 355, 120, 380);
ctx.lineTo(120,500);
ctx.stroke();

ctx.beginPath();
ctx.moveTo(75, 500);
ctx.lineTo(75, 368);
ctx.stroke();

ctx.beginPath();
ctx.arc(55,450,5,0,360*Math.PI/180);
ctx.stroke();




ctx.beginPath();
ctx.moveTo(280, 130);
ctx.lineTo(280, 40);
ctx.quadraticCurveTo(295, 32, 310,40);
ctx.lineTo(310, 130);
ctx.fillStyle = '#975b5b';
ctx.fill();
ctx.stroke();

ctx.beginPath();
ctx.arc(95,450,5,0,360*Math.PI/180);
ctx.stroke();

ctx.beginPath();
ctx.moveTo(280,40);
ctx.quadraticCurveTo(295, 48, 310,40);
ctx.stroke();

