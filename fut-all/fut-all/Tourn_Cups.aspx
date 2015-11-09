<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tourn_Cups.aspx.cs" Inherits="fut_all.Tourn_Cups" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Tournament Cups</title>
    <link href="Styles/General.css" rel="stylesheet" />
    <link href="Styles/navbar.css" rel="stylesheet" />
    <link href="Styles/navbar2.css" rel="stylesheet" />
    <link href="Styles/CircularImage.css" rel="stylesheet" />
    <link href="Styles/tables.css" rel="stylesheet" />
</head>
<body style="background-image:url('../Images/background6.jpg')">
    <form id="form1" runat="server">
    <div>
    <div>
        <nav class="navbar">                
            <ul id="menu_wrap">
                <li ><a href="Default.aspx">Log Out</a></li>
                <li ><a href="Qual_Tourn.aspx">Qualification Tournaments</a></li>
                <li ><a href="Local_Tourn.aspx">Local Tournaments</a></li>
                <li ><a href="Tourn_Cups.aspx">Tournament Cups</a></li>
                <li ><a runat="server" id="refadmin">
                <asp:Label runat="server" ID="lbladmin" Text="Admin"></asp:Label>    
                </a></li>
                &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                <asp:ImageButton runat="server" ID="imgLogoHome" src="Images/logo0.png" OnClick="imgLogoHome_Click"/>
            </ul>
        </nav>          
    </div>
    <div>
        <nav class="admenu">                
            <ul id="menu_adm" >
                &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                <li ><a runat="server" id="refsection1" href="Insert_Admins.aspx">
                    <asp:Label runat="server" ID="lblSection1" Text="Admins"></asp:Label>
                        </a></li>
                <li ><a runat="server" id="refsection2" href="Admin_Inserts.aspx">
                    <asp:Label runat="server" ID="lblSection2" Text="Insert Info"></asp:Label>
                        </a></li>
                <li ><a runat="server" id="refsection3" href="Admin_Updates.aspx">
                    <asp:Label runat="server" ID="lblsection3" Text="Update Info" ></asp:Label>
                        </a></li>
                 <li ><a runat="server" id="A1" href="Add_Tourn_Cup.aspx">
                    <asp:Label runat="server" ID="lblSection4" Text="Add New Tournament Cup" ></asp:Label>
                        </a></li>
            </ul>
        </nav>          
        </div>
        <br />
        <asp:Table runat="server"  ID="maintbl" BorderStyle="None" BackColor="White" Height="100%" Width="60%" HorizontalAlign="Center" CssClass="roundedChart">
            <asp:TableRow runat ="server">
                <asp:TableCell VerticalAlign="Bottom" BorderWidth="10px" BorderColor="White">
                    <asp:Table  runat ="server" ID="tbl" Width="100%"></asp:Table>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
