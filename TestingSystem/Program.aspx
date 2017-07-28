<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Program.aspx.cs" Inherits="Program" %>

<%@ Register Src="~/Code.ascx" TagPrefix="uc1" TagName="Code" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:Code runat="server" ID="Code" />
    </div>
    </form>
</body>
</html>
