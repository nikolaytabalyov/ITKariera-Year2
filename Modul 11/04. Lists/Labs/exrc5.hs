fibonacciList :: Int -> [Int]
fibonacciList n =
  if n <= 0 then []
  else if n == 1 then [1]
  else if n == 2 then [1, 1]
  else
    let prev = fibonacciList (n - 1)
    in prev ++ [last prev + last (init prev)]