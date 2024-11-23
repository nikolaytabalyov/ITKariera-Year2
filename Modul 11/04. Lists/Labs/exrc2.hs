lengthOfListLoop :: [a] -> Int -> Int
lengthOfListLoop list curLength =
    if null list then curLength
    else lengthOfListLoop (tail list) (curLength + 1)

lengthOfList :: [a] -> Int
lengthOfList list = lengthOfListLoop list 0