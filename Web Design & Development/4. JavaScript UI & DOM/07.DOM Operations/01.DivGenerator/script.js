window.onload = function () {
    var container = document.getElementById('container');
    var createDivBtn = document.getElementById('create-btn');
    var numberOfDivs = document.getElementById('number-of-divs');
    var documentFragment = document.createDocumentFragment();
    var divNumber = 1;

    createDivBtn.addEventListener('click', function () {
        for (var i = 1; i <= numberOfDivs.value; i++) {
            documentFragment.appendChild(onButtonClick(divNumber));
            divNumber++;
        }

        container.appendChild(documentFragment);

    }, false);
};

function onButtonClick (divNumber) {
    var div = document.createElement('div');
    div.style.width = getRandomNumber(20, 100) + 'px';
    div.style.height = getRandomNumber(20, 100) + 'px';
    div.style.backgroundColor = getRandomColor();
    div.style.color = getRandomColor();
    div.style.top = getRandomNumber(10, 500) + 'px';
    div.style.left = getRandomNumber(10, 500) + 'px';
    div.innerHTML = 'Div ' + divNumber;
    div.style.fontWeight = 'bold';
    div.style.border = getRandomNumber(1, 20) + 'px' + ' solid ' + getRandomColor();
    div.style.borderRadius = getRandomNumber(1, 30) + 'px';
    div.className = 'generated-div';

    return div;
}

function getRandomNumber (min, max) {
    return Math.floor(Math.random() * (max - min)) + min;
}

function getRandomColor () {
    var letters = '0123456789ABCDEF'.split('');
    var color = '#';

    for (var i = 1; i <= 6; i++ ) {
        color += letters[Math.floor(Math.random() * 16)];
    }

    return color;
}





