Imports System.ComponentModel
Imports HierarchicalDataGridExample.Model
Imports Prism.Mvvm

Namespace ViewModel

	Public Class DummyDataViewModel
		Inherits BindableBase
		Implements ICanBeHidden

#Region "Fields"

		Private _isVisible As Boolean
		Private ReadOnly _model As DummyDataModel

#End Region

#Region "Constructors"

		Public Sub New(model As DummyDataModel)
			MyBase.New()

			_isVisible = True
			_model = model
		End Sub

		Public Property IsVisible As Boolean Implements ICanBeHidden.IsVisible
			Get
				Return _isVisible
			End Get
			Set
				SetProperty(_isVisible, Value)
			End Set
		End Property

#End Region

#Region "Properties"

		Public ReadOnly Property Text As String
			Get
				Return _model.Text
			End Get
		End Property

		Public ReadOnly Property Value As Decimal
			Get
				Return _model.Value
			End Get
		End Property

#End Region

	End Class

End Namespace
