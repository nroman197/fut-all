<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="fut_all.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Styles/AdminStyles.css" rel="stylesheet" />
    <link href="Styles/General.css" rel="stylesheet" />
    <link href="Styles/navbar.css" rel="stylesheet" />
    <link href="Styles/verticalmenu.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">    
        <div>
            <nav class="navbar">
                <ul id="menu_wrap" >
                    <li ><a href="#">Log Out</a></li>
                    <li ><a href="#">Qualification Tournaments</a></li>
                    <li ><a href="#">Local Tournaments</a></li>
                    <li ><a href="#">Tournament Cups</a></li>
                    <li ><a href="#">Admin</a></li>
               </ul>
            </nav>          
        </div>
        <div>        
        <br />
        <br />
        <br />
        <asp:Table runat="server" BorderStyle="None" BackColor="White" Height="100%" Width="90%" HorizontalAlign="Center" CssClass="roundedChart">
            <asp:TableRow runat ="server">
              <asp:TableCell VerticalAlign="Bottom" BorderWidth="20px" BorderColor="White">
                  &nbsp&nbsp<asp:Label runat="server" ID="Label1" Text="Geography" Font-Size="Larger" CssClass="lblFont" ></asp:Label><br /><br />
                  <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="50%">
                      <asp:Table runat="server">
                          <asp:TableRow runat="server">                                                            
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label2" Text="Continents" Font-Size="Larger" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>
                          </asp:TableRow>
                          <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txbContinent" CssClass="txbClass" Text="" ></asp:TextBox>
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                  <asp:Button runat="server" ID="btnAddcontinent" CssClass="btn" Text="+" />
                              </asp:TableCell>                              
                          </asp:TableRow>
                      </asp:Table>
                      <br />                    
                  </asp:Panel>                  
              </asp:TableCell>                
            </asp:TableRow>
            <asp:TableRow runat ="server">
              <asp:TableCell VerticalAlign="Bottom" BorderWidth="20px" BorderColor="White">              
                  <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="50%">
                      <asp:Table runat="server">
                          <asp:TableRow runat="server">                                                            
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label3" Text="Confederations" Font-Size="Larger" CssClass="lblFont" ></asp:Label>
                              </asp:TableCell>
                          </asp:TableRow>
                          <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:DropDownList runat="server" ID="ddlContinents" CssClass="ddl"></asp:DropDownList><br /><br />
                                  &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txtConfederation" CssClass="txbClass" Text="" ></asp:TextBox>
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                  <asp:Button runat="server" ID="btnAddConfederation" CssClass="btn" Text="+" />
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
