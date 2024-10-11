# 04 Generics

1. Describe the problem generics address.
   - code reuse: method works regardless of data type
   - type safety: catch potential type-related error at compile time
   - performance: eliminate the need to cast object back and forth



2. How would you create a list of strings, using the generic List class?

- `List<string> ls = [];`



3. How many generic type parameters does the Dictionary class have?

- 2
- `Dictionary<Tkey, Tvalue>`



4. True/False. When a generic class has multiple type parameters, they must all match.

- F



5. What method is used to add items to a List object?

- `Add(T item)`



6. Name two methods that cause items to be removed from a List.

- `Remove(T item)`
- `RemoveAt(int idx)`



7. How do you indicate that a class has a generic type parameter?

- if the class has type parameter within angle brakets after the class name



8. True/False. Generic classes can only have one generic type parameter.

- F



9. True/False. Generic type constraints limit what can be used for the generic type.

- T



10. True/False. Constraints let you use the methods of the thing you are constraining to.

- T