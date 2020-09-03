Imports System.Collections.ObjectModel
Imports HierarchicalDataGridExample.Model

Namespace ViewModel

	Public Class DummySubCategoryViewModel
		Inherits DummyDataViewModel
		Implements IHasChildren(Of DummyRowViewModel)

#Region "Fields"

		Private _areChildrenVisible As Boolean
		Private _model As DummySubCategoryModel

#End Region

#Region "Constructors"

		Public Sub New(model As DummySubCategoryModel)
			MyBase.New(model)

			_model = model

			Children = New ObservableCollection(Of DummyRowViewModel)(model.Children.Select(Function(x) New DummyRowViewModel(x)))
			AreChildrenVisible = False
		End Sub

#End Region

#Region "Properties"

		Public ReadOnly Property Name As String
			Get
				Return _model.Name
			End Get
		End Property

		Public Property AreChildrenVisible As Boolean Implements IHasChildren(Of DummyRowViewModel).AreChildrenVisible
			Get
				Return _areChildrenVisible
			End Get
			Set
				For Each data As ICanBeHidden In Children
					data.IsVisible = Value
				Next
				SetProperty(_areChildrenVisible, Value)
			End Set
		End Property

		Public ReadOnly Property Children As ObservableCollection(Of DummyRowViewModel) Implements IHasChildren(Of DummyRowViewModel).Children

#End Region

#Region "Methods"

		Public Function GetEnumerator() As IEnumerator(Of DummyRowViewModel) Implements IEnumerable(Of DummyRowViewModel).GetEnumerator
			Return Children.GetEnumerator()
		End Function

		Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
			Return GetEnumerator()
		End Function

#End Region

	End Class

End Namespace
