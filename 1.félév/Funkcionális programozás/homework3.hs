module HomeWork3 where
--import TemplateHaskellQuotes hiding (evenSum)
indexOfArg :: Integer -> Integer -> Integer -> Integer
indexOfArg 0 _ _ = 1
indexOfArg _ 0 _ = 2
indexOfArg _ _ 0 = 3
indexOfArg _ _ _ = -1


evenSum :: Integer -> Integer -> Integer -> Bool
evenSum x y z = (x+y+z) `mod` 2 ==0

multiply :: Integer -> Integer -> Integer
multiply m 0 = 0
multiply m 1 = m
multiply m n = m +(multiply m (n-1))
