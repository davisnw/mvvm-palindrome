---
layout: tutorial
title:  "Why Use MVVM?"
next: WhyUseMvvm
---

Why use MVVM? Because it's a palindrome! And I like palindromes :-).

Reasons that actually matter:
1. Testability
2. Maintainability (separation of concerns)
3. "Blendability"


#Testability

MVVM allows us to obtain a high degree of unit testing for our application.  Because the view is mostly passive, and databinding is delegated to the framework, we can test most of what is presented to the user via the ViewModel, without ever needing to touch the View.

For example, if a background should turn green when the user has completed all fields, simply expose the background color as a property in the view model, and bind that property in the view.  You can then unit test the view model to ensure the property indicates green under the appropriate conditions.

Since the (Domain) Model is now completely ignorant of presentation concerns, we can more easily write unit tests for domain behavior.

We still need to check the View manually for things like aesthetics, and to ensure that the bindings are setup, but these UI level tests are no longer primarily about *behavior*. (With the exception of course of exploratory testing).

This thus encourages the [Test Pyramid](http://martinfowler.com/bliki/TestPyramid.html) pattern instead of the [Test Ice-Cream Cone](http://watirmelon.com/2012/01/31/introducing-the-software-testing-ice-cream-cone/) anti-pattern.