<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="Calculator.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="html/css" href="Page1.css" />
    <title>Binary to Decimal</title>
</head>
<body>
    <form id="form1" runat="server">
    <h2>Number Conversion</h2>

        <p>
            <asp:TextBox ID="getInput" runat="server" Height="25px" Width="150px"></asp:TextBox>
            <asp:DropDownList ID="convertFrom" runat="server" style="margin-left: 30px">
            <asp:ListItem Value ="-1">Convert From ...</asp:ListItem>
            <asp:ListItem Value = "0">Binary</asp:ListItem>
            <asp:ListItem Value = "1">Decimal</asp:ListItem>
            <asp:ListItem Value = "2">Hexadecimal</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="convertTo" runat="server" style="margin-left: 61px">
            <asp:ListItem Value ="-1">Convert To ...</asp:ListItem>
            <asp:ListItem Value = "0">Binary</asp:ListItem>
            <asp:ListItem Value = "1">Decimal</asp:ListItem>
            <asp:ListItem Value = "2">Hexadecimal</asp:ListItem>
            </asp:DropDownList>

        </p>

       
        <p>
            <asp:Button ID="enterButton" runat="server" Text="Convert" OnClick="Submit_Click" />
        </p>

            <asp:TextBox ID="resultBox" runat="server"  Height="25px" Width="150px" ReadOnly="true"></asp:TextBox>



    </form>
           

    </body>

</html>
