main :: IO ()
main = do
    putStrLn "Enter first number."
    firstInput <- getLine 
    let firstNum = read firstInput :: Int
    putStrLn "Enter second number."
    secondInput <- getLine 
    let secondNum = read secondInput :: Int
    let result = firstNum * secondNum
    print ("The result is " ++ show result)
