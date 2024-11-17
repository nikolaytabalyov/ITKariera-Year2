roundTo :: Double -> Int -> Double
roundTo x n = 
    let num = (fromInteger $ round $ x * (10^n)) / (10.0^^n)
    in num

areaOfCircle :: Double -> Double
areaOfCircle x =
    let area = x * x * pi
    in area

main = do
    input <- getLine
    let r = read input :: Double
    let area = areaOfCircle (r)
    let areaRounded = roundTo area 4
    print areaRounded
