define(function() {
    function areAllFieldsFilled($title, $content) {
        if($title.val() === '') {
            changeFieldStyle($title);
        }
        else {
            changeFieldStyleToDefault($title);
        }

        if($content.val() === '') {
            changeFieldStyle($content);
        }
        else {
            changeFieldStyleToDefault($content);
        }

        if ($title.val() !== '' && $content.val() !== '') {
            return true;
        }
    }

    function changeFieldStyle($field) {
        $field.css({
            'border-color': 'red',
            'opacity': 0.7,
            'box-shadow': '1px 1px 13px red'
        });
    }

    function changeFieldStyleToDefault($field) {
        $field.removeAttr('style');
    }

    return {
        areAllFieldsFilled: areAllFieldsFilled
    };
});