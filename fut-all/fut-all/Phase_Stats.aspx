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
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Phase Stats</title>
</head>
<body style="background-image:url('../Images/background6.jpg')">
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
        </nav>          
        </div>
        <br />
        <asp:Table runat="server"  ID="maintbl" BorderStyle="None" BackColor="White" Height="100%" Width="70%" HorizontalAlign="Center" CssClass="roundedChart">
            <asp:TableRow runat ="server">
                <asp:TableCell VerticalAlign="Bottom" BorderWidth="10px" BorderColor="White">
                    &nbsp&nbsp<asp:Label runat="server" ID="Label1" Text="Group " Font-Size="Larger" CssClass="lblFont3" ></asp:Label><br /><br />
                     <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                         <asp:Table runat="server" HorizontalAlign="Center">
                                      <asp:TableRow>
                                          <asp:TableCell runat="server" Width="7px"></asp:TableCell>
                                          <asp:TableCell>
                                              <div  style="width: 150%; height: 300px; overflow: scroll">
                                                  <asp:GridView ID="grvGroupTeams" RowStyle-HorizontalAlign="Center" runat="server" AllowPaging="false" CssClass="ddl" HorizontalAlign="Left" Width="100%" >
                                                   <Columns>
                                                       <asp:TemplateField >
                                                           <ItemTemplate>
                                                              
                                                           </ItemTemplate>                                             
                                                       </asp:TemplateField>
                                                   </Columns>
                                               </asp:GridView>  
                                              </div>                                                                                                                         
                                          </asp:TableCell>
                                      </asp:TableRow>
                                  </asp:Table> 
                         </asp:Panel> 
                    <asp:Table  runat ="server" ID="tbl" Width="100%"></asp:Table>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
