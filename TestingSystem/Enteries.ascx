<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Enteries.ascx.cs" Inherits="Enteries" %>
<asp:Panel ID="Panel1" runat="server">
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
    <asp:ListItem Text="Enter one Subject and one topic" Value="1"> </asp:ListItem>
    <asp:ListItem Text="Enter one Subject and more than one topic " Value="2"> </asp:ListItem>
</asp:RadioButtonList>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="SubmitBtn1" runat="server" Text="Submit" OnClick="SubmitBtn1_Click" />
</asp:Panel>
<asp:Panel ID="Panel2" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Enter Subject"></asp:Label>
:
<asp:TextBox ID="SubTxt1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
<br />
<asp:Label ID="Label2" runat="server" Text="Enter Topic"></asp:Label>
:&nbsp;
<asp:TextBox ID="TopicTxt1" runat="server"></asp:TextBox>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


<br />
<br />
<asp:Button ID="AddMoreTopicBtn" runat="server" Text="Add more topics for the same Subject" OnClick="AddMoreTopicBtn_Click" style="height: 26px" />
<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="SubmitBtn2" runat="server" Text="Submit" OnClick="SubmitBtn2_Click" />
</asp:Panel>

<asp:Panel ID="Panel3" runat="server">
    <asp:Label ID="Label3" runat="server" Text="Enter Subject : "></asp:Label>
    &nbsp;
    <asp:TextBox ID="SubTxt2" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Enter Topic : "></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TopicTxt2" runat="server"></asp:TextBox>

    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="SubmitBtn3" runat="server" Text="Submit" OnClick="SubmitBtn3_Click" />
</asp:Panel>


