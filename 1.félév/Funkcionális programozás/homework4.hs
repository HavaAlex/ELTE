module HomeWork4 where
strangeSum:: Integer -> Integer
strangeSum x | x<1 = x+1
strangeSum x = (x^2)+1 + strangeSum (x-1)


totalFactorial :: Integer -> Integer
totalFactorial x 
    | x<0 = 0
    | x == 1 = x
    | x > 1 = x * totalFactorial (x-1)

areaOfCircle :: Double -> Double
areaOfCircle r = (r^2) * pi