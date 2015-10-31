<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Inserts.aspx.cs" Inherits="fut_all.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Styles/General.css" rel="stylesheet" />
    <link href="Styles/navbar.css" rel="stylesheet" />
    <link href="Styles/navbar2.css" rel="stylesheet" />
</head>
<body style="background-image:url('../Images/background6.jpg')">
    <form id="form1" runat="server">
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
                    <li ><a runat="server" id="refsection1">
                        <asp:Label runat="server" ID="lblSection1" Text="Events"></asp:Label>
                         </a></li>
                    <li ><a runat="server" id="refsection2">
                        <asp:Label runat="server" ID="lblSection2" Text="Insert Info"></asp:Label>
                         </a></li>
                    <li ><a runat="server" id="refsection3">
                        <asp:Label runat="server" ID="lblsection3" Text="Update Info"></asp:Label>
                         </a></li>
               </ul>
            </nav>          
        </div>
        <div>        
        <br />
        <asp:Table runat="server" BorderStyle="None" BackColor="White" Height="100%" Width="60%" HorizontalAlign="Center" CssClass="roundedChart">
            <asp:TableRow runat ="server">
              <asp:TableCell VerticalAlign="Bottom" BorderWidth="10px" BorderColor="White">
                  &nbsp&nbsp<asp:Label runat="server" ID="Label1" Text="Geography" Font-Size="Larger" CssClass="lblFont3" ></asp:Label><br /><br />
                  <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                      <asp:Table runat="server">
                          <asp:TableRow runat="server">                                                            
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label2" Text="Continents" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>
                          </asp:TableRow>
                          <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txbContinent" CssClass="txbClass" Text="" ></asp:TextBox>
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                  <asp:Button runat="server" ID="btnAddcontinent" CssClass="btn" Text="+" OnClick="btnAddcontinent_Click"/>
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
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label3" Text="Confederations" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>
                          </asp:TableRow>
                          <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlContinents" CssClass="ddl" OnTextChanged="ddlContinents_TextChanged"></asp:DropDownList>
                                  &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txbConfederation" CssClass="txbClass" Text="" ></asp:TextBox>
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                  <asp:Button runat="server" ID="btnAddConfederation" CssClass="btn" Text="+"  OnClick="btnAddConfederation_Click"/>
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
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label4" Text="Countries" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>
                          </asp:TableRow>
                          <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlConfederations" CssClass="ddl" OnTextChanged="ddlConfederations_TextChanged"></asp:DropDownList>
                                  &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txbCountry" CssClass="txbClass" Text="" ></asp:TextBox>
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                  <asp:Button runat="server" ID="btnAddCountry" CssClass="btn" Text="+" OnClick="btnAddCountry_Click"/>
                              </asp:TableCell>                              
                          </asp:TableRow>
                      </asp:Table>
                      <br />                    
                  </asp:Panel>                  
              </asp:TableCell>                
            </asp:TableRow>
            <asp:TableRow runat ="server">
              <asp:TableCell VerticalAlign="Bottom" BorderWidth="10px" BorderColor="White">
                  &nbsp&nbsp<asp:Label runat="server" ID="Label5" Text="Stadiums" Font-Size="Larger" CssClass="lblFont3" ></asp:Label><br /><br />
                  <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                      <asp:Table runat="server">
                          <asp:TableRow runat="server">                                                            
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label6" Text="Stadium Name" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>
                          </asp:TableRow>
                          <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txbStadium" CssClass="txbClass" Text="" ></asp:TextBox>
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                  <asp:Button runat="server" ID="btnAddStadium" CssClass="btn" Text="+" OnClick="btnAddStadium_Click"/>
                              </asp:TableCell>                              
                          </asp:TableRow>
                      </asp:Table>
                      <br />                    
                  </asp:Panel>                  
              </asp:TableCell>               
            </asp:TableRow>
            <asp:TableRow runat ="server">
              <asp:TableCell VerticalAlign="Bottom" BorderWidth="10px" BorderColor="White">
                  &nbsp&nbsp<asp:Label runat="server" ID="Label7" Text="Players" Font-Size="Larger" CssClass="lblFont3" ></asp:Label><br /><br />
                  <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                      <asp:Table runat="server">
                          <asp:TableRow runat="server">                                                            
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label8" Text="Name" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label9" Text="Last Name" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label10" Text="Passport" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                          </asp:TableRow>
                          <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txbPName" CssClass="txbClass" Text="" ></asp:TextBox>                                  
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txbPLastName" CssClass="txbClass" Text="" ></asp:TextBox>
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                  <asp:TextBox runat="server" ID="txbPPassport" CssClass="txbClass" Text="" ></asp:TextBox>
                              </asp:TableCell>                              
                          </asp:TableRow>
                          <asp:TableRow runat="server">                                                            
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label11" Text="Shirt Number" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label12" Text="Position" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label13" Text="Photo" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>   
                          </asp:TableRow>
                          <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txbShirtNumber" CssClass="txbClass" Text=""  TextMode="Number"></asp:TextBox>                                  
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlPosition" CssClass="ddl" OnTextChanged="ddlPosition_TextChanged"></asp:DropDownList>                                  
                              </asp:TableCell>
                             <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Bottom">
                                 &nbsp&nbsp&nbsp&nbsp&nbsp<asp:FileUpload ID="fuPicture" runat="server" AllowMultiple="false" accept="image/*" />                                  
                              </asp:TableCell>
                          </asp:TableRow>
                      </asp:Table>
                      <br />                    
                  </asp:Panel>                  
              </asp:TableCell>               
            </asp:TableRow>
            <asp:TableRow runat ="server">
              <asp:TableCell VerticalAlign="Bottom" BorderWidth="10px" BorderColor="White">
                  &nbsp&nbsp<asp:Label runat="server" ID="Label14" Text="Teams" Font-Size="Larger" CssClass="lblFont3" ></asp:Label><br /><br />
                  <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                      <asp:Table runat="server">
                          <asp:TableRow runat="server">                                                            
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label15" Text="Full Name" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label16" Text="Short Name" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label17" Text="Cathegory" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                          </asp:TableRow>
                          <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txbFullName" CssClass="txbClass" Text="" ></asp:TextBox>                                  
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txbShortName" CssClass="txbClass" Text="" ></asp:TextBox>
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlCathegory" CssClass="ddl" OnTextChanged="ddlCathegory_TextChanged"></asp:DropDownList>                                                                    
                              </asp:TableCell>                              
                          </asp:TableRow>
                          <asp:TableRow runat="server">                                                            
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label18" Text="Type" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label19" Text="Country" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label20" Text="Stadium" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>   
                          </asp:TableRow>
                          <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlType" CssClass="ddl" OnTextChanged="ddlType_TextChanged"></asp:DropDownList>                                  
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlTeamCountry" CssClass="ddl" OnTextChanged="ddlTeamCountry_TextChanged"></asp:DropDownList>                                  
                              </asp:TableCell>
                             <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlTeamStadium" CssClass="ddl" OnTextChanged="ddlTeamStadium_TextChanged"></asp:DropDownList>                                                                   
                              </asp:TableCell>
                          </asp:TableRow>
                          <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label21" Text="Team's Players" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>                              
                          </asp:TableRow>
                          <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">        
                                
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
