Imports System.Collections.ObjectModel
Imports HierarchicalDataGridExample.Model

Namespace ViewModel

	Public Class DummyCategoryViewModel
		Inherits DummyDataViewModel
		Implements IHasChildren(Of DummySubCategoryViewModel)

#Region "Fields"

		Private _areChildrenVisible As Boolean
		Private _model As DummyCategoryModel

#End Region

#Region "Constructors"

		Public Sub New(model As DummyCategoryModel)
			MyBase.New(model)

			_model = model

			Children = New ObservableCollection(Of DummySubCategoryViewModel)(model.Children.Select(Function(x) New DummySubCategoryViewModel(x)))
			AreChildrenVisible = False
		End Sub

#End Region

#Region "Properties"

		Public ReadOnly Property Name As String
			Get
				Return _model.Name
			End Get
		End Property

		Public Property AreChildrenVisible As Boolean Implements IHasChildren(Of DummySubCategoryViewModel).AreChildrenVisible
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

		Public ReadOnly Property Children As ObservableCollection(Of DummySubCategoryViewModel) Implements IHasChildren(Of DummySubCategoryViewModel).Children


#End Region

#Region "Methods"

		Public Function GetEnumerator() As IEnumerator(Of DummySubCategoryViewModel) Implements IEnumerable(Of DummySubCategoryViewModel).GetEnumerator
			Return Children.GetEnumerator()
		End Function

		Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
			Return GetEnumerator()
		End Function

#End Region

	End Class

End Namespace
