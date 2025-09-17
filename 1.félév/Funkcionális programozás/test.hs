module Test where
x :: Int 
x = 3 


y :: Integer --ez a long (vicces)
y = 4

{- nagyon szép komment-}
-- nem lehet felüldefiniálni, viszont mindenre hivatkozhatsz mindenhol
ezjo :: Integer
ezjo = 3 + (-4)



--foo :: Int -> Int -> Char --kettő intet vár és egy karakterrel tér vissza


inc :: Int -> Int
--inc = undefined ilyenkor nem lesz belölle baj
inc x = x + 1 --baloldal a lesza  neve a paramnak. több param esetén többet irsz oda


double :: Int -> Int
double x = x * 2

sumold :: Int -> Int -> Int
sumold x y = x + y 

--fact n = prod [1..n]
