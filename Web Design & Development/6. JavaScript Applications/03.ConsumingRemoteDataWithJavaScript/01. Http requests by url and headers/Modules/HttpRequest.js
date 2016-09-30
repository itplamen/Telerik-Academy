var HttpRequest = (function() {
    var headers, httpRequest;

    headers = {
        Accept: 'text/html'
    };

    httpRequest = function(url, type, headers, data) {
        var $deferred = $.Deferred();

        function stringifyData(data) {
            if (data) {
                return JSON.stringify(data);
            }
        }

        $.ajax({
            url: url,
            type: type,
            headers: headers,
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
        return httpRequest(url, 'GET', headers);
    }

    function postJSON(url, data) {
        return httpRequest(url, 'POST', headers, data);
    }

    return {
        getJSON: getJSON,
        postJSON: postJSON
    };
}());