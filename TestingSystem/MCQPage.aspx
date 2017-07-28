<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/MCQPage.aspx.cs" Inherits="MCQPage" %>

<%@ Register Src="~/MCQ.ascx" TagPrefix="uc1" TagName="MCQ" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:MCQ runat="server" ID="MCQ" />
    </div>
    </form>
</body>
</html>
