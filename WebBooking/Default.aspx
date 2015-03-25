<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebBooking.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="header">
    
    </div>
        
    <div id="userInput">
        
        <asp:Label ID="NavnLabel" runat="server" Text="Navn"></asp:Label><br/>       
        <asp:TextBox ID="NavnInputTextBox" runat="server"></asp:TextBox><br/>
        <br/>
        <asp:Label ID="InnsjekkDatoLabel" runat="server" Text="Innsjekkdato"></asp:Label><br/>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <asp:Label ID="UtsjekkDatoLabel" runat="server" Text="Utsjekkdato"></asp:Label><br/>
        <asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged"></asp:Calendar>
        
   
        
    </div>
        <asp:Button ID="GodkjennKnapp" runat="server" Text="Godkjenn" OnClick="GodkjennKnapp_Click" />
    </form>
</body>
</html>
