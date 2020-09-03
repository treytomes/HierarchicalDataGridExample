Namespace Model

	Public Class DummyCategoryModel
		Inherits DummyDataModel

		Public Sub New(name As String, text As String, value As Decimal, children As IEnumerable(Of DummySubCategoryModel))
			MyBase.New(text, value)

			Me.Name = name
			Me.Children = New List(Of DummySubCategoryModel)(children)
		End Sub

		Public ReadOnly Property Name As String

		Public ReadOnly Property Children As IEnumerable(Of DummySubCategoryModel)

	End Class

End Namespace
