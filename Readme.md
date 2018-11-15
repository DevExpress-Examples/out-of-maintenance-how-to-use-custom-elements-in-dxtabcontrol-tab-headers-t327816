<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DXTabControlExample/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/DXTabControlExample/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/DXTabControlExample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXTabControlExample/MainWindow.xaml.vb))
<!-- default file list end -->
# How to: Use Custom Elements in DXTabControl Tab Headers


<p>In DXTabControl, you can customize content of tab item headers using the HeaderTemplate property. This template's DataContext contains an object specified in the Header property. So, you can use an empty binding to bind to the header:</p>


```xaml
<TextBlock Text="{Binding}"/>
```


<p>You can also customize the Glyph representation using the GlyphTemplate property.</p>

<br/>


