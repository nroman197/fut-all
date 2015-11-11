<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tourn_Cup_Match.aspx.cs" Inherits="fut_all.Tourn_Cup_Match" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Styles/CircularImage.css" rel="stylesheet" />
    <link href="Styles/General.css" rel="stylesheet" />
    <link href="Styles/navbar.css" rel="stylesheet" />
    <link href="Styles/navbar2.css" rel="stylesheet" />
    <link href="Styles/tables.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Tournament Cup Matches</title>
</head>
<body style="background-image:url('../Images/background6.jpg')">
    <form id="form1" runat="server">
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
       <div>        
        <br />
        <asp:Table runat="server" BorderStyle="None" BackColor="White" Height="100%" Width="50%" HorizontalAlign="Center" CssClass="roundedChart">
            <asp:TableRow runat ="server">
              <asp:TableCell VerticalAlign="Bottom" BorderWidth="10px" BorderColor="White">
                  <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                      <asp:Table runat="server">
                          <asp:TableRow runat="server">                                                            
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="lbldatetime" Text="DateTime" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>
                          </asp:TableRow>
                          <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txtdatetime" CssClass="txbClass" Text="" TextMode="DateTime" ></asp:TextBox>
                              </asp:TableCell>                            
                          </asp:TableRow>
                      </asp:Table>
                      <br />                    
                  </asp:Panel>                  
              </asp:TableCell>               
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell VerticalAlign="Bottom" BorderWidth="10px" BorderColor="White">
                    <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                        <asp:Table runat="server">
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle" Width ="240px">                                  
                                  <br />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label runat="server" ID="team1" Text="Team1" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Width ="240px">                                  
                                  <br />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label runat="server" ID="team2" Text="Team2" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                            </asp:TableRow>
                            <%-- Grid views components --%>
                            <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">                                  
                                  <asp:Table runat="server" HorizontalAlign="Center">
                                      <asp:TableRow>
                                          <asp:TableCell runat="server" Width="7px"></asp:TableCell>
                                          <asp:TableCell>
                                              <div  style="width: 150%; height: 300px; overflow: scroll">
                                                  <asp:GridView ID="grvTeam1" RowStyle-HorizontalAlign="Center" runat="server" AllowPaging="false" CssClass="ddl" HorizontalAlign="Center" Width="100%" >
                                                   <Columns>
                                                       <asp:TemplateField >
                                                           <ItemTemplate>
                                                               <asp:CheckBox runat="server" ID="chkplayer" />
                                                               <asp:CheckBox runat="server" ID="chkiscapt" />
                                                           </ItemTemplate>                                             
                                                       </asp:TemplateField>
                                                   </Columns>
                                               </asp:GridView>  
                                              </div>                                                                                                                         
                                          </asp:TableCell>
                                      </asp:TableRow>
                                  </asp:Table> 
                              </asp:TableCell>  
                              <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Bottom">                                  
                                  <asp:Table runat="server" HorizontalAlign="Center">
                                      <asp:TableRow>
                                          <asp:TableCell runat="server" Width="7px"></asp:TableCell>
                                          <asp:TableCell>
                                              <div  style="width: 150%; height: 300px; overflow: scroll">
                                                  <asp:GridView ID="grvTeam2" RowStyle-HorizontalAlign="Center" runat="server" AllowPaging="false" CssClass="ddl" HorizontalAlign="Center" Width="100%" >
                                                   <Columns>
                                                       <asp:TemplateField >
                                                           <ItemTemplate>
                                                               <asp:CheckBox runat="server" ID="chkplayer" />
                                                               <asp:CheckBox runat="server" ID="chkiscapt" />
                                                           </ItemTemplate>                                             
                                                       </asp:TemplateField>
                                                   </Columns>
                                               </asp:GridView>  
                                              </div>                                                                                                                         
                                          </asp:TableCell>
                                      </asp:TableRow>
                                  </asp:Table> 
                              </asp:TableCell>                              
                          </asp:TableRow>
                            <asp:TableRow>

                            </asp:TableRow>
                        </asp:Table>
                    </asp:Panel>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
           <br />  
    
    </div>
    </form>
</body>
</html>
