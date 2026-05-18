# C# Complete Course Curriculum
### From Basic to Advanced — Self-Paced with Exam-Gated Progression

---

## How This Course Works

- 📖 Each lesson is taught in detail with explanations and examples
- ✅ After each lesson, you take an **exam**
- 🔁 You must **pass the exam** before moving to the next lesson
- ❌ If you don't pass, you retake the lesson and exam
- 🗂️ Track your progress by checking off completed lessons below

---

## Progress Tracker

| # | Lesson | Status | Exam Result |
|---|--------|--------|-------------|
| 1 | Introduction to C# & .NET | 🔵 In Progress | — |
| 2 | Variables, Data Types & Operators | ⬜ Not Started | — |
| 3 | Control Flow | ⬜ Not Started | — |
| 4 | Methods & Functions | ⬜ Not Started | — |
| 5 | Arrays & Collections | ⬜ Not Started | — |
| 6 | OOP Part 1 — Classes & Objects | ⬜ Not Started | — |
| 7 | OOP Part 2 — Inheritance & Polymorphism | ⬜ Not Started | — |
| 8 | Exception Handling & Debugging | ⬜ Not Started | — |
| 9 | File I/O & Serialization | ⬜ Not Started | — |
| 10 | Generics, Delegates & Events | ⬜ Not Started | — |
| 11 | LINQ & Lambda Expressions | ⬜ Not Started | — |
| 12 | Async Programming (async/await) | ⬜ Not Started | — |
| 13 | Design Patterns & Best Practices | ⬜ Not Started | — |

**Legend:** ⬜ Not Started &nbsp;|&nbsp; 🔵 In Progress &nbsp;|&nbsp; ✅ Passed &nbsp;|&nbsp; ❌ Failed/Retake

---

---

## 🟦 BEGINNER LEVEL

---

### Lesson 1 — Introduction to C# & .NET
**Status:** ⬜ &nbsp; **Exam:** —

**Topics Covered:**
- What is C# and its history
- What is .NET and the .NET ecosystem (CLR, BCL, JIT)
- How C# code is compiled and executed (C# → IL → Machine Code)
- Setting up the environment (Visual Studio / VS Code / .NET SDK)
- Creating your first console application (`dotnet new console`)
- Understanding `Hello World` line by line
- Traditional vs modern top-level statement style
- `Console.WriteLine()`, `Console.Write()`, `Console.ReadLine()`
- Single-line (`//`) and multi-line (`/* */`) comments
- XML documentation comments (`///`)

**Exam:** 10 questions — concepts, code reading, and a small coding task

---

### Lesson 2 — Variables, Data Types & Operators
**Status:** ⬜ &nbsp; **Exam:** —

**Topics Covered:**

**Variables & Declaration**
- What is a variable and how memory works
- Declaring and initializing variables
- Naming conventions (camelCase for locals, PascalCase for members)
- `var` keyword (implicit typing) vs explicit typing

**Value Types**
- `int` — 32-bit integer (-2,147,483,648 to 2,147,483,647)
- `long` — 64-bit integer
- `short`, `byte`, `sbyte`
- `float` — single-precision decimal (suffix `f`)
- `double` — double-precision decimal (default for decimals)
- `decimal` — high-precision for financial data (suffix `m`)
- `bool` — true or false
- `char` — single character (single quotes `'A'`)

**Reference Types**
- `string` — sequence of characters (immutable)
- `object` — base type of everything in C#

**Type Conversion**
- Implicit conversion (smaller → larger type)
- Explicit casting `(int)myDouble`
- `Convert.ToInt32()`, `int.Parse()`, `int.TryParse()`
- `ToString()` method

**String Operations**
- String concatenation (`+`)
- String interpolation (`$"Hello {name}"`)
- Verbatim strings (`@"C:\Users\..."`)
- Common methods: `Length`, `ToUpper()`, `ToLower()`, `Trim()`, `Contains()`, `Replace()`, `Substring()`, `Split()`

**Operators**
- Arithmetic: `+`, `-`, `*`, `/`, `%` (modulus)
- Increment/Decrement: `++`, `--` (prefix vs postfix)
- Assignment: `=`, `+=`, `-=`, `*=`, `/=`
- Comparison: `==`, `!=`, `>`, `<`, `>=`, `<=`
- Logical: `&&` (AND), `||` (OR), `!` (NOT)
- Ternary operator: `condition ? valueIfTrue : valueIfFalse`
- Null coalescing: `??`, `??=`

