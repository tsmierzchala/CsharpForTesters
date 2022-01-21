## Debugowanie

Skróty klawiszowe przydatne w debugowaniu:

* F11 - wkrocz do
* F10 - przekrocz nad
* SHIFT + F11 - wyjdź
* F5 - uruchom w trybie debugowania
* SHIFT + F5 - wyjdź z trybu debugowanie (zatrzymaj program)

#### Zadanie 1

1. Załóż breakpoint na pierwszej instrukcji w metodzie `Main()` klasy `DebugujMnie.cs`
2. Uruchom klasę program w trybie debug
3. Nawiguj przechodząc skrótem klawiszowym F11

#### Zadanie 2

1. Uruchom jeszcze raz program w trybie debug
2. Nawiguj przechodząc tym razem skrótem klawiszowym F10

Jaka jest różnica między poruszaniem się poprzez F10 a F11?


#### Zadanie 3

1. Ustaw warunkowy breakpoint w klasie `DebugowanieWarunkowe.cs` w linii `for (int i = 1000; i >= 0; i--)`
2. Jako warunek wpisz tam `i<3`
3. Uruchom aplikację w trybie debug.
4. Znajdź błąd i go napraw

#### Zadanie 4
1. Zakomentuj kod:
```csharp
            var v = 0;

            for (int i = 1000; i >= 0; i--)
            {
                v = i < 9999 ? 10 / i : 10 * i;
            }
````
2. Odkomentuj zakomentowany kod.
3. Ustaw breakpoint warunkowy w linii `for (int i =0; i<=arr.Length; i++)`
4. Jako warunek wpisza tam `i==16`
5. Znajdź błąd i go napraw