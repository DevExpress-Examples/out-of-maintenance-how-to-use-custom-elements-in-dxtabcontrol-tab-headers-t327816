<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128642289/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T327816)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DXTabControlExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXTabControlExample/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DXTabControlExample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXTabControlExample/MainWindow.xaml.vb))
<!-- default file list end -->
# How to: Use Custom Elements in DXTabControl Tab Headers


<p>In DXTabControl, you can customize content of tab item headers using the HeaderTemplate property. This template's DataContext contains an object specified in the Header property. So, you can use an empty binding to bind to the header:</p>


```xaml
<TextBlock Text="{Binding}"/>
```


<p>You can also customize the Glyph representation using the GlyphTemplate property.</p>

<br/>


