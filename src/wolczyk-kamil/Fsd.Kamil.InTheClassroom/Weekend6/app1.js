function setTwoDigits(value) {
    return value > 9 ? value : `0${value}`;
}

function addNewLog(message){
    var list = document.getElementById('log'); //<ul></ul>
    var newItem = document.createElement('li'); //<li></li>
    newItem.innerText = message;
    list.appendChild(newItem);
}

function displayTime() {
    const date = new Date(),
        hoursNode = document.getElementById('hours'),
        minutesNode = document.getElementById('minutes'),
        secondsNode = document.getElementById('seconds');

    hoursNode.innerText = setTwoDigits(date.getHours());
    minutesNode.innerText = setTwoDigits(date.getMinutes());
    secondsNode.innerText = setTwoDigits(date.getSeconds());

    //addNewLog(`${date}`);
    //todo: add new item to the log container
}

function initializeTimer() {
    displayTime();
    setInterval(displayTime, 1000);
}

initializeTimer();