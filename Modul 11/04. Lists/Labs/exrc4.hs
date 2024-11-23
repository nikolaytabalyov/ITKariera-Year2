removeNthElement list n = 
    if null list then []
    else 
        let (left, right) = splitAt (n-1) list
        in left ++ tail right