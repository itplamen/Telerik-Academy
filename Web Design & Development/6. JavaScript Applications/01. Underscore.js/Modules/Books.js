var Books = (function() {
    var Book = (function() {
        function Book(title, author) {
            this._firstName = title;
            this._lastName = author;
        }

        Book.prototype.getTitle = function() {
            return this._firstName;
        };

        Book.prototype.getAuthor = function() {
            return this._lastName;
        };

        return Book;
    }());

    var initializeBooks = (function() {
        var books = [
            new Book('Julius Caesar', 'William Shakespeare'),
            new Book('The Shining', 'Stephen King'),
            new Book('The Hobbit', 'J. R. R. Tolkien'),
            new Book('Romeo and Juliet', 'William Shakespeare'),
            new Book('The Adventures of Sherlock Holmes', 'Sir Arthur Conan Doyle'),
            new Book('The Three Musketeers', 'Alexandre Dumas'),
            new Book('Othello', 'William Shakespeare'),
            new Book('The Black Tulip', 'Alexandre Dumas'),
            new Book('The Hunger Games', 'Suzanne Collins'),
            new Book('Harry Potter and the Order of the Phoenix', 'J.K. Rowling'),
            new Book('The Lord of the Rings', 'J. R. R. Tolkien'),
            new Book('Twilight', 'Stephenie Meyer'),
            new Book('The Three Musketeers', 'Alexandre Dumas'),
            new Book('Doctor Sleep', 'Stephen King'),
            new Book('Hamlet', 'William Shakespeare'),
            new Book('Robin Hood', 'Alexandre Dumas'),
            new Book('King Lear ', 'William Shakespeare')
        ];

        return books;
    }());

    return {
        Book: Book,
        initializeBooks: initializeBooks
    };
}());