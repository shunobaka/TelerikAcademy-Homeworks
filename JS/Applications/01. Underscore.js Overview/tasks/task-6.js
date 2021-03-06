/* 
Create a function that:
*   **Takes** a collection of books
    *   Each book has propeties `title` and `author`
        **  `author` is an object that has properties `firstName` and `lastName`
*   **finds** the most popular author (the author with biggest number of books)
*   **prints** the author to the console
	*	if there is more than one author print them all sorted in ascending order by fullname
		*   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
  	return function (books) {
  		var maxBooksByAuthor = 0;
  		_.chain(books)
  			.sortBy(function(book) {
  				var authorFullName = book.author.firstName + ' ' + book.author.lastName;
  				return authorFullName;
  			})
  			.groupBy(function(book) {
  				var authorFullName = book.author.firstName + ' ' + book.author.lastName;
  				return authorFullName;
  			})
  			.each(function(value) {
  				if (value.length > maxBooksByAuthor) {
  					maxBooksByAuthor = value.length;
  				}
  			})
  			.each(function(value, key) {
  				if (value.length == maxBooksByAuthor) {
  					console.log(key);
  				}
  			});
  	};
}

module.exports = solve;
