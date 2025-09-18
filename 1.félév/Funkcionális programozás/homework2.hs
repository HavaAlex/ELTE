module HomeWork2 where



not' :: Bool -> Bool
not' True = False
not' False = True


xnor :: Bool -> Bool -> Bool
xnor True True = True
xnor False False = True
xnor _ _ = False

xor3 :: Bool -> Bool -> Bool -> Bool
xor3 True True True = True
xor3 True False False = True
xor3 False True False = True
xor3 False False True = True
xor3 _ _ _ = False

allSame :: Bool -> Bool -> Bool -> Bool
allSame True True True = True
allSame False False False = True
allSame _ _ _ = False
--allSame x y z = (x==y) && (x==z) 

exactlyOneTrue :: Bool -> Bool -> Bool -> Bool
exactlyOneTrue True False False = True
exactlyOneTrue False True False = True
exactlyOneTrue False False True = True
exactlyOneTrue _ _ _ = False

deleteIf :: Char -> Bool -> Char
deleteIf x True = ' '
deleteIf x False = x

swapTabSpace :: Char -> Char
swapTabSpace ' ' = '\t'
swapTabSpace '\t' = ' ' 
swapTabSpace x = x

switchTabSpace :: Char -> Char
switchTabSpace ' ' = '\t'
switchTabSpace '\t' = ' ' 
switchTabSpace x = x