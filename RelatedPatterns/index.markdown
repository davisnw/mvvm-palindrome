---
layout: tutorial
title:  "Related Patterns"
next: RelatedPatterns
---

MVVM evolved from and is related to several other patterns.

[Model View Controller Pattern](http://martinfowler.com/eaaDev/uiArchs.html) (MVC)
  * TODO: PEAA references?
  * A way of achieving [Separated Presentation](http://martinfowler.com/eaaDev/SeparatedPresentation.html) - that is keep our presentation logic and our domain logic from interfering with each other.
  * Often used with a [Presentation Model](http://martinfowler.com/eaaDev/PresentationModel.html)
  * Roles:
    - Model (ignorant of the UI, contain data and behavior - type of behavior depends on whether you are using a domain model directly, or a presentation model)
	- View (Observe the UI and render its data)
	- Controller (Processes the user's input)
  * Basic Flow:
    [![MVC Flow](../images/mvc.svg)](../images/mvc.svg)

[Passive View Pattern](http://martinfowler.com/eaaDev/PassiveScreen.html)
  * The view doesn't "do anything" - no behavior - doesn't need /unit/ tests
  * TODO: need to expand on what we mean here by "no behavior"
  
[Presentation Model Pattern](http://martinfowler.com/eaaDev/PresentationModel.html)


Combining these three patterns, we get to the MVVM pattern via the following progression:

