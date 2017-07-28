<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MainUserControl.ascx.cs" Inherits="MainUserControl" %>
<%@ Register Src="~/Code.ascx" TagPrefix="uc1" TagName="Code" %>
<%@ Register Src="~/MCQ.ascx" TagPrefix="uc1" TagName="MCQ" %>

<asp:Label ID="Label1" runat="server" Text="Select Subject"></asp:Label>
&nbsp;&nbsp;
<asp:DropDownList ID="ddl1" runat="server" OnSelectedIndexChanged="ddl1_SelectedIndexChanged" AutoPostBack="True">
</asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label2" runat="server" Text="Select Topic"></asp:Label>
:&nbsp;&nbsp;
<asp:DropDownList ID="ddl2" runat="server" AutoPostBack="True"></asp:DropDownList>
<br />
<br />
&nbsp;&nbsp;&nbsp;<asp:Button ID="AddSubjectAndTopic" runat="server" Text="Add more subject and topic" Height="28px" Width="282px" OnClick="AddSubjectAndTopic_Click" />
&nbsp; 
<br />
<br />
<asp:Label ID="Label3" runat="server" Text="Select Complexity level"></asp:Label>
:<asp:RadioButtonList ID="RadioButtonList1" runat="server">
    <asp:ListItem Text="Hard" Value="1"> </asp:ListItem>
    <asp:ListItem Text="Medium " Value="2"> </asp:ListItem>
    <asp:ListItem Text="Low" Value="3"> </asp:ListItem>
 </asp:RadioButtonList>
<br />
<asp:Label ID="Label4" runat="server" Text="Enter Points :"></asp:Label>
&nbsp;
<asp:TextBox ID="txtofPoints" runat="server"></asp:TextBox>
<br />
<br />
<asp:Label ID="ddllabel" runat="server" Text="Select any option : "></asp:Label>
&nbsp;&nbsp;
<asp:DropDownList ID="ddlTypeSelection" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTypeSelection_SelectedIndexChanged">
     <asp:ListItem Selected="True" Value="0" Text="Select"></asp:ListItem>
    <asp:ListItem Value="1" Text="MCQ"></asp:ListItem>
    <asp:ListItem Value="2" Text="Code"></asp:ListItem>
</asp:DropDownList>
<br />
<br />
<asp:PlaceHolder ID="MCQPlaceHolder" runat="server">
    <uc1:MCQ runat="server" ID="MCQ" />
</asp:PlaceHolder>
<br />
<br />
<asp:PlaceHolder ID="CodePlaceHolder" runat="server">
    <uc1:Code runat="server" ID="Code" />
</asp:PlaceHolder>
