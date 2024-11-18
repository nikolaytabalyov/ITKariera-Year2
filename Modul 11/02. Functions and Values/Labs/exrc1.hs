doubleNum :: Double -> Double
doubleNum n = 
    let result = n * 2
    in result

main = do
    input <- getLine
    let num = read input :: Double
    let doubled = doubleNum num
    print doubled