
customHead [] = error "empty"
customHead (x:xs) = x

customLength (x:xs) = customLength xs + 1
customLength [] = 0

customLast xs = xs !! (customLength xs - 1)

customLast1 :: [a0] -> a0
customLast1 [] = error "empty"
customLast1 (x:xs)
    | length xs == 1 = head xs
    | otherwise = customLast1 xs


main = do
    let myList = [5,4,32]
    print(customLast myList)
    print(customLast1 myList)
    print(customHead myList)
    print (customLength myList)
    
