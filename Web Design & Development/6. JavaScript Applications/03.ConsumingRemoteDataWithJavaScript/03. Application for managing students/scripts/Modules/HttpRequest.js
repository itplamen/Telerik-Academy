var HttpRequest = (function() {
    var httpRequest = function(url, type, data) {
        var $deferred = $.Deferred();

        function stringifyData(data) {
            if (data) {
                return JSON.stringify(data);
            }
        }

        $.ajax({
            url: url,
            type: type,
            data: stringifyData(data),
            contentType: 'application/json',
            timeout: 5000,
            success: function(data) {
                $deferred.resolve(data);
            },
            error: function(error) {
                $deferred.reject(error);
            }
        });

        return $deferred.promise();
    };

    function getJSON(url) {
        return httpRequest(url, 'GET');
    }

    function postJSON(url, data) {
        return httpRequest(url, 'POST', data);
    }

    function deleteJSON(url) {
        return httpRequest(url, 'DELETE');
    }

    return {
        getJSON: getJSON,
        postJSON: postJSON,
        deleteJSON: deleteJSON
    };
}());