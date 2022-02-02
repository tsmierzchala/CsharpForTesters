## Wyrażenia regularne
Do testowania wyrażeń regularnych możecie użyć jednej ze stron:
* https://www.debuggex.com/
* https://regex101.com/


#### Zadanie 1 - praca z plikami
Dokumentacja klasy File: https://docs.microsoft.com/en-us/dotnet/api/system.io.file.readalllines?view=netcore-3.1

1. Utwórz w katalogu głównym plik tekstowy (z rozszerzeniem .txt) i wklej do niego zawartość poniżej
```text
Rower Górski w Polsce kosztuje 2042,23zł.
Komputer w USA kosztuje 2500,00$.
Samochód w Niemczech kosztuje 35000,00€.
Piwko w sklepie kosztuje 2zł.
```
2. Wczytaj plik do pamięci za pomocą instrukcji ReadAllLines

#### Zadanie 2 - wyszukiwanie tekstu w plikach
Dokumentacja klasy Regex: https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex?view=netcore-3.1

1. We wczytanym pliku wyszukaj za pomocą wyrażeń regularnych:
* wszystkich kwot
* wszystkich krajów
* wszystkich przedmiotów
2. Wypisz te elementy w konsoli