<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DXGauges_ShowTooltips/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/DXGauges_ShowTooltips/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/DXGauges_ShowTooltips/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXGauges_ShowTooltips/MainWindow.xaml.vb))
<!-- default file list end -->
# How to display tooltips for gauge elements


<p>This example demonstrates how to show a tooltip with the current value of a needle on a circular gauge.</p>


<h3>Description</h3>

<p>To display the current <a href="http://documentation.devexpress.com/#WPF/CustomDocument9957"><u>needle</u></a>&#39;s value in a tooltip, it is necessary to handle the<strong> MouseMove</strong> and <strong>MouseLeave</strong> events for the CircularGaugeControl object and obtain the current mouse position on a scale via the<a href="http://documentation.devexpress.com/#WPF/DevExpressXpfGaugesCircularGaugeControl_CalcHitInfotopic"><u> CircularGaugeControl.CalcHitInfo</u></a> method. After that, if the mouse pointer hovers over the needle, it becomes possible to invoke the tooltip that displays the current needle&#39;s value.</p><p><br />
Note that this approach is applicable to only those gauge elements whose <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfGaugesValueIndicatorBase_IsHitTestVisibletopic"><u>IsHitTestVisible</u></a> property is set to <strong>True </strong>(this is the default option). If the <strong>IsHitTestVisible </strong>property is set to <strong>False</strong>, this element is excluded from the hit-testing algorithm. To explore this behavior in action, mark and unmark the &quot;Show tooltips for a needle&quot; <a href="http://documentation.devexpress.com/#WPF/clsDevExpressXpfEditorsCheckEdittopic"><u>CheckEdit</u></a> (whose check state is bound to the needle&#39;s <strong>IsHitTestVisible </strong>property). So, the unmarked CheckEdit&#39;s state means that tooltips are not displayed for a needle. </p>

<br/>


