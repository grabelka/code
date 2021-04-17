var name = prompt("What's your name?", "human")
if (name != "" && name != "null"){
    alert('Hello, ' + name)
}
var pets = []
pets[0] = "dog"
pets[4] = "frog"
pets[2] = "cat"
pets[1] = "bear"
pets[3] = "bird"
var check = true
function changeColor() {
    if(check) {
        document.body.style.backgroundColor = "lightgreen"
        check = false
    }
    else{
        document.body.style.backgroundColor = "purple"
        check = true
    }
}
function changeColorRed() {
    document.getElementById("t").style.backgroundColor = "coral"
}