## Obiekty

### Metody (obiektów)
#### Zadanie 1 - Klasy
1. Utwórz publiczna klasę Shape z właściwościami:
* public int width
* public int height

#### Zadanie 2 - Klasy
1. Utwórz publiczną klasę Rectangle, która dziedziczy po Shape
2. Utwórz w niej metodę public int GetArea(), która zwraca pole powierzchni (widht * height)


#### Zadanie 3 - Klasy
1. Utwórz publiczną klasę Paint, która dziedziczy po Rectangle
2. Utwórz w niej metodę GetPrice(), która zwraca cenę (powierzchnia * 1000 zł/m2)


#### Zadanie 4 - bawimy się obiektami
1. Utwórz obiekt klasy Paint
2. Ustaw mu wysokość i szerokość
3. Wyświetl jego cenę

#### Zadanie 5 - konstruktory
1. Utwórz konstruktor klasy Paint, który będzie wymagał podania wysokości i szerokości
2. Popraw poprzednie zadanie


#### Zadanie 6 - Interfejsy
1. Utwórz interfejs IPriceable która definiuje GetPrice()
2. Popraw klasę Paint tak żeby implementowała interfejs IPriceable
3. Zakomentuj chwilowo napisaną metodę GetPrice w klasie Paint i zobacz co się stało


#### Zadanie 7 - Interfejsy
1. Utwórz instancję klasy Paint
2. Utwórz instancję interfejsu IPriceable
3. Wywołaj na nich metody .GetPrice()