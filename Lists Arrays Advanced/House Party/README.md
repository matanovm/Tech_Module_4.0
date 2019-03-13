#House Party

Write a program that keeps track of guests, that are going to a house party. On the first line of input, you are going to receive the number of commands you are going to receive. On the next lines you are going to receive one of the following messages:
-	"{name} is going!"
-	"{name} is not going!"

If you receive the first message, you have to add the person if he/she is not in the list and if he/she is in the list print on the console: "{name} is already in the list!". If you receive the second message, you have to remove the person if he/she is in the list and if not print: "{name} is not in the list!". At the end print all the guests.

##Examples

>input

    5
    Tom is going!
    Annie is going!
    Tom is going!
    Garry is going!
    Jerry is going!

>Output

    Tom is already in the list!
    Tom
    Annie
    Garry
    Jerry
