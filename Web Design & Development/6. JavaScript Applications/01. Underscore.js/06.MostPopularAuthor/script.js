(function() {
    var mostPopularAuthor = {};
    var books = Books.initializeBooks;

    console.log('---------- All books ----------');
    printBooks(books);

    mostPopularAuthor = findMostPopularAuthor(books);
    console.log('---------- Most popular author ----------');
    console.log(mostPopularAuthor.name);
    printBooks(mostPopularAuthor.books);

    function findMostPopularAuthor(books) {
        var authors = {};
        var authorBooks = [];
        var mostPopularAuthor = {
            name: '',
            books: []
        };

        _.each(books, function (book) {
            if (authors[book.getAuthor()]) {
                authorBooks = authors[book.getAuthor()];
            }

            authorBooks.push(book);
            authors[book.getAuthor()] = authorBooks;
            authorBooks = [];
        });

        _.each(authors, function (booksOfAuthor) {
            if (booksOfAuthor.length > mostPopularAuthor.books.length) {
                mostPopularAuthor.name = booksOfAuthor[0].getAuthor();
                mostPopularAuthor.books = booksOfAuthor;
            }
        });

        return mostPopularAuthor;
    }

    function printBooks(books) {
        _.each(books, function(book) {
            console.log('Title: ' + book.getTitle() + ', Author: ' + book.getAuthor());
        });

        console.log('\n');
    }
}());