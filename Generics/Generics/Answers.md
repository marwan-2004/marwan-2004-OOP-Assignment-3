\# Generics Answers



\## Step 2: Comparison between StudentStore and CourseStore

\- \*\*What is the same:\*\* The entire internal storage logic (`List<T>`), error handling, and method signatures (`Add`, `GetById`, `GetAll`, `Remove`) are completely the same across both classes.

\- \*\*What is the difference:\*\* Only the underlying entity type being handled (`Student` vs `Course`).



\---



\## Step 3: Generic Store Compiler Error

\- \*\*Compiler Error Code:\*\* `CS1061: 'T' does not contain a definition for 'Id' and no accessible extension method 'Id' accepting a first argument of type 'T' could be found.`

\- \*\*Explanation:\*\* The C# compiler rejects `item.Id` because `T` is completely unconstrained. Without a generic constraint, the compiler treats `T` as `System.Object`, which does not expose an `Id` property.



\---



\## Step 7: Unconstrained Type Compilation Failure

\- \*\*Why `Store<string>` must NOT compile:\*\* `Store<T>` carries the generic type constraint `where T : IHasId`. The primitive `string` class does not implement the `IHasId` interface, so attempting to instantiate `Store<string>` results in a compile-time error (`CS0311`).



\---



\## Final Question: Common Design Pattern Name

\- \*\*Pattern Name:\*\* The generic storage abstraction built in Steps 4 and 5 is commonly known as the \*\*Repository Pattern\*\* (specifically, a Generic Repository).

