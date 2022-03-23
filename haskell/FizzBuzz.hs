
isDiv x y
    | x == 0 = False
    | otherwise = mod x y == 0


fizzbuzz :: Int -> Int -> Int -> String
fizzbuzz x f b
    | isDiv x f && isDiv x b = "fizzbuzz"
    | isDiv x f = "fizz"
    | isDiv x b = "buzz"
    | otherwise = show x


main = print ([fizzbuzz x 2 5 | x <- [0..30]])
