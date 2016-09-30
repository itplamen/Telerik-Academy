var Game = (function() {
    var selectedLevel = '', numberOfShots = 0, DIGITS_IN_NUMBER = 4, generatedNumber = '', endGameStatus = '';

    function generateRandomNumber() {
        var generatedNumber = '', digit = 0;

        while (generatedNumber.length !== DIGITS_IN_NUMBER) {
            digit = Math.round((Math.random() * 9) + 0);

            if (generatedNumber.length === 0 && digit === 0) {
                digit = 0;
            }
            else if (!isNumberContainsDigit(generatedNumber, digit)) {
                generatedNumber += digit;
            }
        }

        return generatedNumber;
    }

    function isNumberContainsDigit(number, digit) {
        return number.indexOf(digit) !== -1;
    }

    function setLevel(level) {
        selectedLevel = level;
        initializeGame();
    }

    function initializeGame() {
        if (selectedLevel) {
            if (selectedLevel === 'Easy') {
                numberOfShots = 15;
            }
            else if (selectedLevel === 'Medium') {
                numberOfShots = 10;
            }
            else if (selectedLevel === 'Hard') {
                numberOfShots = 5;
            }

            Variables.$levelsBox.css('display', 'none');
            Variables.$resultFromGuessingBox.css('display', 'block');
            Variables.$statusBox.css('display', 'block');
            Variables.$inputNumberBox.css('display', 'block');
            Variables.$selectedLevel.html(Variables.$selectedLevel.html() + selectedLevel);
            Variables.$shots.html(Variables.$shots.html() + numberOfShots);
            generatedNumber = generateRandomNumber();
        }
    }

    function checkNumberForMatching(enteredNumber) {
        var bulls = 0, cows = 0;

        if (isEnteredNumberValid(enteredNumber)) {
            for (var i = 0; i < enteredNumber.length; i++) {
                for (var j = 0; j < generatedNumber.length; j++) {
                    if (enteredNumber[i] === generatedNumber[j]) {
                        if (i === j) {
                            bulls += 1;
                        }
                        else {
                            cows += 1;
                        }
                    }
                }
            }

            addResultToResultBox({
                bulls: bulls,
                cows: cows
            }, enteredNumber);

            updateNumberOfShots();

            if (numberOfShots === 0 || bulls === 4) {
                Variables.$resultFromGuessingBox.css('display', 'none');
                Variables.$statusBox.css('display', 'none');
                Variables.$inputNumberBox.css('display', 'none');
                Variables.$gameEndBox.css('display', 'block');
                Variables.$generatedNumber.html(Variables.$generatedNumber.html() + generatedNumber);

                if (numberOfShots === 0) {
                    endGameStatus = 'Lose';
                }
                else if (bulls === 4) {
                    endGameStatus = 'Win';
                }

                Variables.$gameEndStatus.html('You ' + endGameStatus + '!');
            }
        }
    }

    function isEnteredNumberValid(enteredNumber) {
        if (!(/^\d+$/).test(enteredNumber)) {
            Variables.$message.html('Message: Error: Number must contains only digits!');
            return false;
        }
        else if (enteredNumber.length !== DIGITS_IN_NUMBER) {
            Variables.$message.html('Message: Error: Number cannot contains less or more than ' + DIGITS_IN_NUMBER + ' digits!');
            return false;
        }
        else if (!isNumberContainsDifferentDigits(enteredNumber)) {
            Variables.$message.html('Message: Error: Number must contains different digits!');
            return false;
        }

        Variables.$message.html('Message: ');
        return true;
    }

    function isNumberContainsDifferentDigits(enteredNumber) {
        var number = enteredNumber;

        for (var i = 0; i < enteredNumber.length; i++) {
            for (var j = 0; j < number.length; j++) {
                if ((j !== i) && (enteredNumber[i] === number[j])) {
                    return false;
                }
            }
        }

        return true;
    }

    function addResultToResultBox(result, enteredNumber) {
        var $result = $('<p class="result"/>')
            .html(enteredNumber + ' -> ' + 'Bull(s): ' + result.bulls + ', Cow(s): ' + result.cows);

        Variables.$resultFromGuessingBox.append($result);
    }

    function updateNumberOfShots() {
        numberOfShots -= 1;
        Variables.$shots.html('Shots: ' + numberOfShots);
    }

    function isNicknameValid(nickname) {
        if (nickname === null || nickname === '') {
            alert('Invalid nickname!');
            return false;
        }

        return true;
    }

    function saveNickname(nickname) {
        if (isNicknameValid(nickname)) {
            var key = nickname;
            var value = 'Number: ' + generatedNumber + ', Status: ' + endGameStatus;
            localStorage.setItem(key, value);
            Variables.$okBtn.prop('disabled', true);
            alert('Your nickname was saved successfully!');
        }
    }

    return {
        setLevel: setLevel,
        checkNumberForMatching: checkNumberForMatching,
        saveNickname: saveNickname
    };
}());

