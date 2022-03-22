import Data.Char
import Text.Printf


wrap :: Char -> Char 
wrap c
    | c < 'a' = chr (ord c + 26)
    | c > 'z' = chr (ord c - 26)
    | otherwise = c

shift :: Char -> Int -> Char 
shift c n
    | isAlpha c = wrap (chr (ord c + n))
    | otherwise = c

encode :: String -> Int -> String 
encode str n = [shift c n | c <- str]

decode :: String -> Int -> String 
decode str n = encode str (-n)


main = do
    let plainText = "hello world"
    let key = 5
    printf "encode \"%s\" by %d\n" plainText key
    
    let encodedText = encode plainText key
    print encodedText
    let decodedText = decode encodedText key
    print decodedText
