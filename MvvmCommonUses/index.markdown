---
layout: tutorial
title:  "Common uses of MVVM"
next: Examples
---
#MVVM is used with some popular web UI frameworks
Notably [Knockout.js](http://knockoutjs.com/).

#MVVM is commonly used with XAML based technologies
Such as:
 * Windows Presentation Foundation (WPF) applications
 * Silverlight
 * Windows Store XAML apps

 Note that all the above make use of XAML.  I initially made the mistake of thinking that Windows Store XAML apps were using WPF. This is apparently not true, see [http://stackoverflow.com/questions/16038926/windows-8-development-wpf-or-windows-store-xaml](http://stackoverflow.com/questions/16038926/windows-8-development-wpf-or-windows-store-xaml).  Instead, all three are separate technologies with a common XAML base.  In practice, it is pretty easy to move between the three, but there are differences in capability.
 
 Also, note that while these XAML based technologies are designed to work well with the MVVM pattern, just because you are using one of these technologies does *not* mean you are using the MVVM pattern.  If you have lots of code in code-behind files, you are probably not doing MVVM.
 
 In practice, using MVVM effectively usually means adding an additional framework to your XAML based project, such as:
  * [PRISM](http://compositewpf.codeplex.com/)
  * [MVVM Light Toolkit](http://mvvmlight.codeplex.com/)
  
  For our examples, we will be utilizing the [MVVM Light Toolkit](http://mvvmlight.codeplex.com/), which is also available as a [Nuget package](http://www.nuget.org/packages/mvvmLight).
