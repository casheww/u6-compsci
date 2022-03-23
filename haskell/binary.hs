
processBit :: Int -> Int -> Int
processBit dec bit
    | bit == 0 = dec * 2
    | otherwise = dec * 2 + 1

binToDec :: [Int] -> Int
binToDec = foldl processBit 0


decToBin :: Int -> [Int]
decToBin dec
    | dec == 0 = []
    | otherwise = do
        let d = dec `div` 2
        let r = dec `mod` 2
        decToBin d ++ [r]


main = do
    let dec = 196
    print ("dec : " ++ show dec)
    let bin = decToBin dec
    print("bin : " ++ show bin)
    print("dec check : " ++ show (binToDec bin))
