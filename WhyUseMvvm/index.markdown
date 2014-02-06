---
layout: tutorial
title:  "Why Use MVVM?"
next: MvvmCommonUses
---

Why use MVVM? Because it's a palindrome! And I like palindromes :-).

Reasons that actually matter:
1. Testability
2. Maintainability
3. "Blendability"


#Testability

MVVM allows us to obtain a high degree of unit testing for our application.  Because the view is mostly passive, and databinding is delegated to the framework, we can test most of what is presented to the user via the ViewModel, without ever needing to touch the View.

For example, if a background should turn green when the user has completed all fields, simply expose the background color as a property in the view model, and bind that property in the view.  You can then unit test the view model to ensure the property indicates green under the appropriate conditions.

Since the (Domain) Model is now completely ignorant of presentation concerns, we can more easily write unit tests for domain behavior.

We still need to check the View manually for things like aesthetics, and to ensure that the bindings are setup, but these UI level tests are no longer primarily about *behavior*. (With the exception of course of exploratory testing).

This thus encourages the [Test Pyramid](http://martinfowler.com/bliki/TestPyramid.html) pattern instead of the [Test Ice-Cream Cone](http://watirmelon.com/2012/01/31/introducing-the-software-testing-ice-cream-cone/) anti-pattern.

#Maintainability
The MVVM pattern encourages the "Single Responsibility Principal" of [SOLID](http://en.wikipedia.org/wiki/SOLID_%28object-oriented_design%29), [Separation of Concerns](http://en.wikipedia.org/wiki/Separation_of_concerns) by enabling [Separated Presentation](http://martinfowler.com/eaaDev/SeparatedPresentation.html)

This means that we can replace individual components in a more isolated fashion.

Also, the ability to expand testing improves maintainability, because we can now quickly know when we break a previously working behavior.

#"Blendabilty"
"Blendability" is the term used by Laurent Bugnion (primary author of the MVVM Light framework). It basically means "the ability to edit in Blend".

The primary reason this is important, is that it potentially allows you to have a separate design team that can design the look and feel of the application independently (more or less) from the programmers implementing application behavior.

It is also important if you prefer to work in visual designers.

Personally, I generally prefer to work directly in markup (whether it's html or XAML).  About the only time I used Blend was for setting up animations and transitions.

While the term used here directly relates to Microsoft Blend, the broader concept could also apply to the html templates used by Knockout.js.

Also note that what is discussed about enabling Blend also applies to the Visual Studio designer.

The following are my notes from the  [TechDays 2010: Understanding the Model-View-ViewModel pattern](http://www.galasoft.ch/mvvmvideo1) presentation:

For the this to work, we need two things:

1. We need to be able to tell Blend to ignore certain parts the code
   * This is because Blend is actually loading application and running it.
   * There are certain things that Blend cannot run such as connecting to a WCF Service or a database.  There may also be things we don't want it to run.
2. We need to be able to create design-time data (very hard to style an empty list control!)

Thus we distinguish between design time and run time mode:
  * This gives us the ability to show consistent data for the purposes of UI design.
  * This also means that UI work can be done independently of other parts of the application - however, for this to work well you need to specify consistent code interface between the different teams.


