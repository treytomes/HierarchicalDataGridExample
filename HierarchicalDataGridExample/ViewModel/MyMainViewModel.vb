Imports HierarchicalDataGridExample.Model

Namespace ViewModel

	Public Class MyMainViewModel
		Inherits HierarchicalDataViewModel(Of DummyDataViewModel)

#Region "Fields"

		Private ReadOnly _model As IEnumerable(Of DummyCategoryModel)

#End Region

#Region "Constructors"

		Public Sub New()
			_model = DummyRepository.GetData()

			LoadData()
		End Sub

#End Region

#Region "Methods"

		Private Sub LoadData()
			For Each category As DummyDataViewModel In _model.Select(Function(x) New DummyCategoryViewModel(x))
				AddData(category)
			Next
		End Sub

#End Region

	End Class

End Namespace
