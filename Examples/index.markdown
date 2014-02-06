---
layout: tutorial
title:  "Examples"
---
Recommended before going through examples:
  * Install correct visual studio version
  * Get a copy of the [data binding cheat sheet](http://go.nbdtech.com?94E138EA)
  
Optional:
  * Download the MVVM Light code snippets from [http://mvvmlight.codeplex.com/sourcecontrol/latest](http://mvvmlight.codeplex.com/sourcecontrol/latest) and install them in your visual studio environment.
  * You will likely want to either use the above snippets, or create your own.

**Important**: None of these examples currently take into account the app life-cycle of a Windows Store application.  So be aware if you are working on a real app that the life-cycle will need to be handled correctly. See the msdn article [Part 2: Manage app lifecycle and state (Windows Store apps using C#/VB and XAML)](http://msdn.microsoft.com/en-us/library/windows/apps/hh986968.aspx?cs-save-lang=1&cs-lang=csharp#code-snippet-3) for details.

Examples (checkout specific revision to run):

 * [Example 1 - "One Time" binding with separate design and runtime data.](https://github.com/davisnw/mvvm-palindrome/commit/015aad31891c126edc97a0551c38a4f5e1406c8b)
 * [Example 2 - Binding that responds to value changes - raising notify property changed](https://github.com/davisnw/mvvm-palindrome/commit/af82fb82b333a27e1ea7811c6f3eb06880f63d10)
 * [Example 3 - Introducing Commands and two-way binding](https://github.com/davisnw/mvvm-palindrome/commit/7fb777cef479f3b2209479f10efd69903db7e5c8)





TODO:  
EventToCommand
Binding Converters
Data Templates
Unit Tests
Observable Collections
Domain Model
Triggers?