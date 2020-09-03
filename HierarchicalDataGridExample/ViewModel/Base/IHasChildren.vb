Imports System.Collections.ObjectModel

Namespace ViewModel

	Public Interface IHasChildren(Of TChild As ICanBeHidden)
		Inherits IEnumerable(Of TChild)

		Property AreChildrenVisible As Boolean
		ReadOnly Property Children As ObservableCollection(Of TChild)
	End Interface

End Namespace
