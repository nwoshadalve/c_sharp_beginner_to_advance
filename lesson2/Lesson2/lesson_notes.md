## Variables, Data Types & Operators
---

### What is a Variable?
A variable is a **named storage location** in memory that holds a value.

#### Declaring vs Initializing:

- Declaring = telling C# the variable exists: `int age;`
- Initializing = giving it a value: `age = 25;`

#### Naming Conventions
C# has two main naming styles:

|Style|Used For|Example|
|-----|--------|-------|
|`camelCase`|Local variables, parameters|`int playerScore`|
|`PascalCase`|Classes, methods, properties|`GetPlayerScore()`|

**Rules: no spaces, no starting with a number, no special characters (except _ ).**

---

## Value Types

These store the actual value directly in memory.

| Type | Size | Range / Notes | Example |
| :--- | :--- | :--- | :--- |
| **int** | 32-bit | -2,147,483,648 to 2,147,483,647 | `int x = 10;` |
| **long** | 64-bit | Much larger range | `long big = 9999999999L;` |
| **short** | 16-bit | -32,768 to 32,767 | `short s = 100;` |
| **byte** | 8-bit | 0 to 255 | `byte b = 200;` |
| **float** | 32-bit | ~7 digits precision | `float f = 3.14f;` |
| **double** | 64-bit | ~15 digits precision | `double d = 3.14;` |
| **decimal** | 128-bit | High precision, for money | `decimal price = 9.99m;` |
| **bool** | 1-bit | true or false | `bool isOn = true;` |
| **char** | 16-bit | Single character | `char letter = 'A';` |

> [!WARNING]
> **Notice the suffixes:** `f` for **float**, `L` for **long**, and `m` for **decimal**. Without them, C# may give you a compile error or pick the wrong type.

---

## Reference Types

These store a reference (address) to where the data lives in memory, not the data itself.

```csharp
string greeting = "Hello, World!";  // string is a reference type
object anything = 42;               // object can hold any type
```
**Note:** `string` is **immutable** — once created, it cannot be changed. When you "change" a string, C# creates a brand new one.

---

## The `var` Keyword

The `var` keyword lets C# figure out the type for you at compile time. It is **not dynamic** — the type is fixed once assigned.

```csharp
var score = 100;        // C# knows this is int
var name = "Alice";     // C# knows this is string
var price = 9.99m;      // C# knows this is decimal
```
[!TIP]
Use var when the type is obvious from the right side of the assignment (e.g., var list = new List<string>();). Avoid it when it makes the code harder to read or when the type isn't clear.

---

## Type Conversion

**Implicit conversion** — safe, no data loss, happens automatically:

```csharp
int x = 10;
double d = x;   // int fits into double, no problem
```

**Explicit casting** — you force it, possible data loss:

```csharp
double d = 9.99;
int x = (int)d;  // x becomes 9 — the decimal part is cut off!
```

##### Conversion methods:

```csharp
string input = "42";
int number = int.Parse(input);         // throws exception if invalid
int safe = Convert.ToInt32(input);     // also converts, slightly safer
bool ok = int.TryParse(input, out int result); // safest — no exception
```
ToString() converts anything to a string:

```csharp
int x = 100;
string s = x.ToString();  // s = "100"
```

---

## String Operations

```csharp
string first = "Hello";
string second = "World";

// Concatenation
string combined = first + " " + second;  // "Hello World"

// Interpolation (preferred)
string name = "Alice";
string message = $"Hello, {name}! You are {25 + 1} years old.";

// Verbatim string (backslashes are literal)
string path = @"C:\Users\Alice\Documents";

// Common methods
string text = "  Hello, World!  ";
Console.WriteLine(text.Length);            // 17 (includes spaces)
Console.WriteLine(text.Trim());            // "Hello, World!"
Console.WriteLine(text.ToUpper());         // "  HELLO, WORLD!  "
Console.WriteLine(text.Contains("World")); // True
Console.WriteLine(text.Replace("World", "C#")); // "  Hello, C#!  "
Console.WriteLine(text.Substring(8, 5));   // "World" (start index, length)

string csv = "one,two,three";
string[] parts = csv.Split(',');  // ["one", "two", "three"]
```

---

## Operators

### Arithmetic:
```csharp
int a = 10, b = 3;
Console.WriteLine(a + b);   // 13
Console.WriteLine(a - b);   // 7
Console.WriteLine(a * b);   // 30
Console.WriteLine(a / b);   // 3  ← integer division, not 3.33!
Console.WriteLine(a % b);   // 1  ← remainder (modulus)
```

### Increment / Decrement:
```csharp
int x = 5;
Console.WriteLine(x++);  // prints 5, then x becomes 6  (postfix)
Console.WriteLine(++x);  // x becomes 7, then prints 7  (prefix)
```

### Assignment shortcuts:
```csharp
int n = 10;
n += 5;   // n = 15
n -= 3;   // n = 12
n *= 2;   // n = 24
n /= 4;   // n = 6
```

### Comparison (always returns bool):
```csharp
5 == 5   // true
5 != 3   // true
10 > 3   // true
2 >= 2   // true
```

### Logical:
```csharp
true && false  // false (both must be true)
true || false  // true  (at least one must be true)
!true          // false (NOT)
```

### Ternary operator — a shortcut for if/else:
```csharp
int age = 20;
string result = age >= 18 ? "Adult" : "Minor";
// result = "Adult"
```

### Null coalescing:
```csharp
string name = null;
string display = name ?? "Unknown";   // display = "Unknown"

name ??= "Default";  // only assigns if name is null
```

### Constants & Readonly
```csharp
const double Pi = 3.14159;       // Fixed at compile time, never changes
readonly int maxRetries = 3;     // Set once at runtime (can be set in constructor)
```