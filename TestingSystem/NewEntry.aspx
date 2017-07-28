<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewEntry.aspx.cs" Inherits="NewEntry" %>

<%@ Register Src="~/Enteries.ascx" TagPrefix="uc1" TagName="Enteries" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:Enteries runat="server" ID="Enteries" />
    </div>
    </form>
</body>
</html>
