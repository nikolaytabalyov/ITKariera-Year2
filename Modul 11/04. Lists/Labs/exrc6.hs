factorialListLoop :: Int -> Int -> [Int] -> [Int]
factorialListLoop n index result =
    if n == 0 then []
    else if index >= n then result
    else factorialListLoop n (index + 1) (result ++ [last result * index]) 

factorialList :: Int -> [Int]
factorialList n = factorialListLoop n 1 [1]
