(function() {
    Variables.$easyLevel.on('click', function() {
        Game.setLevel($(this).html());
    });

    Variables.$mediumLevel.on('click', function() {
        Game.setLevel($(this).html());
    });

    Variables.$hardLevel.on('click', function() {
        Game.setLevel($(this).html());
    });

    Variables.$submitBtn.on('click', function() {
        Game.checkNumberForMatching(Variables.$enterNumberField.val());
    });

    Variables.$okBtn.on('click', function() {
        Game.saveNickname(Variables.$nickname.val());
    });
}());