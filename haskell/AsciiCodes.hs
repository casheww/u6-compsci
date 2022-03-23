import Data.Char (ord)
import SimpleBinary (decToBin)
import Data.List (intersperse, intercalate)


getAsciiBin :: Char -> String
getAsciiBin c = concatMap show (decToBin (ord c)) ++ " "


strToAscii :: String -> String
strToAscii = concatMap getAsciiBin


main = print (strToAscii "hello world")
