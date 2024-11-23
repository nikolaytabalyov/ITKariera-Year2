generateMathExpression :: [Int] -> String
generateMathExpression list = foldl formatStringToMath "" list 

formatStringToMath :: String -> Int -> String
formatStringToMath str n = 
    if null str then show n 
    else "(" ++ str ++ "+" ++ show n ++ ")"