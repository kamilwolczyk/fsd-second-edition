function gateClickEventHandler(event) {
    const COUNT_ATTRIBUTE = 'data-count';
    const gate = event.target;
    let count = gate.getAttribute(COUNT_ATTRIBUTE);
    count = parseInt(count, 10) + 1;

    gate.setAttribute(COUNT_ATTRIBUTE, count);
    gate.querySelector('span').innerText = count;

    addNewLog(`Kliknieto bramke numer ${gate.getAttribute('id')}`);
}

function initializeCounter() {
    document.querySelectorAll('.gate').forEach(function (item) {
        item.addEventListener('click', gateClickEventHandler);
    });
}

initializeCounter();