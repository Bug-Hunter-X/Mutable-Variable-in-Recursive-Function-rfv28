let rec loop i acc = 
    if i > 10 then acc
    else loop (i + 1) (acc + i)
let result = loop 1 0
printf "%d" result