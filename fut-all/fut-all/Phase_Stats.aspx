<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Phase_Stats.aspx.cs" Inherits="fut_all.Group_Stats" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <nav class="navbar">                
                <ul id="menu_wrap">
                    <li ><a href="Default.aspx">Log Out</a></li>
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
                    <li ><a runat="server" id="refsection1">
                        <asp:Label runat="server" ID="lblSection1" Text="Admins"></asp:Label>
                         </a></li>
                    <li ><a runat="server" id="refsection2" href="Admin_Inserts.aspx">
                        <asp:Label runat="server" ID="lblSection2" Text="Insert Info"></asp:Label>
                         </a></li>
                    <li ><a runat="server" id="refsection3" href="Admin_Updates.aspx">
                        <asp:Label runat="server" ID="lblsection3" Text="Update Info"></asp:Label>
                         </a></li>
               </ul>
            </nav>          
        </div>
    </div>
    </form>
</body>
</html>
