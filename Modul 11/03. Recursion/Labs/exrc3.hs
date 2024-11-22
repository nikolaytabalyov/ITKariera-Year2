--Опашкова рекурсия Fibonacci

findFibonacciLoop :: Int -> Int -> Int -> Int -> Int
findFibonacciLoop n initValue prev index =
    if index >= n then initValue
    else findFibonacciLoop n (initValue+prev) initValue (index+1)

findFibonacci n = findFibonacciLoop n 1 0 1