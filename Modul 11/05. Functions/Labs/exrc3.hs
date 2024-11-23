compressList :: [Int] -> [Int]
compressList list = foldl removeDuplicate [] list

removeDuplicate :: [Int] -> Int -> [Int]
removeDuplicate list nextN =
    if null list then [nextN]
    else if head list == nextN then list
    else list ++ [nextN]