# fraction-cs
Abstraction for a Fraction (ratio of integers), in C#.

## What's this?
I'm trying to get a feel for C#, as someone who has spent
some time writing in C++.

This is pretty much an old project from my first year of CS,
which was originally written in Java -- now redone in C#.

Currently using `mono` to build.

## If you are running a Unix-based operating system...

Use the `makebuild` script to build the sources for `main.app`,<br>then you can invoke the `run` script, which does the following
in the terminal:

```
mono main.app dat/input.dat
```

## If you are running Microsoft Windows/using Visual Studio...

TODO instructions

# Original assignment that this repo is based off of

## Lab Assignment I - Review of Classes, Interfaces, File I/O, and Exception Handling

Consider a `class Fraction` of fractions.

Each fraction has a numerator and a denominator that are integers. 

- Your class should be able to add, subtract, multiply and divide two fractions. 

    - These methods should have a fraction as a parameter and should return the result of the operation as a fraction.<p>

- The class should also be able to find the reciprocal of a fraction, compare two fractions, decide whether two fractions are equal and have a toString defined to output a fraction. 

- Fractions should always occur in lowest terms, and the class is responsible for this requirement. 

    - For example, if the user tries to create a fraction such a 4/8, the class should set the fraction to 1/2. 

    - Likewise, the result of all arithmetic operations should be in lowest terms. 

    - To reduce a fraction such as 4/8 to lowest terms, you need to divide both the numerator and the denominator by their greatest common denominator (gcd). 

        - The greatest common denominator (gcd) of 4 and 8 is 4, so when you divide the numerator and denominator of 4/8 by 4, you get the fraction 1/2.<p>

- A fraction can also be improper, it can have a numerator that is larger than its denominator. Such a fraction however, should also be in lowest terms.

You will be given an `interface` that declares the functionality mentioned above.

## Instructions

### Implement a `Fraction`
- Write a `class` that implements the Fraction `interface` given. You will then use this class in an application program (driver). You will also have to add the following to your class: (50 points)
    - A reasonable constructor
    - Useful `private` methods such as a recursive gcd method to help reduce fractions to lowest terms
    - Methods that `override` the `equals` and `toString` methods that are inherited and defined in the `Object` class
    - Comments for your code<p>

### Write a client
- Write an application (driver) that creates an array of `Fraction` objects and demonstrates all the functionality of your Fractions class.  (50 points)
    - Assume an array of up to twenty (20) Fraction objects although you may have fewer than 20 fractions. 
    
        - You will read from an input file two integer numbers, the numerator and the denominator to create the Fraction object. Then add that Fraction object to the array. 
    
        - Have the user input the name of the input file to be used and read until end of file. An input file will be provided however, your application should work with any input file.

    - Provide exception handling
        - You may not assume that every line in the input file contains the expected data types. 
        
            - You are expecting two integers but you may not get this with every input line that is read. (There may be input mismatch exceptions.) 
        
            - If an input line contains an input mismatch exception, then catch and handle the exception. Handle the exception by skipping that line of input and counting the error. 
        
            - The incorrect line of input should not crash your program. At the end of the program output the number of errors found. 

                - Example: There were 5 lines of input skipped due to input mismatch exception.<p>

        - You may get the expected data types, two integers, however, you may not assume that the second integer which will represent the denominator is a correct value (non-zero). 
        
            - If the input line contains a zero as its second number, then throw, catch and handle this exception. 
            
            - Write your own exception class for this type of error. Again, the incorrect line of input should not crash your program. 
            
            - At the end of the program output the number of errors of this type found. 
            
                - Example: There were 5 lines of input skipped due to zero read as the denominator exception.<p>

- Once you have the array populated with fractions, complete the following tasks and send your results to an output file.<br> Make sure your output is clearly labeled and nicely formatted.
    - Output all the fractions in the array.

    - Add the fractions at index 0 and 1 in the array and output the result.

    - Subtract the fractions at index 2 and 3 in the array and output the result.

    - Divide the fractions at index 4 and 5 in the array and output the result.

    - Multiply the fractions at index 6 and 7 in the array and output the result.

    - Compare the fractions at index 8 and 9 in the array for equality and output the result.

    - Compare the fractions at index 1 and 10 in the array for equality and output the result.

    - Compare the fractions at index 2 and 4 in the array and output the result.

    - Output the reciprocal of the fraction at index 4 in the array.

## Submit the following
 - Your `Fraction` class that implements the Fraction `interface`
 - Your Fraction client/application
 - Your exception class
