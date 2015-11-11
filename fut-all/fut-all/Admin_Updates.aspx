<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Updates.aspx.cs" Inherits="fut_all.Admin_Updates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="shortcut icon" type ="image/x-icon" href="Images/futicon.ico" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Admin Updates</title>
    <link href="Styles/General.css" rel="stylesheet" />
    <link href="Styles/navbar.css" rel="stylesheet" />
    <link href="Styles/navbar2.css" rel="stylesheet" />
</head>
<body style="background-image:url('../Images/bg2.jpg')">
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
                        <asp:Label runat="server" ID="lblSection1" Text="Admins" ></asp:Label>
                         </a></li>
                    <li ><a runat="server" id="refsection2" href="Admin_Inserts.aspx">
                        <asp:Label runat="server" ID="lblSection2" Text="Insert Info"></asp:Label>
                         </a></li>
                    <li ><a runat="server" id="refsection3" href="Admin_Updates.aspx">
                        <asp:Label runat="server" ID="lblsection3" Text="Update Info"></asp:Label>
                         </a></li>
                    <li ><a runat="server" id="A1" href="Add_Tourn_Cup.aspx">
                    <asp:Label runat="server" ID="lblSection4" Text="Add New Tournament Cup" ></asp:Label>
                        </a></li>--%>
               </ul>
            </nav>          
        </div>
        <div>        
        <br />
        <asp:Table runat="server" BorderStyle="None" BackColor="White" Height="100%" Width="50%" HorizontalAlign="Center" CssClass="roundedChart">
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
                                  &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlContinent" CssClass="ddl" OnTextChanged="ddlContinent_TextChanged"></asp:DropDownList>                          
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
                                  &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlConfederations" CssClass="ddl" OnTextChanged="ddlConfederations_TextChanged"></asp:DropDownList>
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
                                  &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlCountries" CssClass="ddl" OnTextChanged="ddlCountries_TextChanged"></asp:DropDownList>
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
                                  &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlStadiums" CssClass="ddl" OnTextChanged="ddlStadiums_TextChanged"></asp:DropDownList>
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

            <asp:TableRow runat="server">
                <asp:TableCell VerticalAlign="Bottom" BorderWidth="10px" BorderColor="White">
                    &nbsp&nbsp<asp:Label runat="server" ID="Label7" Text="Players" Font-Size="Larger" CssClass="lblFont3" ></asp:Label><br /><br />
                    <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" >
                        <br />
                        <asp:Table runat="server">
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server">
                                    &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlPlayername"  CssClass="ddl" OnTextChanged="ddlPlayername_TextChanged" AutoPostBack="true"></asp:DropDownList>
                                </asp:TableCell>                           
                            </asp:TableRow>
                           <asp:TableRow runat="server">                                                            
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label8" Text="Name" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label9" Text="Last Name" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                           </asp:TableRow>                          
                           <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txbPName" CssClass="txbClass" Text="" ></asp:TextBox>                                  
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txbPLastName" CssClass="txbClass" Text="" ></asp:TextBox>
                              </asp:TableCell>                                               
                           </asp:TableRow>
                           <asp:TableRow>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label10" Text="Passport" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                               <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label11" Text="Shirt Number" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>                              
                           </asp:TableRow>
                           <asp:TableRow>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txbPPassport" CssClass="txbClass" Text="" TextMode="Number"></asp:TextBox>
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txbShirtNumber" CssClass="txbClass" Text=""  TextMode="Number"></asp:TextBox>                                  
                              </asp:TableCell>                             
                           </asp:TableRow>
                           <asp:TableRow>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label13" Text="Position" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                               <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label12" Text="Genre" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                           </asp:TableRow>
                           <asp:TableRow>                                                               
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlPosition" CssClass="ddl" OnTextChanged="ddlPosition_TextChanged"></asp:DropDownList>                                  
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlGenrePlayer" CssClass="ddl" OnTextChanged="ddlGenrePlayer_TextChanged"></asp:DropDownList>                                  
                              </asp:TableCell>                                                           
                           </asp:TableRow>
                            <asp:TableRow>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label14" Text="Photo" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label22" Text="Country" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                 &nbsp&nbsp&nbsp<asp:FileUpload ID="fuPicture" runat="server" AllowMultiple="false" accept="image/*"  Width="200px"/>                                  
                              </asp:TableCell>
                                 <asp:TableCell>
                                  &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlPlayerCountry" CssClass="ddl" ></asp:DropDownList>
                                  <br />                                                                   
                              </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell><br /></asp:TableCell>
                              <asp:TableCell>
                                  <br />
                                 &nbsp&nbsp&nbsp<asp:Button runat="server" ID="btnAddPlayer" CssClass="btn" Width="218px" Text="Update Player" OnClick="btnAddPlayer_Click"/>
                              </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <br />
                                </asp:TableCell>
                            </asp:TableRow>                                                      
                        </asp:Table>
                    </asp:Panel>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell VerticalAlign="Bottom" BorderWidth="10px" BorderColor="White">
                    &nbsp&nbsp<asp:Label runat="server" ID="Label15" Text="Teams" Font-Size="Larger" CssClass="lblFont3" ></asp:Label><br /><br />
                    <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" >
                        <br />
                        <asp:Table runat="server">
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server">
                                    &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlTeamname" CssClass="ddl" OnTextChanged="ddlTeamName_TextChanged" AutoPostBack="true"></asp:DropDownList>
                                </asp:TableCell>
                            </asp:TableRow>
                           <asp:TableRow runat="server">                                                            
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label16" Text="Full Name" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label17" Text="Short Name" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                           </asp:TableRow>                          
                           <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txbFullName" CssClass="txbClass" Text="" ></asp:TextBox>                                  
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txtShortName" CssClass="txbClass" Text="" ></asp:TextBox>
                              </asp:TableCell>                                               
                           </asp:TableRow>
                           <asp:TableRow>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label18" Text="Category" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                               <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label19" Text="Type" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>                              
                           </asp:TableRow>
                           <asp:TableRow>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlTeamCathegory" CssClass="ddl" OnTextChanged="ddlTeamCathegory_TextChanged" AutoPostBack="true"></asp:DropDownList>                                  
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                 &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlTeamType" CssClass="ddl" OnTextChanged="ddlTeamType_TextChanged" AutoPostBack="true"></asp:DropDownList>                                  
                              </asp:TableCell>                             
                           </asp:TableRow>
                           <asp:TableRow>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label20" Text="Country" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                               <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label21" Text="Stadium" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                           </asp:TableRow>
                           <asp:TableRow>                                                               
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlTeamCountry" CssClass="ddl" OnTextChanged="ddlTeamCountry_TextChanged" AutoPostBack="true"></asp:DropDownList>                                  
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlTeamStadium" CssClass="ddl" OnTextChanged="ddlTeamStadium_TextChanged"></asp:DropDownList>                                  
                              </asp:TableCell>                                                           
                           </asp:TableRow>
                             <asp:TableRow>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="teamflag" Text="Team Flag" Font-Size="Medium" CssClass="lblFont" ></asp:Label>                                        
                              </asp:TableCell>
                           </asp:TableRow>
                            
                            <asp:TableRow >
                                <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                     &nbsp&nbsp&nbsp<asp:FileUpload ID="fuFlag" runat="server" AllowMultiple="false" accept="image/*"  Width="200px"/>     
                                </asp:TableCell>
                                 <asp:TableCell HorizontalAlign="Right" VerticalAlign="Bottom">
                                 &nbsp&nbsp&nbsp <asp:Button runat="server" ID="btnUpdateTeam" CssClass="btn" Width="218px" Text="Update Team" OnClick="btnUpdateTeam_Click"/>&nbsp&nbsp&nbsp&nbsp
                              </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <br />
                                </asp:TableCell>
                            </asp:TableRow>                                                      
                        </asp:Table>
                    </asp:Panel>
                </asp:TableCell>
            </asp:TableRow>            
        </asp:Table>
        <br />


        <asp:Table runat="server" BorderStyle="None" BackColor="White" Height="100%" Width="50%" HorizontalAlign="Center" CssClass="roundedChart">
           <asp:TableRow runat ="server">
              <asp:TableCell VerticalAlign="Bottom" BorderWidth="10px" BorderColor="White">                  
                  <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%" HorizontalAlign="Center">
                      <asp:Table runat="server">
                          <asp:TableRow runat="server">                                                            
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label23" Text="Team Players" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>
                          </asp:TableRow>
                          <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">                                  
                                  <asp:Table runat="server" HorizontalAlign="Center">
                                      <asp:TableRow>
                                          <asp:TableCell runat="server" Width="7px"></asp:TableCell>
                                          <asp:TableCell>
                                              <div  style="width: 160%; height: 300px; overflow: scroll">
                                                  <asp:GridView ID="grvPlayers" RowStyle-HorizontalAlign="Center" runat="server" AllowPaging="false" CssClass="ddl" HorizontalAlign="Center" Width="100%" >
                                                   <Columns>
                                                       <asp:TemplateField >
                                                           <ItemTemplate>
                                                               <asp:CheckBox runat="server" ID="chkplayer" />
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
                      </asp:Table>
                       <asp:Table runat="server" HorizontalAlign="Right">
                          <asp:TableRow HorizontalAlign="Left" runat="server">
                              <asp:TableCell HorizontalAlign="Right">
                                  <asp:Button runat="server" ID="btnDeletePlayer" CssClass="btn" Width="218px" Text="Delete Player" OnClick="btnDeletePlayer_Click"/>&nbsp&nbsp&nbsp&nbsp
                              </asp:TableCell>                              
                          </asp:TableRow>
                      </asp:Table>
                      <br />
                      <br />
                      <asp:Table runat="server">
                          <asp:TableRow runat="server">                                                            
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="avaibleplayers" Text="Available Players" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>
                          </asp:TableRow>
                          <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">                                  
                                  <asp:Table runat="server" HorizontalAlign="Center">
                                      <asp:TableRow>
                                          <asp:TableCell runat="server" Width="7px"></asp:TableCell>
                                          <asp:TableCell>
                                              <div  style="width: 160%; height: 300px; overflow: scroll">
                                                  <asp:GridView ID="grvAllPlayers" RowStyle-HorizontalAlign="Center" runat="server" AllowPaging="false" CssClass="ddl" HorizontalAlign="Center" Width="100%" >
                                                   <Columns>
                                                       <asp:TemplateField >
                                                           <ItemTemplate>
                                                               <asp:CheckBox runat="server" ID="chkAll" />
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
                      </asp:Table>
                       <asp:Table runat="server" HorizontalAlign="Right">
                          <asp:TableRow HorizontalAlign="Left" runat="server">
                              <asp:TableCell HorizontalAlign="Right">
                                  <asp:Button runat="server" ID="btnInsertPlayer" CssClass="btn" Width="218px" Text="Insert Player" OnClick="btnInsertPlayer_Click"/>&nbsp&nbsp&nbsp&nbsp
                              </asp:TableCell>                              
                          </asp:TableRow>
                      </asp:Table>
                     
                      <br /><br />
                      <br /><br /><br />
                      <br />                     
                  </asp:Panel>                  
              </asp:TableCell>               
            </asp:TableRow>
        </asp:Table>
      </div>
    </form>
</body>
</html>
