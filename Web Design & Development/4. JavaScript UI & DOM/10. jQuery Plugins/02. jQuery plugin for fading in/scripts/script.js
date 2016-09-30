(function($) {
    $.fn.messageBox = function(messageText, messageType) {
        var $this = $(this),
            $message = $('<div/>'),
            type = messageType.toLowerCase(),
            SUCCESS_TYPE = 'success',
            EMAIL_CHECK_TYPE = 'email-check',
            PASSWORD_CHECK_TYPE = 'password-check',
            ERROR_TYPE = 'error',
            fadeInTime = 0,
            fadeOutTime = 0;

        switch (messageType) {
            case SUCCESS_TYPE:
                fadeInTime = 500;
                fadeOutTime = 1500;
                break;
            case EMAIL_CHECK_TYPE:
                fadeInTime = 700;
                fadeOutTime = 2000;
                break;
            case PASSWORD_CHECK_TYPE:
                fadeInTime = 1000;
                fadeOutTime = 2500;
                break;
            case ERROR_TYPE:
                fadeInTime = 1500;
                fadeOutTime = 3000;
                break;
            default:
                throw new Error('Invalid message type!');
                break;
        }

        $message
            .attr('class', messageType + '-message')
            .html(messageText)
            .hide();

        $this.append($message).show();

        setTimeout(function() {
            $message.fadeIn(fadeInTime, 'linear');
            setTimeout(function() {
                $message.fadeOut(fadeOutTime, 'linear');
                setTimeout(function() {
                   $message.remove();
                }, fadeOutTime)
            }, fadeOutTime);
        }, fadeInTime);

        return this;
    };
}(jQuery));