function solve(){
    var inputValue = document.getElementById('mail').value;
    var isValid = inputValue.match(/[_a-zA-Z0-9-]+(\.[_a-zA-Z0-9-]+)*@[a-z0-9-]+(\.[a-zA-Z0-9-]+)*(\.[a-zA-Z]{2,4})/g);
    if (isValid != null) {
        document.getElementById('output').innerHTML = inputValue;
        document.getElementById('output').style.display = 'block';
        document.getElementById('output').style.backgroundColor = '#00ff00';
    } else {
        document.getElementById('output').innerHTML = inputValue;
        document.getElementById('output').style.display = 'block';
        document.getElementById('output').style.backgroundColor = '#ff0000';
    }
}
