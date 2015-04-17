var ctx = document.getElementById('canvas').getContext('2d');
function draw(text, x, y) {

    ctx.font = "48px Sans-serif";
    ctx.strokeStyle = 'green';
    ctx.lineWidth = 4;
    ctx.strokeText(text, x, y);
    ctx.fillStyle = 'pink';
    ctx.fillText(text, x, y);
}
draw("Bogomil", 55, 150);