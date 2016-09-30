define(function() {
    var Task = (function() {
        function Task(title, content, id) {
            this.title = title;
            this.content = content;
            this.id = id;

            Task.prototype.setTitle = function(value) {
                this.title = value;
            };

            Task.prototype.getTitle = function() {
                return this.title;
            };

            Task.prototype.setContent = function(value) {
                this.content = value;
            };

            Task.prototype.getContent = function() {
                return this.content;
            };

            Task.prototype.getID = function() {
                return this.id;
            };
        }

        return Task;
    }());

    return Task;
});