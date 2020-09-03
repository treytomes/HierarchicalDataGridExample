Namespace Model

	Public Class DummySubCategoryModel
		Inherits DummyDataModel

		Public Sub New(name As String, text As String, value As Decimal, children As IEnumerable(Of DummyRowModel))
			MyBase.New(text, value)

			Me.Name = name
			Me.Children = New List(Of DummyRowModel)(children)
		End Sub

		Public ReadOnly Property Name As String

		Public ReadOnly Property Children As IEnumerable(Of DummyRowModel)

	End Class

End Namespace
