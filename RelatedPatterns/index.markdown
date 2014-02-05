---
layout: tutorial
title:  "Related Patterns"
next: RelatedPatterns
---

MVVM evolved from and is related to several other patterns.

Note that from a coding perspective, all of these patterns eliminate (or nearly so) the use of a "code behind" file.

#[Model View Controller Pattern](http://martinfowler.com/eaaDev/uiArchs.html) (MVC)
  * A way of achieving [Separated Presentation](http://martinfowler.com/eaaDev/SeparatedPresentation.html) - that is keep our presentation logic and our domain logic from interfering with each other.
  * Often used with a [Presentation Model](http://martinfowler.com/eaaDev/PresentationModel.html)
  * Roles:
    - **Model** (ignorant of the UI, contains data and behavior - type of behavior depends on whether you are using a domain model directly, or a presentation model)
	- **View** (Observes the UI and renders its data)
	- **Controller** (Processes the user's input)
  * Basic flow:

    [![MVC Flow](../images/mvc.svg)](../images/mvc.svg)

#[Passive View Pattern](http://martinfowler.com/eaaDev/PassiveScreen.html)
  * The view doesn't "do anything" 
  * The view has *no* behavior
  * The view does *not* maintain any state
  * The view is *not* responsible for updating itself (the controller is entirely responsible for updating the view).
  * As a result, the view does *not* require unit tests.
  * Basic flow:

  [![Passive View Flow](../images/pvp.svg)](../images/pvp.svg)
  
#[Presentation Model Pattern](http://martinfowler.com/eaaDev/PresentationModel.html)
  * Contains state and logic specific to *presentation* concerns
  * Pulls behavior from the view, so that presentation logic can be more easily tested.
  * View may still maintain "control" state (e.g. for UI widgets), but all *dynamic* behavior is pulled to the presentation model.
  * A binding synchronization mechanism is required between the Presentation Model and the View.
  * Acts as "an abstract of the view that is not dependent on a specific GUI framework" (Martin Fowler)
  * A view interacts with one presentation model, but the presentation model may be reused by multiple views.
 
#Model View ViewModel Pattern
Combining the preceding patterns, we get the MVVM pattern:

[![Model View ViewModel Flow](../images/mvvm.svg)](../images/mvvm.svg)


