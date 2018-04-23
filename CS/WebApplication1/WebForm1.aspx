<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!--region #markup-->
            <dx:ASPxFileManager ID="ASPxFileManager1" runat="server" Width="800px" Height="400px" OnDetailsViewCustomColumnDisplayText="ASPxFileManager1_DetailsViewCustomColumnDisplayText" OnDetailsViewCustomColumnHeaderFilterFillItems="ASPxFileManager1_DetailsViewCustomColumnHeaderFilterFillItems">
                <Settings RootFolder="~\Files\" ThumbnailFolder="~\Thumb\" />
                <SettingsFileList View="Details">
                    <DetailsViewSettings>
                        <Columns>
                            <dx:FileManagerDetailsColumn Caption=" " FileInfoType="Thumbnail" VisibleIndex="0">
                            </dx:FileManagerDetailsColumn>
                            <dx:FileManagerDetailsColumn Caption="Name" VisibleIndex="1">
                            </dx:FileManagerDetailsColumn>
                            <dx:FileManagerDetailsCustomColumn Caption="Extension" Name="FileExtension" VisibleIndex="2" ShowHeaderFilterButton="True">
                            </dx:FileManagerDetailsCustomColumn>
                        </Columns>
                    </DetailsViewSettings>
                </SettingsFileList>
            </dx:ASPxFileManager>
            <!--endregion  #markup-->
        </div>
    </form>
</body>
</html>
