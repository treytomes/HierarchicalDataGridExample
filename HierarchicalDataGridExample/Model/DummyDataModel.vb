Namespace Model

	Public Class DummyDataModel

		Public Sub New(text As String, value As Decimal)
			Me.Text = text
			Me.Value = value
		End Sub

		Public ReadOnly Property Text As String

		Public ReadOnly Property Value As Decimal

	End Class

End Namespace
