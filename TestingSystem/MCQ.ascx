<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MCQ.ascx.cs" Inherits="MCQ" %>
    <asp:Label ID="Label5" runat="server" Text="Enter Question Statement: "></asp:Label>
&nbsp;<asp:TextBox ID="txtofQstat" runat="server"></asp:TextBox> &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
&nbsp;<br /> <br />
<asp:CheckBox ID="CheckBox1" runat="server" /> &nbsp;
<asp:TextBox ID="textofOption" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="AddBtn" runat="server" Text="Add" OnClick="AddBtn_Click" />
<br /><br />
    <asp:Label ID="options" runat="server" Text="All Entered options :"></asp:Label>
    <br /><br />
<asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
     <HeaderTemplate>
    </HeaderTemplate>
    <ItemTemplate>
        <asp:CheckBox Checked='<%# Eval("Status") %>' ID="cbrptopic" runat="server" />
        <asp:Label Text='<%# Eval ("Option") %>' ID="lbrptopic" runat="server"></asp:Label>
        <br />
    </ItemTemplate>
    <FooterTemplate>
    </FooterTemplate>
</asp:Repeater>
<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="SubmitQues" runat="server" Text="Submit Question" Height="30px" Width="188px" OnClick="SubmitQues_Click" />