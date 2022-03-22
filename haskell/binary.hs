
decToBin :: Int -> [Int]
decToBin x = [0]


double x = x * 2

binToDec :: [Int] -> Int
binToDec = foldr (*) 2


main = do
    print(decToBin 10)
