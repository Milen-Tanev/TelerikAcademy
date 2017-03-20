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

	class Book {
		constructor(ID, title, author, isbn, category){
            this.ID = ID;
			if(title.length < 2 || title.length > 100) {
				throw new Error();
			} else {
				this.title = title;			
			}
			this.author = author;
            if(isbn.length === 10 || isbn.length === 13) {
				this.isbn = isbn;	
			} else {
				throw new Error();		
			}        
			if(category.length < 2 || category.length > 100) {
				throw new Error();
			} else {
				this.category = category;		
			}
		}
	}

	var library = (function () {
		var books = [];
		var categories = [];
		function listBooks(args) {
			if(args && args.author) {
				return books.filter(function (el) {  
					return el.author === args.author;
				});
			} else if(args && args.category) {
				return books.filter(function (el) {
					return el.category === args.category;
				});
			} 
			return books;
		}

		function addBook(book) {
            let ID = books.length + 1;
            let newBook = new Book(ID, book.title, book.author, book.isbn, book.category);
            if(newBook.title.length < 2 || newBook.title.length > 100) {
				throw new Error();
			}
			books.forEach(function (el) {
			    if(el.title.toLowerCase() === book.title.toLowerCase()) {
					throw new Error();
				}
			});
			books.forEach(function (el) {
				if(el.isbn.toLowerCase() === book.isbn.toLowerCase()) {
					throw new Error();
				}
			});


			if(categories.indexOf(book.category) < 0){
				categories.push(book.category);
			}

            books.push(newBook);
			
            return newBook;
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
	} ());
	return library;
}
module.exports = solve;
