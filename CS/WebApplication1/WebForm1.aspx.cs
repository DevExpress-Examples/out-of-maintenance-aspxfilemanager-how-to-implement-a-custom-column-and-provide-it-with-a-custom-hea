using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1 {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        #region #CustomColumnDisplayText
        protected void ASPxFileManager1_DetailsViewCustomColumnDisplayText(object source, DevExpress.Web.FileManagerDetailsViewCustomColumnDisplayTextEventArgs e) {
            e.DisplayText = e.File.Extension.Remove(0, 1);
        }
        #endregion #CustomColumnDisplayText

        #region #CustomColumnHeaderFilterFillItems
        protected void ASPxFileManager1_DetailsViewCustomColumnHeaderFilterFillItems(object source, DevExpress.Web.FileManagerDetailsViewCustomColumnHeaderFilterFillItemsEventArgs e) {
            if (e.Column.Name != "FileExtension") return;
            e.Values.Clear();
            e.AddShowAll();
            e.AddValue("Media Files", string.Empty, "FileExtension = 'avi' or FileExtension = 'mp3' or FileExtension = 'jpg'");
            e.AddValue("Documents", string.Empty, "FileExtension = 'txt' or FileExtension = 'rtf' or FileExtension = 'xml'");
            e.AddValue("Photos", "jpg");
        }
        #endregion #CustomColumnHeaderFilterFillItems
    }
}