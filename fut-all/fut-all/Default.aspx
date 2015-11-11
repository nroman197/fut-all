<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="fut_all.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="shortcut icon" type ="image/x-icon" href="Images/futicon.ico" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Styles/Default.css" rel="stylesheet" />
    <link href="Styles/General.css" rel="stylesheet" />
    <link href="Styles/CircularImage.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

    <div>
        <br />
        <br />
        <asp:Table runat="server" BorderStyle="None" BackColor="White" Height="580px" Width="450px" HorizontalAlign="Center" CssClass="roundedChart">
            <asp:TableRow runat="server" Height="100px">
                <%-- logo here --%>           
                <asp:TableCell HorizontalAlign="Center">
                    <br /><br /><br />                    
                    <asp:Image runat="server" src="Images/logo2.png"  ImageAlign="Middle"/>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server" HorizontalAlign="Center"  Width="100%">
                    <div runat="server">                        
                        <asp:Label runat="server" ID="lblEmail" Text="Email" CssClass="lblFont" ></asp:Label>
                        <asp:Label runat="server" ID="Label2" Text="" Width="170px" ></asp:Label>                                              
                        <br />
                        <asp:TextBox runat="server" ID ="txbEmail" CssClass="txbClass" TextMode="Email" required="true"></asp:TextBox >
                        <br />
                        <br />                        
                        <asp:Label runat="server" ID="lblPassword" Text="Password" CssClass="lblFont" ></asp:Label>
                        <asp:Label runat="server" ID="Label3" Text="" Width="140px" ></asp:Label>
                        <br />
                        <asp:TextBox runat="server" ID ="txbPassword" CssClass="txbClass" TextMode="Password" required="true"></asp:TextBox >
                        <div >
                            <br />
                            <br />
                            <asp:Button runat="server" ID="btnSignIn" Text="Sign In" CssClass="btn" OnClick="btnSignIn_Click" OnClientClick="return confirm('Are you sure to create user?');" />
                            <asp:Label runat="server" ID="Label1" Text="" Width="48px" ></asp:Label>
                            <asp:Button runat="server" ID="btnLogIn" Text="Log In"  CssClass="btn"  OnClick="btnLogIn_Click"/>
                        </div>
                    </div>                    
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
