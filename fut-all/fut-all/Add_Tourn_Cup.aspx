<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_Tourn_Cup.aspx.cs" Inherits="fut_all.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="shortcut icon" type ="image/x-icon" href="Images/futicon.ico" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Add Tournament Cup</title>
    <link href="Styles/General.css" rel="stylesheet" />
    <link href="Styles/navbar.css" rel="stylesheet" />
    <link href="Styles/navbar2.css" rel="stylesheet" />
</head>
<body style="background-image:url('../Images/bg2.jpg')">
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
                    <li ><a runat="server" id="A1" href="Add_Tourn_Cup.aspx">
                    <asp:Label runat="server" ID="lblSection4" Text="Add New Tournament Cup" ></asp:Label>
                        </a></li>
               </ul>
            </nav>          
        </div>
        <br />
        <asp:Table runat="server" BorderStyle="None" BackColor="White" Height="100%" Width="50%" HorizontalAlign="Center" CssClass="roundedChart">
            <asp:TableRow runat ="server">
              <asp:TableCell VerticalAlign="Bottom" BorderWidth="10px" BorderColor="White">
                  &nbsp&nbsp<asp:Label runat="server" ID="Label1" Text="Basic Info" Font-Size="Larger" CssClass="lblFont3" ></asp:Label><br /><br />
                  <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                      <asp:Table runat="server">
                          <asp:TableRow runat="server">                                                            
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label2" Text="Name" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>
                          </asp:TableRow>
                          <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txbEventName" CssClass="txbClass" Text="" ></asp:TextBox>
                              </asp:TableCell>                             
                          </asp:TableRow>
                          <asp:TableRow>
                              <asp:TableCell>
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label3" Text="Teams Type" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>
                              <asp:TableCell>
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label4" Text="Teams Category" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>
                          </asp:TableRow>
                          <asp:TableRow>
                              <asp:TableCell>
                                  &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlTeamType" CssClass="ddl" OnTextChanged="ddlTeamType_TextChanged" AutoPostBack="true"></asp:DropDownList>                                  
                              </asp:TableCell>
                                 <asp:TableCell>
                                  &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlTeamCathegory" CssClass="ddl" OnTextChanged="ddlTeamCathegory_TextChanged" AutoPostBack="true"></asp:DropDownList>                                  
                              </asp:TableCell>
                          </asp:TableRow>
                      </asp:Table>
                      <br />                    
                  </asp:Panel>                  
              </asp:TableCell>               
            </asp:TableRow>
            <asp:TableRow runat ="server">
              <asp:TableCell VerticalAlign="Bottom" BorderWidth="10px" BorderColor="White">
                  &nbsp&nbsp<asp:Label runat="server" ID="Label5" Text="Dates" Font-Size="Larger" CssClass="lblFont3" ></asp:Label><br /><br />
                  <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                      <asp:Table runat="server">
                          <asp:TableRow runat="server">                                                            
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label6" Text="Start" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label7" Text="End" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>
                          </asp:TableRow>
                          <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txbStartDate" CssClass="txbClass" Text="" TextMode="Date" ></asp:TextBox>
                              </asp:TableCell> 
                              <asp:TableCell>
                                 &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txbEndDate" CssClass="txbClass" Text="" TextMode="Date" ></asp:TextBox>
                              </asp:TableCell>                             
                          </asp:TableRow>                         
                      </asp:Table>
                      <br />                    
                  </asp:Panel>                  
              </asp:TableCell>               
            </asp:TableRow>
            <asp:TableRow runat ="server">
              <asp:TableCell VerticalAlign="Bottom" BorderWidth="10px" BorderColor="White">
                  &nbsp&nbsp<asp:Label runat="server" ID="Label8" Text="Geography" Font-Size="Larger" CssClass="lblFont3" ></asp:Label><br /><br />
                  <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                      <asp:Table runat="server">
                          <asp:TableRow runat="server">
                              <asp:TableCell runat="server" Width="7px"></asp:TableCell>                                                             
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br /><asp:Label runat="server" ID="Label9" Text="Host Country or Countries" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>  
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br /><asp:Label runat="server" ID="Label16" Text="Host Stadiums" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>   
                          </asp:TableRow>
                          <asp:TableRow runat="server">
                              <asp:TableCell runat="server" Width="7px"></asp:TableCell>                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                   <div style="width: 100%; height:200px; overflow: scroll">
                                        <asp:GridView ID="grvCountries" RowStyle-HorizontalAlign="Left" runat="server" AllowPaging="false" CssClass="ddl" HorizontalAlign="Center" Width="100%" >
                                        <Columns>
                                            <asp:TemplateField >
                                                <ItemTemplate>
                                                    <asp:CheckBox runat="server" ID="chkcountry" OnCheckedChanged="chkcountry_CheckedChanged" AutoPostBack="true"/>
                                                </ItemTemplate>                                             
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>  
                                  </div> 
                              </asp:TableCell>
                                  <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                   <div style="width: 100%; height:200px; overflow: scroll">
                                        <asp:GridView ID="grvStadiums" RowStyle-HorizontalAlign="Left" runat="server" AllowPaging="false" CssClass="ddl" HorizontalAlign="Center" Width="100%" >
                                        <Columns>
                                            <asp:TemplateField >
                                                <ItemTemplate>
                                                    <asp:CheckBox runat="server" ID="chkstadiums" />
                                                </ItemTemplate>                                             
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>  
                                  </div> 
                              </asp:TableCell>                             
                          </asp:TableRow>                       
                      </asp:Table>
                      <br />                    
                  </asp:Panel>                  
              </asp:TableCell>               
            </asp:TableRow>
            <asp:TableRow runat ="server">
              <asp:TableCell VerticalAlign="Bottom" BorderWidth="10px" BorderColor="White">
                  &nbsp&nbsp<asp:Label runat="server" ID="Label10" Text="Event Configuration" Font-Size="Larger" CssClass="lblFont3" ></asp:Label><br /><br />
                  <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                      <asp:Table runat="server">
                          <asp:TableRow runat="server">                                                            
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label11" Text="Teams Quantity" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label12" Text="Groups Quantity" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label13" Text="Qualifications Quantity" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>
                          </asp:TableRow>
                          <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlTeamsQuant" CssClass="ddl" OnTextChanged="ddlTeamsQuant_TextChanged" AutoPostBack="true"></asp:DropDownList>                                  
                              </asp:TableCell> 
                              <asp:TableCell HorizontalAlign="Center">
                                 &nbsp&nbsp&nbsp<asp:Label runat="server" ID="lblGroupsQuant" Text="" Font-Size="Medium" CssClass="lblFont3" ></asp:Label>
                              </asp:TableCell>
                              <asp:TableCell HorizontalAlign="Center">
                                 &nbsp&nbsp&nbsp<asp:Label runat="server" ID="lblQualifQuant" Text="" Font-Size="Medium" CssClass="lblFont3" ></asp:Label>
                              </asp:TableCell>                               
                          </asp:TableRow>                         
                      </asp:Table>
                      <br />                    
                  </asp:Panel>                  
              </asp:TableCell>               
            </asp:TableRow>
            <asp:TableRow runat ="server">
              <asp:TableCell VerticalAlign="Bottom" BorderWidth="10px" BorderColor="White">
                  &nbsp&nbsp<asp:Label runat="server" ID="Label14" Text="Participants" Font-Size="Larger" CssClass="lblFont3" ></asp:Label><br /><br />
                  <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                      <asp:Table runat="server">
                          <asp:TableRow runat="server">
                              <asp:TableCell runat="server" Width="7px"></asp:TableCell>                                                             
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br /><asp:Label runat="server" ID="Label15" Text="Teams" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>                              
                          </asp:TableRow>
                          <asp:TableRow runat="server"> 
                              <asp:TableCell runat="server" Width="7px"></asp:TableCell>                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                   <div style="width: 100%; height:200px; overflow: scroll">
                                        <asp:GridView ID="grvParticipants" RowStyle-HorizontalAlign="Left" runat="server" AllowPaging="false" CssClass="ddl" HorizontalAlign="Center" Width="100%" >
                                        <Columns>
                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                    <asp:CheckBox runat="server" ID="chkParticipants" />
                                                </ItemTemplate>                                             
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>  
                                  </div>
                              </asp:TableCell>                                        
                          </asp:TableRow>                         
                      </asp:Table>
                      <br />                    
                  </asp:Panel>                  
              </asp:TableCell>               
            </asp:TableRow>
            <asp:TableRow >
                <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                      <br />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label23" Text="Logo" Font-Size="Medium" CssClass="lblFont" ></asp:Label>
                 </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow HorizontalAlign="Left">
                 <asp:TableCell>
                    &nbsp&nbsp&nbsp<asp:FileUpload ID="fuEventLogo" runat="server" AllowMultiple="false" accept="image/*"  Width="200px"/>                                  
                </asp:TableCell> 
            </asp:TableRow>
            <asp:TableRow HorizontalAlign="Right" >
                <asp:TableCell>
                    <asp:Button runat="server" ID="btnAddEvent" CssClass="btn" Width="218px" Text="Create Event" OnClick="btnAddEvent_Click"/>&nbsp&nbsp&nbsp&nbsp
                    <br />
                    <br />
                </asp:TableCell>                
            </asp:TableRow>  
                   
      </asp:Table>  
 
 
    </div>
    </form>
</body>
</html>
