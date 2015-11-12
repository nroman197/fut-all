<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tourn_Cup_Phase_Matches.aspx.cs" Inherits="fut_all.Tourn_Cup_Group_Matches" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Styles/FlagImage.css" rel="stylesheet" />
    <link href="Styles/CircularImage.css" rel="stylesheet" />
    <link href="Styles/General.css" rel="stylesheet" />
    <link href="Styles/navbar.css" rel="stylesheet" />
    <link href="Styles/navbar2.css" rel="stylesheet" />
    <link href="Styles/tables.css" rel="stylesheet" />
    <link href="Styles/phasesddls.css" rel="stylesheet" />
    <link rel="shortcut icon" type ="image/x-icon" href="Images/futicon.ico" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Tournament Cup Group Matches</title>
</head>
<body style="background-image:url('../Images/bg5.jpg')">
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
<%--        <nav class="admenu">                
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
            </ul>
        </nav> --%>         
        </div>
        <br />
        <asp:Table runat="server"  ID="maintbl" BorderStyle="None" BackColor="White" Height="100%" Width="40%" HorizontalAlign="Center" CssClass="roundedChart">
            <asp:TableRow runat ="server">                
                <asp:TableCell VerticalAlign="Bottom" BorderWidth="10px" BorderColor="White">
                    <asp:Table  runat ="server" ID="tbl" Width="100%"></asp:Table>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Table runat="server" HorizontalAlign="Center">
                        <asp:TableRow HorizontalAlign="Center">
                            <asp:TableCell HorizontalAlign="Center">
                            <asp:DropDownList runat="server" ID="ddl1" CssClass="ddl" Width="100px"></asp:DropDownList>                                                                       
                         </asp:TableCell>
                            <asp:TableCell HorizontalAlign="Center" Width="30px">
                                <asp:Label runat="server" ID="vs" Text="VS" Font-Size="Larger" CssClass="lblFont" ></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell HorizontalAlign="Center">
                               <asp:DropDownList runat="server" ID="ddl2" CssClass="ddl" Width="100px"></asp:DropDownList>                                      
                            </asp:TableCell>
                            <asp:TableCell HorizontalAlign="Center">
                                <asp:Button runat="server" ID="btnSaveInfo" CssClass="btn" Text="Add match" OnClick="btnSaveInfo_Click" />
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                            <br />
                                </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </asp:TableCell>
                                
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
