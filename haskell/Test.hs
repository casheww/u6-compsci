
sq :: Int -> Int
sq x = x * x

main = print (foldr ((+) . sq) 0 [1,4,9])
