# F# Mutable Variable Bug

This repository demonstrates a common error in F#: using mutable variables inside recursive functions. While the code works, it deviates from F#'s functional paradigm, making it harder to understand and maintain.  The solution showcases a more functional approach using immutable data and recursion.

## Bug
The file `bug.fs` contains the original code which uses a mutable variable (`x`)  within a recursive function. This can lead to subtle and difficult-to-debug issues in more complex programs. 

## Solution
The file `bugSolution.fs` shows a solution that replaces the mutable variable with an accumulator parameter, creating a purely functional recursive function. This approach improves code readability, maintainability, and reduces the risk of errors.