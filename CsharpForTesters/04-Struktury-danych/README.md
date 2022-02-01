## Struktury danych

#### Zadanie 1
1. Utwórz Enum o nazwie `BrowserType` (w klasie `BrowserType`) który będzie zawierał cztery elementy:
* Chrome
* Edge
* Firefox
* Opera


#### Zadanie 2
1. Odkomentuj kod klasy `public class DriverFactory`.
2. Popraw kod metody `GetDriver()` tak aby dla każdego z elementów utworzonych w enumie zwracał stringa z nazwą wybranej przeglądarki.
3. Wywołaj metodę `GetDriver()` w metodzie `Main()` z różnymi parametrami enuma.


#### Zadanie 3
Dokumentacja list: https://docs.microsoft.com/en-GB/dotnet/api/system.collections.generic.list-1?view=netcore-3.1


1. Utwórz listę Stringów z imionami bohaterów gwiezdnych wojen
* Han Solo
* Luke Skywalker
* Darth Vader
* C-3PO
* Leia Organa
* Obi-Wan Kenobi

2. Wydrukuj ostatni element listy
3. Odwróć kolejność elementów w liście
4. Wydrukuj jeszcze raz listę
5. Posortuj listę domyślną metodą
6. Wydrukuj pierwszy element listy


#### Zadanie 4 
Dokumentacja słowników: https://docs.microsoft.com/en-gb/dotnet/api/system.collections.generic.dictionary-2?view=netcore-3.1
1. Utwórz słownik gdzie kluczem oraz wartością jest string
2. Dodaj następujące pary klucz -> wartość:
* "browser" -> "chrome"
* "headless" -> "false"
* "res_width" -> "1920"
* "res_height" -> "1080"
3. Sprawdź czy słownik zawiera klucz "browser"
4. Pobierz dane z klucza "headless"
5. Usuń klucz "headless" za pomocą kodu
6. Pobierz jeszcze raz dane z klucza "headless"