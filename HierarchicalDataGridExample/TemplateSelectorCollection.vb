Public Class TemplateSelectorCollection
	Inherits DataTemplateSelector

	Public ReadOnly Property Templates As New List(Of DataTemplate)

	Public Overrides Function SelectTemplate(item As Object, container As DependencyObject) As DataTemplate
		Dim elem As FrameworkElement = TryCast(container, FrameworkElement)

		If (elem IsNot Nothing) AndAlso (item IsNot Nothing) AndAlso Templates.Any(Function(x) x.DataType Is item.GetType()) Then
			Return Templates.First(Function(x) x.DataType Is item.GetType())
		End If

		Return Nothing
	End Function

End Class
