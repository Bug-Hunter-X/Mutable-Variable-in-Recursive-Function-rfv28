let mutable x = 0
let rec loop i = 
    if i > 10 then ()
    else (
        x <- x + i; 
        loop (i + 1)
    )
loop 1
printf "%d" x