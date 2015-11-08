<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert_Admins.aspx.cs" Inherits="fut_all.Insert_Admins" %>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Insert Admins</title>
    <link href="Styles/General.css" rel="stylesheet" />
    <link href="Styles/navbar.css" rel="stylesheet" />
    <link href="Styles/navbar2.css" rel="stylesheet" />
</head>
<body style="background-image:url('../Images/background6.jpg')">
    <form id="form2" runat="server">
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
                        <asp:Label runat="server" ID="lblsection3" Text="Update Info"></asp:Label>
                         </a></li>
               </ul>
            </nav>          
        </div>
    </div>
        <br />

        <div>
            <asp:Table runat ="server" BorderStyle="None" BackColor="White" Height="40%" Width="50%" HorizontalAlign="Center" CssClass="roundedChart" >
                <asp:TableRow runat="server" VerticalAlign="Middle">
                    <asp:TableCell VerticalAlign="Top" BorderWidth="10px" BorderColor="White"> <br />
                         &nbsp&nbsp<asp:Label runat="server" ID="Label1" Text="Insert a new admin" Font-Size="Larger" CssClass="lblFont3" ></asp:Label><br /><br />
                            <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                                <br />
                                <asp:Table runat ="server">
                                    <asp:TableRow runat="server">
                                        <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">
                                            &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlAdmin" CssClass="ddl" OnTextChanged="ddlAdmin_TextChanged"></asp:DropDownList>                           
                                        </asp:TableCell>
                                         <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">
                                           &nbsp&nbsp&nbsp <asp:Button runat="server" ID="btnAddAdmin" CssClass="btn" Width="218px" Text="Create Admin" OnClick="btnAddAdmin_Click"/>&nbsp&nbsp&nbsp&nbsp
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                                <br />
                                </asp:Panel>
                         </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
