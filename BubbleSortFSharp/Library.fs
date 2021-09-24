namespace BubbleSortFSharp

module BubbleSortF =
    let rec sort (a: int []) =
      let mutable fin = true
      for i in 0..a.Length-2 do
        if a.[i] > a.[i+1] then
          let t = a.[i]
          a.[i] <- a.[i+1]
          a.[i+1] <- t
          fin <- false
      if not fin then sort a
