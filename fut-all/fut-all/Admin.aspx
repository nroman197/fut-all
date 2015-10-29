<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="fut_all.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Styles/AdminStyles.css" rel="stylesheet" />
    <link href="Styles/General.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Table runat="server" BorderStyle="None" BackColor="White" Height="100%" Width="90%" HorizontalAlign="Center" CssClass="roundedChart">
            <asp:TableRow runat ="server">
              <asp:TableCell VerticalAlign="Bottom">
                  <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="50%">
                      <asp:Table runat="server">
                          <asp:TableRow runat="server">
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">
                                  <asp:Label runat="server" ID="lblContinents" Text="Continents" Font-Size="Larger" CssClass="lblFont"></asp:Label>
                              </asp:TableCell>
                          </asp:TableRow>
                          <asp:TableRow runat="server">
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  <asp:TextBox runat="server" ID="txbContinent" CssClass="txbClass" Text="" ></asp:TextBox>
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                  <asp:Button runat="server" ID="btnAddcontinent" CssClass="btn" Text="+" />
                              </asp:TableCell>
                          </asp:TableRow>
                      </asp:Table>                      
                  </asp:Panel>
              </asp:TableCell>                
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
