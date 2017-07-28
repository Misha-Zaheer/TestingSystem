<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Code.ascx.cs" Inherits="Code" %>
<asp:Label ID="Label4" runat="server" Text="Question: "></asp:Label>
<br />
<br />
<asp:TextBox ID="txtBoxQuestion" runat="server" Height="24px" Width="249px"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label5" runat="server" Text="Code: "></asp:Label>
<br />
<br />
<asp:TextBox ID="txtBoxCode" runat="server" Height="50px" Width="247px" ></asp:TextBox>
<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" Width="77px" />

