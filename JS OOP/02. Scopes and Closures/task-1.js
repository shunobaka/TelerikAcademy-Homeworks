/* Task Description */
/* 
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 *	Add a new book to category
 *	Each book has unique title, author and ISBN
 *	It must return the newly created book with assigned ID
 *	If the category is missing, it must be automatically created
 *	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID
 *	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
 *	When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */
function solve() {
    var library = (function() {
        var books = [];
        var categories = [];

        function listBooks(params) {
            if (!params) {
                return books;
            } else {
                for (var param in params) {
                	books = books.filter(function(book) {
                		if (params[param] === book[param]) {
                			return book;
                		}
                	});
                }
                return books;
            }
        }

        function addBook(book) {
        	var containsCategory = false;
            if (book.title.length < 2 || book.title.length > 100) {
                throw new Error('The title is either too short or too long!');
            }
            for (var index = 0, len = books.length; index < len; index += 1) {
                if (books[index].title === book.title) {
                    throw new Error('Book with same title already exists!');
                }
                if (books[index].isbn === book.isbn) {
                	throw new Error('Book with same isbn already exists!');
                }
            }
            if ((book.isbn.length !== 10 && book.isbn.length !== 13) || (isNaN(+book.isbn))) {
                throw new Error('The isbn is not valid!');
            }
            if (book.author.trim().length < 1) {
                throw new Error('Not a valid autor!');
            }
            if (!book.category) {
                book.category = 'Drama';
            }
            for (index = 0, len = categories.length; index < len; index += 1) {
           		if (categories[index] === book.category) {
           			containsCategory = true;
           		}
            }
            if (!containsCategory) {
            	categories.push(book.category);
            }

            book.ID = books.length + 1;
            books.push(book);
            return book;
        }

        function listCategories() {
            return categories;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());

    return library;
}
module.exports = solve;
