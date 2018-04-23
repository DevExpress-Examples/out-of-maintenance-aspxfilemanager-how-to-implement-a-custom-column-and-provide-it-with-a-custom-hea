Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace WebApplication1
    Partial Public Class WebForm1
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        #Region "#CustomColumnDisplayText"
        Protected Sub ASPxFileManager1_DetailsViewCustomColumnDisplayText(ByVal source As Object, ByVal e As DevExpress.Web.FileManagerDetailsViewCustomColumnDisplayTextEventArgs)
            e.DisplayText = e.File.Extension.Remove(0, 1)
        End Sub
        #End Region ' #CustomColumnDisplayText

        #Region "#CustomColumnHeaderFilterFillItems"
        Protected Sub ASPxFileManager1_DetailsViewCustomColumnHeaderFilterFillItems(ByVal source As Object, ByVal e As DevExpress.Web.FileManagerDetailsViewCustomColumnHeaderFilterFillItemsEventArgs)
            If e.Column.Name <> "FileExtension" Then
                Return
            End If
            e.Values.Clear()
            e.AddShowAll()
            e.AddValue("Media Files", String.Empty, "FileExtension = 'avi' or FileExtension = 'mp3' or FileExtension = 'jpg'")
            e.AddValue("Documents", String.Empty, "FileExtension = 'txt' or FileExtension = 'rtf' or FileExtension = 'xml'")
            e.AddValue("Photos", "jpg")
        End Sub
        #End Region ' #CustomColumnHeaderFilterFillItems
    End Class
End Namespace