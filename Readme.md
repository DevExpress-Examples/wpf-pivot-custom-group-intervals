<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128578751/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2132)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Pivot Grid for WPF - Custom Group Intervals

This example shows how to implement custom group intervals in Pivot Grid to group axis values.

<!-- default file list -->
## Files to Look at

* [MainWindow.xaml](./CS/HowToCustomGroupInterval/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/HowToCustomGroupInterval/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/HowToCustomGroupInterval/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/HowToCustomGroupInterval/MainWindow.xaml.vb))
<!-- default file list end -->

## Overview

The _Product Groups_ calculated field is bound to the following expression:

`Iif(Substring([fieldProductName], 0, 1) &lt; 'F', 'A-E', Substring([fieldProductName], 0, 1) &lt; 'T', 'F-S', 'T-Z')`

The expression groups the _Product Name_ field's values into three large ranges: A-E, F-S, and T-Z according to product's start characters.

![pivot-custom-group-intervals](image/image.png)

## Documentaton

[Grouping](https://docs.devexpress.com/WPF/8061/controls-and-libraries/pivot-grid/data-shaping/grouping)

## More Examples

[Pivot Grid for WPF - How to Group Date-Time Values](https://github.com/DevExpress-Examples/how-to-group-date-time-values-e2131)




