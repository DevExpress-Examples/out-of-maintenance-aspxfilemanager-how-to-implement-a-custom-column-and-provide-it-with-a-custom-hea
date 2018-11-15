<!-- default file list -->
*Files to look at*:

* [WebForm1.aspx](./CS/WebApplication1/WebForm1.aspx) (VB: [WebForm1.aspx.vb](./VB/WebApplication1/WebForm1.aspx.vb))
* [WebForm1.aspx.cs](./CS/WebApplication1/WebForm1.aspx.cs) (VB: [WebForm1.aspx.vb](./VB/WebApplication1/WebForm1.aspx.vb))
<!-- default file list end -->
# ASPxFileManager - How to implement a custom column and provide it with a custom header filter


<p>The <a href="http://help.devexpress.com/#AspNet/clsDevExpressWebASPxFileManagertopic">ASPxFileManager</a> control allows you to provide <a href="http://help.devexpress.com/#AspNet/CustomDocument17537">custom columns</a> in <strong>Details</strong> <a href="http://help.devexpress.com/#AspNet/CustomDocument14550">view mode</a>.</p>
<p>To implement a custom column, add an object of the <a href="http://help.devexpress.com/#AspNet/clsDevExpressWebFileManagerDetailsCustomColumntopic">FileManagerDetailsCustomColumn</a> class to the <a href="http://help.devexpress.com/#AspNet/DevExpressWebFileManagerFileListDetailsViewSettings_Columnstopic">Columns</a> collection. When a custom column cell is rendered, the <a href="http://help.devexpress.com/#AspNet/DevExpressWebASPxFileManager_DetailsViewCustomColumnDisplayTexttopic">DetailsViewCustomColumnDisplayText</a> event fires allowing you to provide custom display text.</p>
<p>You can enable a header filter for a custom column by using the <a href="http://help.devexpress.com/#AspNet/DevExpressWebFileManagerDetailsCustomColumn_ShowHeaderFilterButtontopic">ShowHeaderFilterButton</a> property. To provide header filter with custom items, use the <a href="http://help.devexpress.com/#AspNet/DevExpressWebASPxFileManager_DetailsViewCustomColumnHeaderFilterFillItemstopic">DetailsViewCustomColumnHeaderFilterFillItems</a> event.</p>
<p>This example demonstrates how to provide a file manager with a column containing file extensions, and how to populate the column's header filter with custom items.</p>

<br/>


