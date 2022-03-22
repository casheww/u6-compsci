

main = do  
    let isPrime = True
    let var = 23 
    if var == 2 || var  == 3 then
        let isPrime = True
    
   if var <= 1 || var `mod` 2 == 0 || var `mod` 3 == 0 then
      let isPrime = False
   checkValues var 5