module Homework5 where
mountain :: Integer -> [Integer]
mountain n 
    | n <= 0 = []
    | n >= 1 = [1..n] ++ [(n-1),(n-2)..1]

signOfHead :: [Integer] -> Integer
signOfHead (x:xs) 
    | x>0 = 1
    | x<0 = -1
    | x==0 = 0

range :: [Integer] -> [Integer]
range [] = []
range [x] = [x..]
range [x,y] = [x,y..]
range (x:y:z:xs) =[x,y..z]

