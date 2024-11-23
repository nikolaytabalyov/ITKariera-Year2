reverseListLoop :: [a] -> [a] -> [a]
reverseListLoop list reversed =
    if null list then reversed
    else reverseListLoop (tail list) (head list : reversed)

reverseList :: [a] -> [a]
reverseList list = reverseListLoop list []