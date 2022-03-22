
fib :: Int -> Int
fib n
    | n == 0 || n == 1 = 1
    | otherwise = fib (n - 1) + fib (n - 2)


main = do
    print ([fib x | x <- [0..15]])
