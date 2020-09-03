Namespace Model

	Public Class DummyRowModel
		Inherits DummyDataModel

		Public Sub New(name As String, text As String, value As Decimal)
			MyBase.New(text, value)

			Me.Name = name
		End Sub

		Public ReadOnly Property Name As String

	End Class

End Namespace
