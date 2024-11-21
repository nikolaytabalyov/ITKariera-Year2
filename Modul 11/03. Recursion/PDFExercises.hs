--Sum of first 10 natural numbers

sum10Nums :: Int
sum10Nums = sum10NumsLoop 0 1 

sum10NumsLoop :: Int -> Int -> Int
sum10NumsLoop sum i =
    if i > 10
    then sum
    else (sum + i) + sum10NumsLoop sum (i+1)

--Repeat string (Опашкова рекурсия)
repeatString :: String -> Int -> String
repeatString string n = repeatStringLoop string string n

repeatStringLoop :: String -> String -> Int -> String
repeatStringLoop string result n =
    if n == 0
        then result
    else repeatStringLoop string (result ++ string) (n - 1)