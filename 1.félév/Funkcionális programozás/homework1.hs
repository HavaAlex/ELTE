module HomeWork1 where

--1
myFavouriteOneDigitNumber :: Int
myFavouriteOneDigitNumber = 8
--2
myFavouriteOneDigitNumbersEvilTwin  :: Int
myFavouriteOneDigitNumbersEvilTwin = myFavouriteOneDigitNumber * 2 + 13
--3
myFavouriteOneDigitNumbersAndTheirEvilTwinsDistantRelative :: Int -> Int
myFavouriteOneDigitNumbersAndTheirEvilTwinsDistantRelative x = myFavouriteOneDigitNumber * x + myFavouriteOneDigitNumbersEvilTwin * x * 3 - 2
--4 
isTheLastNumberTooLarge :: Int -> Int -> Int -> Bool
isTheLastNumberTooLarge x y z = 
    if z > x+y+100 then True
    else False
--5
isTheEvilDistantRelativeTooLargeForMyFavouriteOneDigitNumberAndItsEvilTwin :: Int -> Bool
isTheEvilDistantRelativeTooLargeForMyFavouriteOneDigitNumberAndItsEvilTwin x =
    if myFavouriteOneDigitNumbersAndTheirEvilTwinsDistantRelative x >myFavouriteOneDigitNumber+myFavouriteOneDigitNumbersEvilTwin+100 then True
    else False 
    