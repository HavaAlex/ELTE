module GY03 where
------------------------------------
-- Gyakorlás
------------------------------------

-- Definiáljuk azt a fv-t, ami megcseréli a @ és # jeleket, minden mást nem változtat
switchAtSignWithHashtag :: Char -> Char
switchAtSignWithHashtag '@' = '#'
switchAtSignWithHashtag '#' = '@'
switchAtSignWithHashtag x = x

-- Definiáljuk mintaillesztéssel azt a függvényt, amely a 3. Bool paraméter megfordítottját adja vissza, ha az első 2 Bool paraméter megegyezik, más esetben változatlanul adjuk vissza a 3. paramétert
flipIfFirstTwoAreSame :: Bool -> Bool -> Bool -> Bool
flipIfFirstTwoAreSame True True x = not(x)
flipIfFirstTwoAreSame False False x = not(x)
flipIfFirstTwoAreSame y z x = x

-- A klasszikus matematikai logikai műveletek segítségével (not, ||, &&) állítsuk elő az implikáció (⟹)-t leíró fv-t
implies :: Bool -> Bool -> Bool
implies x y = (x == y) || ((x==False) && (y==True)) --(not x || y)

-- Tegyük meg ugyanezt most a klasszikus mat. logikai műveletek NÉLKÜL, mintaillesztést használva
implies' :: Bool -> Bool -> Bool
implies' True False = False
implies' _ _ = True
-- Definiáljuk azt a fv-t, ami eldönti egy Int-ről, hogy páros-e (hint: használjuk az osztási maradék (mod) prefix függvényt infix módon)
isEven :: Int -> Bool
isEven x = x `mod` 2 ==0 -- mod x 2 == 0 ugyanaz

-- Definiáljuk azt a fv-t, ami eldönti, hogy az első paraméter osztója-e a másodikna
divides :: Int -> Int -> Bool
divides x y = mod x y == 0 

----------------------------------
-- Guardok (őrjelek)
----------------------------------
{-
Megtanultunk mintailleszteni Char-okra és Bool-okra. Picit gondolkodjunk ezeknek a típusoknak a számosságán (multiplicitásán):
A Bool-ra nagyon könnyen tudtunk mintát illeszteni, hiszen kétféle értéket vehet fel.
A Char-nál már egy picit összetettebb a helyzet, de még mindig véges számú lehetséges érték van.

Mi a helyzet a számoknál? Nézzük meg:
-}
-- Definiáljuk azt a fv-t, ami a 10-nél kisebb nemnegatív egész számokra True-t ad vissza, minden másra False-t
isOneDigit :: Int -> Bool
isOneDigit = undefined

-- Ez mégsem olyan jó, használjuk picit az agytekervényeinket (és logikai műveleteket):
isOneDigit' :: Int -> Bool
isOneDigit' x = x<10 && x>=0


-- Definiáljuk azt a fv-t, ami a 100-nál kisebb nemnegatív egész számokra ad True-t, minden másra False-t
isLessThanHundred :: Int -> Bool 
isLessThanHundred  x = x<100 && x>=0

-- Ügyesen kihasználtuk a Bool műveletek tulajdonságait, de mitévők leszünk, ha nem Bool visszatérésű a fv?

-- Definiáljuk azt a fv-t, amit pozitív számokra értelmezünk (minden más esetben 'E'-t írjunk ki, mint "error"),
-- 1 - 9:       I
-- 10 - 99:     X
-- 100 - 999:   C
-- 1000 - 3999: M
romanOrderOfMagnitude :: Int -> Char 
romanOrderOfMagnitude x
    | x>=1 && x<=9 = 'I'
    | x>=10 && x<=99 = 'X'
    | x>=100 && x<=999 = 'C'
    | x>=1000 && x<=3999 = 'M'
    | otherwise = 'E'
-- A gyakorlórészben megírt divides függvényt fejlesztjük tovább, most már csak a valódi osztókat fogadjuk el (tehát 1 és önmaga már False-t dobjon)
isRealDivisorOf :: Int -> Int -> Bool
isRealDivisorOf x y = (mod x y == 0)&&not(x == y) && not(y==0)
   -- | x == 1 = False
   -- | x == y = False
   -- otherwise = x `divides` y

   -- | x==1 || x == y = False
   -- otherwise = x `divides` y
{-
Használjuk egy új nyelvi elemet, a guard-ot (őrjel) az AltGr + W kombinációval elérhető | ("pipe") szimbólummal.
Ilyenkor nem tesszük ki az egyenlőségjelet azonnal, hanem új sorban egy tab-bal behúzva kezdjük a guardot.

A guardok nagyon hasznos eszközök, az ilyen típusú feladatoknál, kibővítik az értékre való mintaillesztés lehetőségeit.
Az alsó sorban szokás kitenni egy otherwise-t (ez igazából egy szinonímája a True-nak)
-}
----------------------------------
-- Rekurzió
----------------------------------
{-
A guardok megismerésével (majdnem*) teljesen elsajátítottuk az imperatív nyelven if-else-then vezérlőszerkezetként használt elágazás viselkedését. (*: a "case of" vezérlőszerkezet kimaradt, erről később, opcionálisan; viszont akit érdekel, megnézheti, viszont, ha használja számonkéréskor, akkor tudja is mit jelent!)

Viszont van rengeteg feladat, amit nem tudunk ciklusok nélkül megoldani. Ha végiggondoljuk elemi szinten hogy használjuk a ciklusokat imperatív nyelveken, akkor felfedezhetünk bennük mellékhatásokat:

for (int i = 0; i < sum; i++)

létrejön egy i változó, ez már önmagában egy mellékhatás, márpedig ahogy tanultuk, a Haskell egy tisztán funkcionális nyelv, ami azt jelenti, hogy a mellékhatások nem megengedett jelenségek (kivéve, ha kifejezetten kezelni akarjuk őket, lásd: funkcionális nyelvek, kötvál tárgy)

Ha a ciklushoz nem használhatunk efféle eszközöket, akkor hogy valósítjuk meg őket?

Megintcsak gondoljunk a matematikára, speciálisan a faktoriálisra. Mi a faktoriális definíciója?
-}
factorial :: Integer -> Integer
factorial 0 = 1
factorial x = x * factorial (x-1)

-- Definíció:
-- Rekurzív függvény: Olyan függvény, amely önmaga definiálásához saját magát használja fel.

-- Amikor rekurziót definiálunk, nagyon fontos hogy jól válasszuk meg az alapesetünket. Ha rosszul választunk, vagy elfelejtünk definiálni, akkor végtelen rekurzióba ütközhetünk. Nézzük meg mi történik, ha a factorialból töröljük az alapesetet

-- Definiáljuk azt a rekurzív függvényt, ami visszaadja az n-edik Fibonacci-számot
fibonacci :: Integer -> Integer
fibonacci 0 = 0
fibonacci 1 = 1
fibonacci n = fibonacci(n-1) + fibonacci(n-2)

-- Definiáljuk azt a rekurzív függvényt, ami összeadja n-ig a számokat
sumTo :: Integer -> Integer
sumTo 0 = 0
sumTo 1 = 1
sumTo x = x+sumTo(x-1)

-- Az előzőhöz hasonlóan, de most az adott számok négyzetét számoljuk meg
sumSquaresTo = undefined

-- Definiáljuk újra a hatványozást, a viselkedés pontosan megegyezik az általunk ismert szabályokkal
(^|^) = undefined
----------------------------------
-- Rekurzív adatszerkezetek és polimorfizmus bevezető
----------------------------------