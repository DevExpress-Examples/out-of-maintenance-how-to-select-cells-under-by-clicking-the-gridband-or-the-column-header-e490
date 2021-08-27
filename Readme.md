<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128631374/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E490)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Q130069/Form1.cs) (VB: [Form1.vb](./VB/Q130069/Form1.vb))
<!-- default file list end -->
# How to select cells under by clicking the GridBand or the column header


<p>This example demonstrates how to implement selecting corresponding cells when a user clicks the GridBand or the column header. By default, the GridView uses the column header click to sort data. That is why in this sample selection is performed only when a user hold the Shift and Control keys. Also, please note that the GridView.OptionsSelection.Multiselect property should be set to true, and the GridView.OptionsSelection.MultiselectMode property should be set to CellSelect.</p>

<br/>


