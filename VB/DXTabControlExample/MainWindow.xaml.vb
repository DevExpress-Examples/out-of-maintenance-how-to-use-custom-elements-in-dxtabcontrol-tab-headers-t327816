Imports DevExpress.Xpf.Core
Imports System.Windows
Imports System.Windows.Controls

Namespace DXTabControlExample

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits DXWindow

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub BarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            MessageBox.Show("Hello!")
        End Sub
    End Class
End Namespace
