--Опашкова рекурсия Факториел

findFactorialLoop :: Int -> Int -> Int -> Int
findFactorialLoop n initValue index =
    if index > n then initValue
    else findFactorialLoop n (initValue*index) (index+1)

findFactorial n = findFactorialLoop n 1 1