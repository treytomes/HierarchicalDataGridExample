Imports HierarchicalDataGridExample.Model

Namespace ViewModel

	Public Class DummyRowViewModel
		Inherits DummyDataViewModel

#Region "Fields"

		Private ReadOnly _model As DummyRowModel

#End Region

#Region "Constructors"

		Public Sub New(model As DummyRowModel)
			MyBase.New(model)

			_model = model
		End Sub

#End Region

#Region "Properties"

		Public ReadOnly Property Name As String
			Get
				Return _model.Name
			End Get
		End Property

#End Region

	End Class

End Namespace
