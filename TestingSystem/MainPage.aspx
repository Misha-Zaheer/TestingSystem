<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainPage.aspx.cs" Inherits="MainPage" %>

<%@ Register Src="~/MainUserControl.ascx" TagPrefix="uc1" TagName="MainUserControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:MainUserControl runat="server" ID="MainUserControl" />
    </div>
    </form>
</body>
</html>
