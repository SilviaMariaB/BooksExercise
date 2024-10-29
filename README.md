# ExercisesOOP
/*
 * Create an Author class
    * Properties:
        * name
        * email
        * gender (Extra: make Gender into a enum)
    * Constructor to initialise properties
    * Override toString to give formatted output
 * 
 * Create a Book class
    * Properties:
        * name
        * author
        * price
        * quantity (default this to 0)
    * Constructor to initialise properties:
        * One for all properties but quantities 
        * Another for all AND quantity property
        * call the other constructor to avoid duplicate code
    * Override toString to give formatted output
 * 
 * Create a Person class
    * Properties:
        * name
        * list of books, not array, why not?
    * Constructor to initialise properties
        * One for just name, no books
        * One for name and list of books
            * Call base name only constructor (avoid duplicate code)
        * One for name and a singular book
            * Call base name only constructor (avoid duplicate code)
    * Override toString to give formatted output
 *   
 * Main:
    * Create and initialise an Author
    * Create and initialise 3 books (assign new author to them)
    * Print them out to validate
    * Create and initialise a Person (assign new book)
    * Make a new list of 3 books
    * Update previous Person to use the new book list
    * Iterate through the list of a persons book and output them all
*/
