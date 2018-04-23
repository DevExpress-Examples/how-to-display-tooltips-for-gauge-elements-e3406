Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls.Primitives
Imports System.Windows.Input
Imports DevExpress.Xpf.Gauges

Namespace DXGauges_ShowTooltips

	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub


		Private Sub circularGaugeControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
				Dim hitInfo As CircularGaugeHitInfo = circularGaugeControl1.CalcHitInfo(e.GetPosition(circularGaugeControl1))

			If hitInfo.InNeedle Then
				tooltip_text.Text = "Value: " & hitInfo.Needle.Value.ToString("n2")
				tooltip.Placement = PlacementMode.Mouse

				tooltip.IsOpen = True
			Else
				tooltip.IsOpen = False
			End If

		End Sub

		Private Sub circularGaugeControl1_MouseLeave(ByVal sender As Object, ByVal e As MouseEventArgs)
			tooltip.IsOpen = False
		End Sub

	End Class
End Namespace
