
isDiv x y
    | x == 0 = False
    | otherwise = mod x y == 0

findFactors :: Int -> [Int]
findFactors n = [x | x<-[2..(ceiling (sqrt (fromIntegral n)))], isDiv n x]

isPrime :: Int -> Bool
isPrime n = null (findFactors n)

getPrimes :: Int -> [Int]
getPrimes max = [n | n <- [2..max], isPrime n]


main = do
    let x = -10
    print(getPrimes 20000)