**Constants & Readonly**
- `const` — compile-time constant
- `readonly` — runtime constant

**Exam:** 12 questions — type identification, operator results, type conversion, string manipulation

---

### Lesson 3 — Control Flow
**Status:** ⬜ &nbsp; **Exam:** —

**Topics Covered:**

**Conditional Statements**
- `if` statement
- `if / else`
- `if / else if / else` chains
- Nested `if` statements
- `switch` statement (traditional)
- `switch` expressions (modern C# pattern matching)
- Pattern matching with `is` and `when`

**Loops**
- `for` loop — structure, initialization, condition, iteration
- `while` loop — condition checked before each iteration
- `do-while` loop — condition checked after each iteration (runs at least once)
- `foreach` loop — iterating over collections
- Nested loops

**Loop Control**
- `break` — exit the loop immediately
- `continue` — skip to the next iteration
- `goto` (briefly — why to avoid it)
- `return` inside loops

**Practical Patterns**
- Counter-controlled loops
- Sentinel-controlled loops
- Accumulator pattern
- Input validation loops

**Exam:** 12 questions — trace code output, fix bugs, write loops and conditions

---

### Lesson 4 — Methods & Functions
**Status:** ⬜ &nbsp; **Exam:** —

**Topics Covered:**

**Defining Methods**
- Method syntax: access modifier, return type, name, parameters, body
- `void` methods (no return value)
- Methods with return values (`return` statement)
- Calling methods

**Parameters**
- Value parameters (pass by value)
- Reference parameters (`ref` keyword)
- Output parameters (`out` keyword)
- `in` parameters (read-only reference)
- Params array (`params` keyword)
- Optional/default parameters
- Named arguments

**Method Overloading**
- Same method name, different parameter signatures
- How the compiler resolves overloads

**Scope & Lifetime**
- Local variables vs class-level fields
- Variable scope within blocks
- Stack vs Heap (conceptual overview)

**Recursion**
- What recursion is
- Base case and recursive case
- Classic examples: factorial, Fibonacci, countdown
- Stack overflow risk

**Local Functions**
- Defining a function inside another function (C# 7+)

**Expression-bodied Methods**
- Shorthand syntax with `=>`

**Exam:** 12 questions — trace recursive calls, write overloaded methods, identify scope issues

---

### Lesson 5 — Arrays & Collections
**Status:** ⬜ &nbsp; **Exam:** —

**Topics Covered:**

**Arrays**
- Declaring and initializing arrays
- Accessing elements by index (zero-based)
- Array length (`Length` property)
- Iterating arrays with `for` and `foreach`
- Multi-dimensional arrays (`[,]`)
- Jagged arrays (`[][]`)
- Passing arrays to methods
- Returning arrays from methods
- Common array methods: `Array.Sort()`, `Array.Reverse()`, `Array.IndexOf()`

**Collections (System.Collections.Generic)**
- `List<T>` — dynamic array
  - `Add()`, `Remove()`, `RemoveAt()`, `Insert()`, `Contains()`, `Count`, `Clear()`, `IndexOf()`
- `Dictionary<TKey, TValue>` — key/value pairs
  - `Add()`, `Remove()`, `ContainsKey()`, `TryGetValue()`, iteration
- `HashSet<T>` — unique elements, no duplicates
- `Queue<T>` — FIFO (First In, First Out)
- `Stack<T>` — LIFO (Last In, First Out)
- When to use which collection

**Collection Initialization Syntax**
- Object/collection initializers
- Index initializers for dictionaries

**Exam:** 12 questions — array manipulation, collection operations, choosing the right collection

---

---

## 🟪 INTERMEDIATE LEVEL

---

### Lesson 6 — Object-Oriented Programming, Part 1
**Status:** ⬜ &nbsp; **Exam:** —

**Topics Covered:**

**OOP Concepts Overview**
- What is OOP and why it exists
- The four pillars: Encapsulation, Inheritance, Polymorphism, Abstraction

**Classes & Objects**
- Defining a class
- Creating objects with `new`
- The difference between a class (blueprint) and an object (instance)
- Instance vs static members

**Fields & Properties**
- Fields (direct variable storage in a class)
- Properties with `get` and `set` accessors
- Auto-implemented properties
- Read-only properties
- Expression-bodied properties
- Property validation in setters

**Constructors**
- Default constructor
- Parameterized constructors
- Constructor overloading
- Constructor chaining with `this()`
- `static` constructors

**Access Modifiers**
- `public` — accessible everywhere
- `private` — accessible only within the class
- `protected` — accessible within class and subclasses
- `internal` — accessible within the same assembly
- `protected internal`, `private protected`

**The `this` Keyword**
- Referring to the current instance
- Disambiguating fields from parameters

**Object Initializers**
- Initializing properties without a constructor

**Structs vs Classes**
- Value type (`struct`) vs reference type (`class`)
- When to use each

**Records (C# 9+)**
- Immutable data objects
- `record` keyword and `with` expressions

**Exam:** 15 questions — write classes, identify encapsulation violations, trace object state

---

### Lesson 7 — Object-Oriented Programming, Part 2
**Status:** ⬜ &nbsp; **Exam:** —

**Topics Covered:**

**Inheritance**
- Deriving a class with `: BaseClass`
- What gets inherited (public and protected members)
- The `base` keyword — calling base constructors and methods
- `protected` access in inheritance context
- Constructor chaining in inheritance

**Method Overriding & Polymorphism**
- `virtual` methods — allow overriding
- `override` keyword — replacing base behavior
- `new` keyword — hiding base methods (vs overriding)
- Runtime polymorphism — calling overridden methods through base reference
- The Liskov Substitution Principle (introduced)

**Abstract Classes**
- `abstract` keyword
- Abstract methods (no body, must be overridden)
- Abstract classes cannot be instantiated
- When to use abstract classes

**Interfaces**
- Defining an interface with `interface`
- Implementing interfaces
- A class can implement multiple interfaces (vs single inheritance)
- Interface vs abstract class — when to use which
- Default interface methods (C# 8+)
- Common .NET interfaces: `IComparable<T>`, `IEnumerable<T>`, `IDisposable`

**Sealed Classes & Methods**
- `sealed` class — cannot be inherited
- `sealed override` — stop further overriding

**Static Classes & Members**
- Static classes (utility classes like `Math`, `Console`)
- Static methods and fields
- Static vs instance — key differences

**Object Class**
- Everything inherits from `object`
- `ToString()`, `Equals()`, `GetHashCode()` — overriding them

**Exam:** 15 questions — class hierarchies, polymorphism traces, interface implementation

---

### Lesson 8 — Exception Handling & Debugging
**Status:** ⬜ &nbsp; **Exam:** —

**Topics Covered:**

**What Are Exceptions?**
- Errors vs exceptions
- The exception class hierarchy (`Exception` → `SystemException` → specific types)
- Common exceptions: `NullReferenceException`, `IndexOutOfRangeException`, `FormatException`, `DivideByZeroException`, `FileNotFoundException`, `ArgumentException`, `InvalidOperationException`

**try / catch / finally**
- `try` block — code that might fail
- `catch` block — handling the exception
- Catching specific exception types
- Catching multiple exceptions
- `finally` block — always runs (cleanup code)
- Exception properties: `Message`, `StackTrace`, `InnerException`

**Throwing Exceptions**
- `throw` keyword
- Re-throwing exceptions (`throw` vs `throw ex`)
- `throw` expressions (C# 7+)

**Custom Exceptions**
- Creating your own exception class
- When and why to create custom exceptions

**Exception Best Practices**
- Don't use exceptions for control flow
- Catch specific exceptions, not just `Exception`
- Log exceptions properly
- Fail fast vs defensive programming

**Null Handling**
- Null reference problem
- Null checks (`if (x != null)`)
- Null-conditional operator: `?.`
- Null-coalescing operator: `??`
- Nullable value types: `int?`, `bool?`
- Nullable reference types (C# 8+ with `#nullable enable`)

**Debugging Tools**
- Breakpoints in Visual Studio / VS Code
- Step Over, Step Into, Step Out
- Watch window and locals
- Immediate window
- `Debug.WriteLine()` and `Trace`

**Exam:** 12 questions — identify exception types, fix broken code, write try/catch blocks

---

### Lesson 9 — File I/O & Serialization
**Status:** ⬜ &nbsp; **Exam:** —

**Topics Covered:**

**File & Directory Operations (System.IO)**
- `File` class — `ReadAllText()`, `WriteAllText()`, `ReadAllLines()`, `WriteAllLines()`, `AppendAllText()`, `Exists()`, `Delete()`, `Copy()`, `Move()`
- `Directory` class — `CreateDirectory()`, `GetFiles()`, `GetDirectories()`, `Exists()`, `Delete()`
- `Path` class — `Combine()`, `GetExtension()`, `GetFileName()`, `GetDirectoryName()`

**Streams**
- What is a stream (a flow of data)
- `FileStream` — raw byte-level file access
- `StreamWriter` — writing text to a file
- `StreamReader` — reading text from a file
- Buffered streams
- Memory streams

**The `using` Statement**
- Automatic resource disposal
- `IDisposable` interface (introduced)
- `using` declaration vs `using` statement (C# 8+)

**Serialization**
- What is serialization (object → storable format)
- JSON serialization with `System.Text.Json`
  - `JsonSerializer.Serialize()`
  - `JsonSerializer.Deserialize<T>()`
  - `[JsonPropertyName]` attribute
  - `JsonSerializerOptions`
- XML serialization with `XmlSerializer`
- Binary serialization (overview)

**Practical Examples**
- Reading a config file
- Saving/loading a list of objects to JSON
- Logging to a file

**Exam:** 12 questions — file operations, stream usage, serialize/deserialize objects

---

---

## 🟧 ADVANCED LEVEL

---

### Lesson 10 — Generics, Delegates & Events
**Status:** ⬜ &nbsp; **Exam:** —

**Topics Covered:**

**Generics**
- Why generics exist (type safety without duplication)
- Generic methods: `T MyMethod<T>(T input)`
- Generic classes: `class MyList<T>`
- Generic constraints: `where T : class`, `where T : struct`, `where T : new()`, `where T : IComparable`
- Multiple type parameters
- Generic interfaces
- Covariance and contravariance (`out T`, `in T`)

**Delegates**
- What is a delegate (a type-safe function pointer)
- Declaring and using delegates
- Multicast delegates (invoking multiple methods)
- Anonymous methods

**Built-in Delegate Types**
- `Action` — method that returns void
- `Action<T>`, `Action<T1, T2>`, etc.
- `Func<TResult>` — method that returns a value
- `Func<T, TResult>`, `Func<T1, T2, TResult>`, etc.
- `Predicate<T>` — method that returns bool

**Lambda Expressions**
- Lambda syntax: `x => x * 2`
- Multi-statement lambdas: `(x, y) => { ... }`
- Capturing variables (closures)

**Events**
- What are events (publisher/subscriber pattern)
- Declaring events with `event` keyword
- `EventHandler` and `EventHandler<TEventArgs>`
- Creating custom `EventArgs`
- Subscribing (`+=`) and unsubscribing (`-=`) from events
- Raising events safely (null check)

**Exam:** 15 questions — write generic methods, use delegates, wire up events

---

### Lesson 11 — LINQ & Lambda Expressions
**Status:** ⬜ &nbsp; **Exam:** —

**Topics Covered:**

**What is LINQ?**
- Language Integrated Query
- LINQ to Objects, LINQ to XML, LINQ to SQL/EF overview
- Deferred execution vs immediate execution

**Lambda Expressions (Deep Dive)**
- Expression lambdas vs statement lambdas
- Closures and captured variables
- Expression trees (overview)

**LINQ Method Syntax**
- Filtering: `Where()`
- Projection: `Select()`, `SelectMany()`
- Ordering: `OrderBy()`, `OrderByDescending()`, `ThenBy()`
- Aggregation: `Count()`, `Sum()`, `Average()`, `Min()`, `Max()`
- Element access: `First()`, `FirstOrDefault()`, `Last()`, `LastOrDefault()`, `Single()`, `SingleOrDefault()`, `ElementAt()`
- Existence: `Any()`, `All()`, `Contains()`
- Set operations: `Distinct()`, `Union()`, `Intersect()`, `Except()`
- Grouping: `GroupBy()`
- Joining: `Join()`, `GroupJoin()`
- Partitioning: `Take()`, `Skip()`, `TakeWhile()`, `SkipWhile()`
- Conversion: `ToList()`, `ToArray()`, `ToDictionary()`, `ToHashSet()`
- Flattening: `SelectMany()`

**LINQ Query Syntax**
- `from`, `where`, `select`, `orderby`, `group by`, `join`
- When to use query syntax vs method syntax

**Chaining LINQ Operations**
- Building complex queries by chaining methods
- Readability and performance considerations

**Exam:** 15 questions — write LINQ queries, trace deferred execution, fix broken LINQ chains

---

### Lesson 12 — Async Programming (async / await)
**Status:** ⬜ &nbsp; **Exam:** —

**Topics Covered:**

**Why Async?**
- Synchronous vs asynchronous execution
- Thread blocking — why it's bad
- I/O-bound vs CPU-bound work
- The UI thread problem

**Tasks**
- `Task` — represents an ongoing operation
- `Task<T>` — a task that returns a value
- `Task.Run()` — running work on a thread pool thread
- `Task.Delay()` — async wait
- `Task.WhenAll()` — await multiple tasks
- `Task.WhenAny()` — first to complete wins
- `Task.FromResult()` — wrapping sync results

**async / await**
- Declaring `async` methods
- `await` keyword — non-blocking wait
- Return types: `Task`, `Task<T>`, `void` (event handlers only), `ValueTask<T>`
- Async all the way — why you shouldn't mix sync/async
- Configuring await: `ConfigureAwait(false)`

**Cancellation**
- `CancellationToken`
- `CancellationTokenSource`
- Passing tokens to async methods
- Handling `OperationCanceledException`

**Parallel Programming**
- `Parallel.For()`, `Parallel.ForEach()`
- `Task.WhenAll` for true parallelism
- Thread safety basics — race conditions, `lock` keyword
- `Interlocked` class for atomic operations

**Exception Handling in Async Code**
- `AggregateException`
- try/catch with await

**Async Patterns**
- Async factory pattern
- Fire-and-forget (and why to avoid it)
- Progress reporting with `IProgress<T>`

**Exam:** 15 questions — trace async execution, write async methods, fix deadlocks

---

---

## 🟩 EXPERT LEVEL

---

### Lesson 13 — Design Patterns & Best Practices
**Status:** ⬜ &nbsp; **Exam:** —

**Topics Covered:**

**SOLID Principles**
- **S** — Single Responsibility Principle
- **O** — Open/Closed Principle
- **L** — Liskov Substitution Principle
- **I** — Interface Segregation Principle
- **D** — Dependency Inversion Principle
- Code examples of violations and fixes for each

**Creational Patterns**
- **Singleton** — one instance across the application
- **Factory Method** — creating objects without specifying exact class
- **Abstract Factory** — families of related objects
- **Builder** — step-by-step complex object construction

**Structural Patterns**
- **Repository** — abstracting data access
- **Decorator** — adding behavior without modifying the class
- **Adapter** — making incompatible interfaces work together

**Behavioral Patterns**
- **Observer** — event/notification system (relates to Lesson 10)
- **Strategy** — swapping algorithms at runtime
- **Command** — encapsulating operations as objects

**Dependency Injection (DI)**
- Constructor injection
- `IServiceCollection` and .NET's built-in DI container
- `AddSingleton`, `AddScoped`, `AddTransient`
- Why DI improves testability

**Code Quality & Best Practices**
- DRY — Don't Repeat Yourself
- KISS — Keep It Simple, Stupid
- YAGNI — You Aren't Gonna Need It
- Writing readable, self-documenting code
- Naming conventions (Microsoft C# standards)
- Code reviews — what to look for

**Unit Testing Introduction**
- Why test your code
- xUnit / NUnit / MSTest
- Arrange-Act-Assert pattern
- Mocking with Moq (overview)

**Exam:** 20 questions — identify SOLID violations, apply the right pattern, refactor code

---

---

## 📚 Reference: Key .NET Namespaces

| Namespace | What It Contains |
|-----------|-----------------|
| `System` | Core types: `Console`, `Math`, `Convert`, `String`, `Environment` |
| `System.Collections.Generic` | `List<T>`, `Dictionary<K,V>`, `Queue<T>`, `Stack<T>`, `HashSet<T>` |
| `System.IO` | `File`, `Directory`, `Stream`, `StreamReader`, `StreamWriter`, `Path` |
| `System.Linq` | All LINQ extension methods |
| `System.Text.Json` | `JsonSerializer` for JSON operations |
| `System.Threading` | `Thread`, `Mutex`, `Monitor`, `Interlocked` |
| `System.Threading.Tasks` | `Task`, `Task<T>`, `Parallel` |
| `System.Text` | `StringBuilder`, `Encoding` |
| `System.Net.Http` | `HttpClient` for web requests |

---

## 🎯 Exam Grading Scale

| Score | Result |
|-------|--------|
| 80% – 100% | ✅ Pass — move to next lesson |
| Below 80% | ❌ Retake — review lesson and retest |

---

*Last updated: Lesson 1 in progress*
