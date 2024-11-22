printRowLoop :: Int -> String -> Int -> String
printRowLoop n result index = 
    if index > n then result
    else printRowLoop n (result ++ "*") (index + 1)

printRow :: Int -> String
printRow n = printRowLoop n "" 1

printTriangleLoop :: Int -> IO()
printTriangleLoop n  =
    if n == 0 then return ()
    else do
        putStrLn (printRow n)
        printTriangleLoop (n - 1)

printTriangle :: Int -> IO()
printTriangle n = printTriangleLoop n