Imports HierarchicalDataGridExample.ViewModel

Class Application

	Private Sub Application_Startup(pSender As Object, pEventArgs As StartupEventArgs)
		Dim oMainWorkspace As New MyMainViewModel()

		MainWindow = New MainWindow() With
			{
				.DataContext = oMainWorkspace
			}
		MainWindow.Show()
	End Sub

End Class
