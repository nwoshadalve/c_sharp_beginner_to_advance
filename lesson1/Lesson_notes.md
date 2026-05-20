## Summary

| Concept | Key Point |
| :--- | :--- |
| **C#** | A modern, strongly typed OOP language by Microsoft |
| **.NET** | The platform: CLR runs code, BCL provides libraries, JIT compiles to machine code |
| **Compilation** | C# → IL → Machine Code (two-step process) |
| **Entry point** | `static void Main(string[] args)` or top-level statements |
| **Output** | `Console.WriteLine()` / `Console.Write()` |
| **Input** | `Console.ReadLine()` |
| **Comments** | `//`, `/* */`, `///` |


---

## Inroduction
---

C# (pronounced "C Sharp") is a **modern**, **general-purpose**, **object-oriented** programming language developed by **Microsoft**. It was created by **Anders Hejlsberg** and first released in **2000** alongside the .NET Framework.

---

## Key characteristics of C#:

- **Strongly typed** — every variable has a fixed type
- **Object-oriented** — built around classes and objects
- **Managed** — memory is handled automatically by a garbage collector
- **Versatile** — used for web apps, desktop apps, games (Unity), mobile apps, APIs, cloud services, and more

---

## Evulation

- C# 2.0 (generics)
- 3.0 (LINQ, lambdas)
- 5.0 (async/await)
- 7.0 (pattern matching)
- modern versions (9, 10, 11, 12) which added records, top-level statements, and more.

---

## What is .NET?

##### .NET is the platform/ecosystem that C# runs on.

### It has three main components need to know:

- **CLR — Common Language Runtime:**
This is the virtual machine that runs C# code. It handles memory management (garbage collection), security, and exception handling. **No need to manage memory manually — the CLR does it.**
- **BCL — Base Class Library:**
A massive collection of pre-built classes and methods that can be used — things like Console, Math, File, List<T>, etc.
- **JIT — Just-In-Time Compiler:**
C# doesn't compile directly to machine code. It compiles to an **intermediate language (IL)**, and then the JIT compiler converts IL to machine code at runtime, optimized for the specific machine it's running on.

---

## How C# Code is Compiled & Executed

&emsp;`C# Code (.cs)`  
&emsp;&emsp;&emsp;&emsp;`↓`  
&emsp;`C# Compiler (Roslyn)`  
&emsp;&emsp;&emsp;&emsp;`↓`  
`Intermediate Language / IL (.dll or .exe)`  
&emsp;&emsp;&emsp;&emsp;`↓`  
`JIT Compiler (at runtime)`  
&emsp;&emsp;&emsp;&emsp;`↓`  
&emsp;`Native Machine Code`  
&emsp;&emsp;&emsp;&emsp;`↓`  
&emsp;&emsp;`Execution`z

---

## Traditional vs Modern Top-Level Statements

#### Starting from .NET 6, C# supports top-level statements — a cleaner, shorter style:

`// Modern style (top-level statements)
Console.WriteLine("Hello, World!");`

That's the entire program! **No namespace, no class, no Main**. The compiler generates all the boilerplate behind the scenes.
Both styles are valid. In this course we'll use the modern style for short examples and the traditional style when learning classes and OOP.


---

## Comments

// This is a single-line comment

/*
   This is a
   multi-line comment
*/

/// <summary>
/// This is an XML documentation comment.
/// It's used to generate documentation for methods and classes.
/// </summary>
static void MyMethod()
{

    // code here
}

___


### When you build a C# project, Visual Studio doesn't just produce one file. Let me explain each one:

- `HelloWorld.exe` — The launcher file you already know. On Windows this is the entry point. It's a small native executable that starts the .NET runtime and hands control over to the DLL.
- `HelloWorld.dll` — This is the actual compiled program — your C# code compiled into IL (Intermediate Language). This is the most important file. The .exe is essentially just a bootstrapper that loads this DLL and runs it.
- `HelloWorld.pdb` — "Program Database" file. This contains debug information — it maps your IL code back to your original .cs source lines. This is what allows Visual Studio to show you exactly which line of code caused a crash or where a breakpoint is. It's only needed during development, not in a final release.
- `HelloWorld.deps.json` — A dependency manifest. It tells the .NET runtime which libraries and packages your app depends on, and where to find them. Think of it as a list of ingredients your app needs to run.
- `HelloWorld.runtimeconfig.json` — Tells the .NET runtime which version of .NET your app needs to run on (e.g., .NET 8.0). When you launch the app, .NET reads this first to make sure the right version is available.
