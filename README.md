# ExtendedSample

GETTING STARTED:

Follow below instructions for a proper use of this solution.

For netstandard project search for ExtendedControls.ExtCollectionView.XForms.1.0.0.nupkg in Visual Studio Nuget Manager and install it.

For Android project search for ExtendedControls.ExtCollectionView.XForms.Android.1.0.0.nupkg package in Visual Studio Nuget Manager and install it.

For Android project search for ExtendedControls.ExtCollectionView.XForms.UWP.1.0.0.nupkg package in Visual Studio Nuget Manager and install it.

Now you should be ready to work with ExtendedCollectionView.

I used MVVM with a simple Monkey class model, and a ViewModel as bindingcontext where i loaded a list of mokeys as ItemsSource.

KEY FEATURES:
•	Single Item Selection
•	Multiple Items Selection
•	Vertical, Horizontal and GridLayout Items orientation
•	Vertical Drag And Drop
•	Horizontal Drag And Drop
•	ItemTemplate, SelectedItemTemplate
•	Default SelectedItemColor
•	Cancel Drag and Drop
•	OnHover DragColor
•	OnHoverCancel DragColor
•	Exhaustive EventArgs

SelectionMode  - Single 
Allows you to select an item of the ExtendedCollectionView. 
SelectionMode  - Multiple 
Allows you to select more than one item of the ExtendedCollectionView. 

Items Orientation
Horizontal
Items are placed horizontally.
Vertical 
Items are stacked vertically.

GridLayout
Items are placed as in grid.
You can decide how many items per row just by using  SpanCount property

You can also decide how much space between items just by using  ItemsSpacing property

To get selectedItem(s) you can bind your property to CurrentItem property.
It will return the selecteditem in CollectionView.
Selection infos are also reported in SelectionChanging and SelectionChanged events.

With SelectedItemsChangingEventArgs you can:

-	Get previous selected item (PreviousElement)
-	Get current Selected Item (CurrentElement)
-	Cancel selection

If Cancel is set to true, selection is aborted. Clicked item will be NOT selected.

With SelectedItemsChanged you can:

-	Get previous selected item (PreviousElement)
-	Get current Selected Item (CurrentElement)
-	Get a list of selected Items (only in Multiple Selection Mode, otherwise there’ll be only one item)

Drag and Drop allows you to move one item of the CollectionView to a different position.
It works in Vertical and Horizontal layouts. (GridLayout is unavailable at the time being)
To enable Drag and Drop you have to set DragNDropEnabled property to True .
You can highlight intersected item while dragging, by setting OnHoverItemColor property. 
When the dragged item meets another item in list, last one will be colored and half matt.

You can also highlight hovered item by setting OnHoverCancelColor property. 
When drag and drop operation is intentionally aborted, hovered item will be colored and half matt.

In order to abort drag and drop operation you can exploit ItemIntersecting event.

IntersectionEventArgs returns:

IntersectingColumn: is the column where the hovered item resides (Horizontal Layout Mode)
IntersectingRow: is the row where the hovered item resides (Vertical Layout Mode)
IntersectingWith: is the item that has been hovered while dragging
TranslationX: dragged item translation distance over X axis (Horizontal Layout Mode)
TranslationY: dragged item translation distance over Y axis (Vertical Layout Mode)
Cancel: if set to True, drag over intersecting item is aborted (dragged item is set back to it’s starting position when drag is released)

ItemDragStarted  event is fired when drag operation is started.

DragStartedEventArgs returns:

StartColumn: is the column where drag operation starts (Horizontal Layout Mode)
StartRow: is the row where drag operation starts (Vertical Layout Mode)
X: item drag start postion over X axis (Horizontal Layout Mode)
Y: item drag start postion over Y axis (Vertical Layout Mode)

ItemDropped event is fired once drag operation is relased.

DropEventArgs returns:

DropColumn: the column where the item is released (Horizontal Layout Mode)
DropRow: the row where the item is released (Vertical Layout Mode)
DropPointX: the point in X axis where the item is placed after drag release (Horizontal Layout Mode)
DropPointY: the point in Y axis where the item is placed after drag release (Vertical Layout Mode)

