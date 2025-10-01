module GY04 where
import Prelude hiding (abs,signum)

-- Definiáljuk azt a fv.-t ami egy szám abszolút értékét adja vissza
abs :: Integer -> Integer
abs x 
    | x<0 = -x
    | otherwise = x

-- előző órai def
divides :: Integer -> Integer -> Bool
divides x y = y `mod` x == 0

-- Használjuk az abs és divides fv.-ket arra, hogy definiáljuk azt a fv.-t ami igazat ad vissza, ha az első szám valódi osztója a másodiknak (előző órán csak a pozitívakat adtuk vissza)
trueIsRealDivisorOf :: Integer -> Integer -> Bool
trueIsRealDivisorOf x y = not(x == y) && not(y==0) && abs(x) `divides` abs(y)


-- Definiáljuk azt a fv.-t ami az előjelét adja vissza egy számnak (matekból ismerős szignum)
signum :: Integer -> Integer
signum x 
    | x>0 = 1
    | x==0 = 0
    | x<0 = -1

-- REKURZÍVAN adjuk össze a két szám közötti számokat (beleértve a két számot magát is) 
sumBetween :: Integer -> Integer -> Integer
sumBetween x y 
   | x == y = x
   | otherwise = x + sumBetween (x+1) y

-- gömb térfogat
volumeOfASphere :: Double -> Double
volumeOfASphere x = ((4*(x*x*x)*pi) / 3)

-- másodfokú egyenlet gyökeinek száma
numOfSolutions :: Integer -> Integer -> Integer -> Integer
numOfSolutions a b c 
    | (b*b)-4*a*c > 0 = 2
    | (b*b)-4*a*c == 0 = 1
    | (b*b)-4*a*c < 0 = 0

--https://en.wikipedia.org/wiki/Leibniz_formula_for_%CF%80
leibniz = undefined --nem megy :(

nthLeibniz = undefined