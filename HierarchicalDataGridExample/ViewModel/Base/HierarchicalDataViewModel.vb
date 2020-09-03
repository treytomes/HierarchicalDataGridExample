Imports System.Collections.ObjectModel
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports Prism.Mvvm

Namespace ViewModel

	''' <summary>
	''' Defines a hierarchical relationship between parent and child viewmodels.
	''' </summary>
	''' <typeparam name="TBase">The base class shared by the parent and child viewmodels.</typeparam>
	Public MustInherit Class HierarchicalDataViewModel(Of TBase As ICanBeHidden)
		Inherits BindableBase

#Region "Fields"

		Private _selectedItem As TBase

#End Region

#Region "Constructors"

		Public Sub New()
			MyBase.New()

			AddHandler DisplayData.CollectionChanged, AddressOf DisplayData_CollectionChanged

			DisplayDataSource = CollectionViewSource.GetDefaultView(DisplayData)
			DisplayDataSource.Filter = AddressOf DisplayDataSource_Filter
		End Sub

#End Region

#Region "Properties"

		''' <summary>
		''' Bind your DataGrid to this property to have your hierarchical data handled correctly.
		''' </summary>
		''' <returns></returns>
		Public ReadOnly Property DisplayDataSource As ICollectionView

		Public Property SelectedItem As TBase
			Get
				Return _selectedItem
			End Get
			Set
				SetProperty(_selectedItem, Value)
			End Set
		End Property

		Private ReadOnly Property DisplayData As New ObservableCollection(Of TBase)

#End Region

#Region "Methods"

		''' <summary>
		''' Use this to add hierarchical data to your view.
		''' </summary>
		''' <param name="obj"></param>
		Protected Sub AddData(obj As TBase)
			DisplayData.Add(obj)

			If TypeOf obj Is IEnumerable Then
				For Each child As TBase In DirectCast(obj, IEnumerable)
					AddData(child)
				Next
			End If
		End Sub

#End Region

#Region "Event Handlers"

		Private Function DisplayDataSource_Filter(obj As Object) As Boolean
			If TypeOf obj Is ICanBeHidden Then
				Dim parent As TBase = DirectCast(DisplayData.OfType(Of IEnumerable)().SingleOrDefault(Function(x) x.OfType(Of Object).Contains(obj)), TBase)
				If (parent Is Nothing) OrElse parent.IsVisible Then
					Return DirectCast(obj, ICanBeHidden).IsVisible
				End If
			End If
			Return False
		End Function

		Private Sub DisplayData_CollectionChanged(sender As Object, e As NotifyCollectionChangedEventArgs)
			Select Case e.Action
				Case NotifyCollectionChangedAction.Add
					For Each oItem As Object In e.NewItems
						If (TypeOf oItem Is INotifyPropertyChanged) Then
							AddHandler DirectCast(oItem, INotifyPropertyChanged).PropertyChanged, AddressOf Child_PropertyChanged
						End If
					Next

				Case NotifyCollectionChangedAction.Remove
					For Each oItem As Object In e.OldItems
						If TypeOf oItem Is INotifyPropertyChanged Then
							RemoveHandler DirectCast(oItem, INotifyPropertyChanged).PropertyChanged, AddressOf Child_PropertyChanged
						End If
					Next

			End Select
		End Sub

		Private Sub Child_PropertyChanged(sender As Object, e As PropertyChangedEventArgs)
			DisplayDataSource.Refresh()
		End Sub

#End Region

	End Class

End Namespace
