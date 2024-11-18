evenCheck :: Int -> Bool
evenCheck n =
    if n `mod` 2 == 0
    then True
    else False
    
main = do
    input <- getLine
    let num = read input :: Int
    print (evenCheck num)