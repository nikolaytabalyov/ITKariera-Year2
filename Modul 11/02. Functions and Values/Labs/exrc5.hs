factorial :: Int -> Int
factorial n
    | n == 0 || n == 1 = 1
    | otherwise = n * factorial (n-1)

