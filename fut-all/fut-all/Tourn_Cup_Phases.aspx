<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tourn_Cup_Phases.aspx.cs" Inherits="fut_all.Tourn_Cup_Groups" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Styles/General.css" rel="stylesheet" />
    <link href="Styles/navbar.css" rel="stylesheet" />
    <link href="Styles/navbar2.css" rel="stylesheet" />
    <link href="Styles/tables.css" rel="stylesheet" />
    <link href="Styles/CircularImage.css" rel="stylesheet" />
    <link href="Styles/FlagImage.css" rel="stylesheet" />
    <link href="Styles/phasesfonts.css" rel="stylesheet" />
    <link rel="shortcut icon" type ="image/x-icon" href="Images/futicon.ico" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Tournament Cup Groups</title>
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
        <asp:Table runat="server" BorderStyle="None" BackColor="White" Height="100%" Width="60%" HorizontalAlign="Center" CssClass="roundedChart">
            <asp:TableRow>
                <asp:TableCell VerticalAlign="Middle" BorderWidth="10px" BorderColor="White">
                    &nbsp&nbsp<asp:Label runat="server" ID="Label1" Text="General Stats" Font-Size="Larger" CssClass="lblFont3" ></asp:Label><br /><br />                
                    <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                        <asp:Table runat="server">
                            <asp:TableRow VerticalAlign="Middle">
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label2" Text="Matches Played" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                                <br />
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="lblMatchesPlayed" Text="" Font-Size="Medium" CssClass="lblFont3"></asp:Label>                             
                              </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <br />
                    </asp:Panel>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat ="server">
              <asp:TableCell VerticalAlign="Bottom" BorderWidth="10px" BorderColor="White">                  
                  <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                      <asp:Table runat="server">
                          <asp:TableRow runat="server">                                                            
                          </asp:TableRow>
                          <asp:TableRow runat="server" HorizontalAlign="Center" Width="100%">                              
                              <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label4" Text="Goals per Match" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label7" Text="Average Cards per Match" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label10" Text="Average Shots per Team" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>
                          </asp:TableRow>
                          <asp:TableRow runat="server" HorizontalAlign="Center" Width="100%">                              
                              <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                  <asp:Table runat="server">
                                      <asp:TableRow>                                          
                                          <asp:TableCell Width="12px"><br /></asp:TableCell>
                                          <asp:TableCell VerticalAlign="Middle">                                              
                                                <br />&nbsp&nbsp&nbsp<asp:Image  runat="server" CssClass="circularFlag" src="Images/miniball.png" />
                                          </asp:TableCell>
                                          <asp:TableCell VerticalAlign="Middle">
                                              <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="lblGoalsxMatch" Text="2.9" Font-Size="Medium" CssClass="lblFont3"></asp:Label>
                                          </asp:TableCell>
                                      </asp:TableRow>
                                  </asp:Table>                                                                   
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                  <asp:Table runat="server">
                                      <asp:TableRow>
                                          <asp:TableCell VerticalAlign="Middle">
                                              <br />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Image  runat="server" CssClass="circularFlag" src="Images/miniyellowcard.png" />
                                          </asp:TableCell>
                                          <asp:TableCell VerticalAlign="Middle" HorizontalAlign="Left">
                                              <br />&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label runat="server" ID="lblAverageYellow" Text="2.0" Font-Size="Medium" CssClass="lblFont3" ></asp:Label>
                                          </asp:TableCell>
                                          <asp:TableCell Width="12px"><br /></asp:TableCell>
                                          <asp:TableCell VerticalAlign="Middle">
                                              <br />&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Image  runat="server" CssClass="circularFlag" src="Images/miniredcard.png" />
                                          </asp:TableCell>
                                          <asp:TableCell VerticalAlign="Middle" HorizontalAlign="Left">
                                              <br />&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label runat="server" ID="lblAverageRed" Text="1.3" Font-Size="Medium" CssClass="lblFont3" ></asp:Label>
                                          </asp:TableCell>
                                      </asp:TableRow>
                                  </asp:Table>
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                  <asp:Table runat="server">
                                      <asp:TableRow>                                          
                                          <asp:TableCell Width="12px"><br /></asp:TableCell>
                                          <asp:TableCell VerticalAlign="Middle">                                              
                                                <br />&nbsp&nbsp&nbsp<asp:Image  runat="server" CssClass="circularFlag" src="Images/minishotball.png" />
                                          </asp:TableCell>
                                          <asp:TableCell VerticalAlign="Middle">
                                              <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="lblAverageShots" Text="3.9" Font-Size="Medium" CssClass="lblFont3"></asp:Label>
                                          </asp:TableCell>
                                      </asp:TableRow>
                                  </asp:Table>                                                                   
                              </asp:TableCell>                             
                          </asp:TableRow>
                      </asp:Table>
                      <br />                    
                  </asp:Panel>                  
              </asp:TableCell>               
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell VerticalAlign="Middle" BorderWidth="10px" BorderColor="White">
                    &nbsp&nbsp<asp:Label runat="server" ID="Label5" Text="General Info" Font-Size="Larger" CssClass="lblFont3" ></asp:Label><br /><br />                
                    <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                        <asp:Table runat="server">
                            <asp:TableRow runat="server">                                
                                <asp:TableCell Width="7px"></asp:TableCell>                           
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  <br />
                                   <div style="width: 100%; height:150px; overflow: scroll">                                       
                                        <asp:GridView ID="grvCountries" RowStyle-HorizontalAlign="Left" runat="server" AllowPaging="false" CssClass="ddl" HorizontalAlign="Center" Width="100%" BackColor="WhiteSmoke" BorderColor="WhiteSmoke" BorderWidth="0px" >
                                        <Columns>
                                            <asp:TemplateField >
                                                <ItemTemplate>
                                                    <asp:CheckBox runat="server" ID="chkcountry" Checked="true" Enabled="false"/>
                                                </ItemTemplate>                                             
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>  
                                  </div> 
                              </asp:TableCell>
                                  <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                      <br /> 
                                   <div style="width: 100%; height:150px; overflow: scroll">                                       
                                       <asp:GridView ID="grvStadiums" RowStyle-HorizontalAlign="Left" runat="server" AllowPaging="false" CssClass="ddl" HorizontalAlign="Center" Width="100%" BackColor="WhiteSmoke" BorderColor="WhiteSmoke" BorderWidth="0px">
                                        <Columns>
                                            <asp:TemplateField >
                                                <ItemTemplate>
                                                    <asp:CheckBox runat="server" ID="chkstadiums"  Checked="true" Enabled="false"/>
                                                </ItemTemplate>                                             
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>  
                                  </div> 
                              </asp:TableCell>                                
                                <asp:TableCell>
                                    <asp:Table runat="server">
                                        <asp:TableRow>
                                            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                                 <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label9" Text="Champion" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                                                 <br />
                                            </asp:TableCell>
                                            
                                            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                                <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label12" Text="Subchampion" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                                                <br />
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow VerticalAlign="Middle" HorizontalAlign="Right">
                                            <asp:TableCell VerticalAlign="Middle">
                                                <asp:Table runat="server">
                                                    <asp:TableRow VerticalAlign="Middle">
                                                        <asp:TableCell VerticalAlign="Middle" HorizontalAlign="Right">
                                                            <br />
                                                           <asp:Image runat="server" ID="imgChamFlag" CssClass="circularFlag" src="Images/miniball.png"/>
                                                        </asp:TableCell>
                                                        <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle">                                  
                                                              <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="lblChampion" Text="ITA" Font-Size="Medium" CssClass="lblFont3" ></asp:Label>
                                                                <br />
                                                          </asp:TableCell>
                                                    </asp:TableRow>
                                                </asp:Table>                                                
                                            </asp:TableCell>                                              
                                           <asp:TableCell VerticalAlign="Middle" HorizontalAlign="Right">
                                                <asp:Table runat="server">
                                                    <asp:TableRow VerticalAlign="Middle">
                                                        <asp:TableCell VerticalAlign="Middle" HorizontalAlign="Right">
                                                            <br />
                                                           <asp:Image runat="server" ID="Image1" CssClass="circularFlag" src="Images/miniball.png"/>
                                                        </asp:TableCell>
                                                        <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle">                                  
                                                              <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="lblSubChamFlag" Text="CRC" Font-Size="Medium" CssClass="lblFont3" ></asp:Label>
                                                                <br />
                                                          </asp:TableCell>
                                                    </asp:TableRow>
                                                </asp:Table>                                                
                                            </asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </asp:TableCell>
                              
                          </asp:TableRow>
                        </asp:Table>
                        <br />
                    </asp:Panel>
                </asp:TableCell>
            </asp:TableRow>
            </asp:Table>

        <br />
        <asp:Table runat="server"  ID="maintbl" BorderStyle="None" BackColor="White" Height="100%" Width="60%" HorizontalAlign="Center" CssClass="roundedChart">
            <asp:TableRow runat ="server">
                <asp:TableCell VerticalAlign="Bottom" BorderWidth="10px" BorderColor="White">
                    <asp:Table  runat ="server" ID="tbl" Width="100%">
                        <asp:TableRow>
                            <asp:TableCell>
                                &nbsp&nbsp<asp:Label runat="server" ID="Label3" Text="Phases" Font-Size="Larger" CssClass="lblFont3" ></asp:Label><br /><br />
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
