## Arrow functions
Dokumentacja: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-operator


#### Zadanie 1 - arrow functions
1. Napisz funkcję (użyj arrow function) która bierze dwa parametry: imię oraz nazwisko i zwraca napis "Witaj, Imię Nazwisko!"


#### Zadanie 2 - klasa Func
https://docs.microsoft.com/en-us/dotnet/api/system.func-1?view=netcore-3.1

Funkcję również możemy utworzyć jako obiekt np. w taki sposób:
```csharp
Func<int, int> nazwaFunkcji = parametr =>
{
    // kod który robi coś z parametrem
    return result;
};
int result = nazwaFunkcji(5)
```

Zwróćcie uwagę na to, że ostatnim parametrem jest typ *zwracany* z funkcji, a ewentualnie z przodu podajemy typy parametrów.
`delegate` to po prostu referencja do funkcji


1. Utwórz funkcję która weźmie parametr i zwróci go pomnożony przez 5.
2. Spróbuj wywołać funkcję przekazując jako parametr stringa "10"

