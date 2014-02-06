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
 * [Example 4 - Introducing Behaviors and Dependency Properties](https://github.com/davisnw/mvvm-palindrome/commit/4d82bc81eee41a440d0f7e474c2c8fd41a09d8cd)
 * [Example 5 - Introducing testing, SimpleIoC and domain model interaction](https://github.com/davisnw/mvvm-palindrome/commit/079276a11adc6787553e24cfe973cbc9842f191b)
 * Example 6 - Introducing custom views (user controls) and data templates.
 * Example 7 - Introducing Messaging
 * Example 8 - Introducing Binding Converters / markup extensions.
 * Example 9 - Binding to Collections
 





TODO:
* MvvmLightToolkit "EventToCommand" does not appear to be available for Windows Store apps.  For WPF apps, it enables triggering a specific command when a particular event occurs.MvvmLightToolkit: EventToCommand not available for Windows Store Apps? Possible replacement is the behavior SDK, but I keep getting errors, see: , another possibility is http://winrttriggers.codeplex.com/. Or it would probably not be too difficult to implement a generic enough custom behavior to take its place? Example 4 pretty much shows how to do it in a very specific scenario - a more generic helper would need to add a dommand parameter dependency property as well.
