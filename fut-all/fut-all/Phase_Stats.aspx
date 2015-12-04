<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Phase_Stats.aspx.cs" Inherits="fut_all.Group_Stats" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Styles/navbar.css" rel="stylesheet" />
    <link href="Styles/navbar2.css" rel="stylesheet" />
    <link href="Styles/General.css" rel="stylesheet" />
    <link href="Styles/tables.css" rel="stylesheet" />
    <link href="Styles/tbxPhases.css" rel="stylesheet" />
    <link href="Styles/CircularImage.css" rel="stylesheet" />
    <link href="Styles/FlagImage.css" rel="stylesheet" />
    <link rel="shortcut icon" type ="image/x-icon" href="Images/futicon.ico" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Phase Stats</title>
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
                <asp:Image  runat="server" src="Images/logo0.png"/>
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
        </nav>--%>          
        </div>
        <br />
        <asp:Table runat="server"  ID="maintbl" BorderStyle="None" BackColor="White" Height="100%" Width="70%" HorizontalAlign="Center" CssClass="roundedChart">
            <asp:TableRow>
                                     <asp:TableCell>
                    &nbsp&nbsp<asp:Label runat="server" ID="Label3" Text="Group Stats!" Font-Size="XX-Large" CssClass="lblFont" ></asp:Label><br /><br />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat ="server">
                <asp:TableCell VerticalAlign="Bottom" BorderWidth="10px" BorderColor="White">
               
                    &nbsp&nbsp<asp:Label runat="server" ID="Label1" Text="" Font-Size="Larger" CssClass="lblFont3" ></asp:Label><br /><br />
                    <asp:Table runat="server">

                        <asp:TableRow>
                            <asp:TableCell Width="100" HorizontalAlign="Center">
                                &nbsp&nbsp<asp:Label runat="server" ID="Label13" Text="" Font-Size="Medium" CssClass="lblFont3" Width="120" ></asp:Label><br /><br /> 
                            </asp:TableCell>
                            <asp:TableCell HorizontalAlign="Center">
                                &nbsp&nbsp<asp:Label runat="server" ID="Label2" Text="Team Name" Font-Size="Medium" CssClass="lblFont3" Width="130" ></asp:Label><br /><br />
                            </asp:TableCell>
                            <asp:TableCell HorizontalAlign="Center">
                                 &nbsp&nbsp<asp:Label runat="server" ID="Label12" Text="MP" Font-Size="Medium" CssClass="lblFont3" Width="80"></asp:Label><br /><br />
                            </asp:TableCell>
                             <asp:TableCell HorizontalAlign="Center">
                                 &nbsp&nbsp<asp:Label runat="server" ID="Label4" Text="W" Font-Size="Medium" CssClass="lblFont3" Width="80" ></asp:Label><br /><br />
                            </asp:TableCell>
                             <asp:TableCell HorizontalAlign="Center">
                                 &nbsp&nbsp<asp:Label runat="server" ID="Label5" Text="D" Font-Size="Medium" CssClass="lblFont3" Width="80"></asp:Label><br /><br />
                            </asp:TableCell>
                             <asp:TableCell HorizontalAlign="Center">
                                 &nbsp&nbsp<asp:Label runat="server" ID="Label6" Text="L" Font-Size="Medium" CssClass="lblFont3" Width="80"></asp:Label><br /><br />
                            </asp:TableCell>
                             <asp:TableCell HorizontalAlign="Center">
                                 &nbsp&nbsp<asp:Label runat="server" ID="Label7" Text="GF" Font-Size="Medium" CssClass="lblFont3" Width="80" ></asp:Label><br /><br />
                            </asp:TableCell>
                             <asp:TableCell HorizontalAlign="Center">
                                 &nbsp&nbsp<asp:Label runat="server" ID="Label8" Text="GA" Font-Size="Medium" CssClass="lblFont3" Width="80" ></asp:Label><br /><br />
                            </asp:TableCell>
                             <asp:TableCell HorizontalAlign="Center">
                                 &nbsp&nbsp<asp:Label runat="server" ID="Label9" Text="+/-" Font-Size="Medium" CssClass="lblFont3" Width="80"></asp:Label><br /><br />
                            </asp:TableCell>
                            <asp:TableCell HorizontalAlign="Center">
                                 &nbsp&nbsp<asp:Label runat="server" ID="Label10" Text="pts" Font-Size="Medium" CssClass="lblFont3" Width="80"></asp:Label><br /><br />
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table> 
                    <asp:Table  runat ="server" ID="tbl" Width="100%"></asp:Table>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
