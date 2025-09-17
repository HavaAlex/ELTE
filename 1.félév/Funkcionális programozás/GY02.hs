module GY02 where
import Prelude hiding (not, (&&), (||),sum,product)
four = 4
veryTrue = True

sum :: Int -> Int -> Int
sum a b = a+b

product :: Int -> Int -> Int
product a b = a*b

averageOfTwoNumbers :: Float -> Float -> Float
averageOfTwoNumbers a b = (a+b)/2 