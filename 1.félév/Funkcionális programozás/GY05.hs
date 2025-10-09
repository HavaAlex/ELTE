module GY05 where
import Prelude hiding (head,tail,last,genericLength,sum)


head :: [a] -> a --parciális mert üresre nincs definiciója (nem ennek ennek irtam hanem a beépitettnek)
head [] = undefined   --head [x] = x  --head [x,y] = x
head (x:xs) = x --legalább egy eleme van mert az xs lehet üres , 1tuti lesz a zh ba
--head (x:y:xs) = x --legalább 3 elemü

tail :: [a] -> [a] --parciális
tail [] = undefined
tail (x:xs) = xs


last :: [a] -> a --rekurtiós első elem levagdosos
last [] = undefined
last [x] = x 
last (x:xs) = last xs

sum :: [Double] -> Double
sum [] = 0
sum [x] = x
sum (x:xs) = x + sum xs 

genericLength :: [a] -> Integer
genericLength [] = 0
genericLength (x:xs) = 1 + genericLength xs

average :: [Double] -> Double
average [] = 0
average [x] = x
average x = sum x / fromIntegral (genericLength x) --  x = (x:xs) mert lehet ez igy egy lista