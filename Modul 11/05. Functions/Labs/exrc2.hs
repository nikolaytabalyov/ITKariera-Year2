generateMathExpression :: [Int] -> String
generateMathExpression list = foldr formatStringToMath "" list 

formatStringToMath :: Int -> String -> String
formatStringToMath n str = 
    if null str then show n 
    else "(" ++ show n ++ "+" ++ str  ++ ")"