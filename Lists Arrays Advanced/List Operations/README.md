<h1>	List Operations</h2>

You will be given a list of integer numbers on the first line of input. You will be receiving operations you have to apply on the list until you receive the "End" command. The possible commands are:

•	Add {number} – add number at the end.

•	Insert {number} {index} – insert number at given index.

•	Remove {index} – remove at index.

•	Shift left {count} – first number becomes last ‘count’ times.

•	Shift right {count} – last number becomes first ‘count’ times.

Note: there is a possibility that the given index is outside of the bounds of the array. In that case print "Invalid index"

<h2>Examples</h2>

> Input

    1 23 29 18 43 21 20
    Add 5
    Remove 5
    Shift left 3
    Shift left 1
    End

> Output

    43 20 5 1 23 29 18
