<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tourn_Cup_Match.aspx.cs" Inherits="fut_all.Tourn_Cup_Match" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
  
    <link href="Styles/CircularImage.css" rel="stylesheet" />
    <link href="Styles/Matchesstyle.css" rel="stylesheet" />
    <link href="Styles/navbar.css" rel="stylesheet" />
    <link href="Styles/navbar2.css" rel="stylesheet" />
    <link href="Styles/tables.css" rel="stylesheet" />
    <link rel="shortcut icon" type ="image/x-icon" href="Images/futicon.ico" />
    <link href="Styles/General.css" rel="stylesheet" />
    <link href="Styles/ddls.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Tournament Cup Matches</title>
</head>
<body style="background-image:url('../Images/bg5.jpg')">
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
                <asp:Image  runat="server" src="Images/logo0.png"/>
            </ul>
        </nav>          
    </div>
    <div>   
        </div>
       <div>        
        <br />
        <asp:Table runat="server" BorderStyle="None" BackColor="White" Height="100%" Width="80%" HorizontalAlign="Center" CssClass="roundedChart">
           <asp:TableRow>
               <asp:TableCell><br /></asp:TableCell>
           </asp:TableRow>
            <asp:TableRow VerticalAlign="Middle">
               <asp:TableCell VerticalAlign="Middle">
                   <asp:Table runat="server" VerticalAlign="Middle">
                       <asp:TableRow VerticalAlign="Middle">
                           <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">                                  
                               <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="lbldatetime" Text="Date" Font-Size="Medium" CssClass="lblFontmatch" ></asp:Label>
                           </asp:TableCell>
                           <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                                &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txtmatchdatetime" CssClass="txbClassmatch" Width="200px" Text="" ></asp:TextBox>
                           </asp:TableCell>                                
                       </asp:TableRow>
                   </asp:Table>
               </asp:TableCell>
               <asp:TableCell VerticalAlign="Middle">
                   <asp:Table runat="server" VerticalAlign="Middle">
                       <asp:TableRow VerticalAlign="Middle">
                            <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle">
                                <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="lblStadium" Text="Stadium" Font-Size="Medium" CssClass="lblFontmatch" ></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle">
                                 <asp:DropDownList runat="server" ID="ddlstadiums" CssClass="ddlmatch" Width="300px"></asp:DropDownList>                                
                            </asp:TableCell>
                       </asp:TableRow>
                   </asp:Table>
               </asp:TableCell>
           </asp:TableRow>
           
            <asp:TableRow VerticalAlign="Middle">
                <asp:TableCell VerticalAlign="Middle" BorderWidth="10px" BorderColor="White">
                    <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                        <asp:Table runat="server"  HorizontalAlign="Center" VerticalAlign="Middle">
                            <asp:TableRow HorizontalAlign="Center" Width="100%" VerticalAlign="Middle">
                                <asp:TableCell VerticalAlign="Middle">
                                    <asp:Image  ID="imgteam1" CssClass="circular" runat="server"/>&nbsp&nbsp&nbsp&nbsp
                                </asp:TableCell>
                                <asp:TableCell VerticalAlign="Middle">                                  
                                  <br /><asp:Label runat="server" ID="lblteam1" Text="Team1" Font-Size="40px" CssClass="lblFont3" ></asp:Label>                                      
                              </asp:TableCell>
                              <asp:TableCell Width="150px" VerticalAlign="Middle">                                  
                                  <br /><asp:Label runat="server" ID="lblgoal1" Text="" Font-Size="40px" CssClass="lblFont3" ></asp:Label>                                      
                              </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:Panel>
                </asp:TableCell>
                <asp:TableCell VerticalAlign="Middle" BorderWidth="10px" BorderColor="White">
                    <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                        <asp:Table runat="server" HorizontalAlign="Center" VerticalAlign="Middle">
                            <asp:TableRow HorizontalAlign="Center" Width="100%" VerticalAlign="Middle">
                              <asp:TableCell Width="150px" VerticalAlign="Middle">                                  
                                  <br /><asp:Label runat="server" ID="lblgoal2" Text="" Font-Size="40px" CssClass="lblFont3" ></asp:Label>                                      
                              </asp:TableCell>
                                <asp:TableCell VerticalAlign="Middle">                                  
                                  <br /><asp:Label runat="server" ID="lblteam2" Text="Team2" Font-Size="40px" CssClass="lblFont3" ></asp:Label>                                  
                              </asp:TableCell>
                                <asp:TableCell VerticalAlign="Middle">
                                    &nbsp&nbsp&nbsp&nbsp<asp:Image  ID="imgteam2" CssClass="circular" runat="server"/>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:Panel>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell VerticalAlign="Middle" BorderWidth="10px" BorderColor="White">
                    <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                        <asp:Table runat="server"  HorizontalAlign="Center" VerticalAlign="Middle">
                            <asp:TableRow HorizontalAlign="Center" Width="100%" VerticalAlign="Middle">
                                <asp:TableCell VerticalAlign="Middle">                                  
                                  <br /><asp:Image  runat="server" CssClass="circular" ID="imgcorner1"/>&nbsp&nbsp&nbsp                                     
                                </asp:TableCell>
                              <asp:TableCell VerticalAlign="Middle">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:TextBox ID="txbCorners1" CssClass="txbClassMatch" runat="server" TextMode="Number" Width="60px" Height="30px"></asp:TextBox>                                      
                                  <br />
                                  <br />
                              </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                               <asp:TableCell VerticalAlign="Middle">                                  
                                  <br /><asp:Image  runat="server" CssClass="circular" ID="imgsaver1"/>&nbsp&nbsp&nbsp                                     
                                </asp:TableCell>
                              <asp:TableCell VerticalAlign="Middle">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:TextBox ID="txbSaver1" CssClass="txbClassMatch" runat="server" TextMode="Number" Width="60px" Height="30px"></asp:TextBox>                                      
                                  <br />
                                  <br />
                              </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                               <asp:TableCell VerticalAlign="Middle">                                  
                                  <br /><asp:Image  runat="server" CssClass="circular" ID="imgcardyellow1"/>&nbsp&nbsp&nbsp                                     
                                </asp:TableCell>
                              <asp:TableCell VerticalAlign="Middle">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="lblCardyellow1" Text="0" Font-Size="40px" CssClass="lblFont3" ></asp:Label>
                                  <br />
                                  <br />
                              </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                               <asp:TableCell VerticalAlign="Middle">                                  
                                  <br /><asp:Image  runat="server" CssClass="circular" ID="imgcardred1"/>&nbsp&nbsp&nbsp                                     
                                </asp:TableCell>
                              <asp:TableCell VerticalAlign="Middle">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="lblCardRed1" Text="0" Font-Size="40px" CssClass="lblFont3" ></asp:Label>
                                  <br />
                                  <br />
                              </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:Panel>
                </asp:TableCell>

                <asp:TableCell VerticalAlign="Middle" BorderWidth="10px" BorderColor="White">
                    <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                        <asp:Table runat="server"  HorizontalAlign="Center" VerticalAlign="Middle">
                            <asp:TableRow HorizontalAlign="Center" Width="100%" VerticalAlign="Middle">
                                <asp:TableCell VerticalAlign="Middle">
                                   <br /><asp:Image  runat="server" CssClass="circular" ID="imgcorner2"/>&nbsp&nbsp&nbsp                                                                    
                              </asp:TableCell>
                              <asp:TableCell VerticalAlign="Middle">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:TextBox ID="txbCorners2" CssClass="txbClassMatch" runat="server" TextMode="Number" Width="60px" Height="30px"></asp:TextBox>                                      
                                  <br />
                                  <br />
                              </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                               <asp:TableCell VerticalAlign="Middle">                                  
                                  <br /><asp:Image  runat="server" CssClass="circular" ID="imgsaver2"/>&nbsp&nbsp&nbsp                                     
                                </asp:TableCell>
                              <asp:TableCell VerticalAlign="Middle">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:TextBox ID="txbSaver2" CssClass="txbClassMatch" runat="server" TextMode="Number" Width="60px" Height="30px"></asp:TextBox>                                      
                                  <br />
                                  <br />
                              </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                               <asp:TableCell VerticalAlign="Middle">                                  
                                  <br /><asp:Image  runat="server" CssClass="circular" ID="imgcardyellow2"/>&nbsp&nbsp&nbsp                                     
                                </asp:TableCell>
                              <asp:TableCell VerticalAlign="Middle">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="lblcardyellow2" Text="0" Font-Size="40px" CssClass="lblFont3" ></asp:Label>
                                  <br />
                                  <br />
                              </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                               <asp:TableCell VerticalAlign="Middle">                                  
                                  <br /><asp:Image  runat="server" CssClass="circular" ID="imgcardred2"/>&nbsp&nbsp&nbsp                                     
                                </asp:TableCell>
                              <asp:TableCell VerticalAlign="Middle">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="lblcardred2" Text="0" Font-Size="40px" CssClass="lblFont3" ></asp:Label>
                                  <br />
                                  <br />
                              </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:Panel>
                </asp:TableCell>
            </asp:TableRow>            
        </asp:Table>
           <br />
        <asp:Table runat="server" ID ="tbladmin" BorderStyle="None" BackColor="White" Height="100%" Width="80%" HorizontalAlign="Center" CssClass="roundedChart">
            <asp:TableRow>
               <asp:TableCell>
                   <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label1" Text="Align" Font-Size="Medium" CssClass="lblFontmatch" ></asp:Label>
               </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell VerticalAlign="Middle" BorderWidth="10px" BorderColor="White">
                    <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%" ID="panel1">
                        <asp:Table runat="server">
                            <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                  <asp:Table runat="server" HorizontalAlign="Center">
                                      <asp:TableRow>
                                          <asp:TableCell runat="server" Width="7px"></asp:TableCell>
                                          <asp:TableCell>
                                              <div  style="width: 100%; height: 300px; overflow: scroll">
                                                  <asp:GridView ID="grvTeam1" RowStyle-HorizontalAlign="Center" runat="server" AllowPaging="false" CssClass="ddlmatch" HorizontalAlign="Left" Width="100%" >
                                                   <Columns>
                                                       <asp:TemplateField >
                                                           <ItemTemplate>
                                                               <asp:CheckBox runat="server" ID="chkplayert1" />
                                                               <asp:CheckBox runat="server" ID="chkiscaptt1" />
                                                               <asp:TextBox runat="server" ID="txtrepltimet1" Width="23px"></asp:TextBox>
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
                        <asp:Table runat="server">
                            <asp:TableRow>
                                <asp:TableCell>
                                       <br />&nbsp&nbsp<asp:Label runat="server" ID="lbladdreplace" Text="Add replace" CssClass="lblFontmatch" ></asp:Label> <br />                                        
                                </asp:TableCell>
                            </asp:TableRow>                               
                            <asp:TableRow runat="server"   HorizontalAlign="Center">
                                <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle">
                                    <asp:DropDownList runat="server" ID="ddlplayernamet1" CssClass="ddlmatch">
                                    </asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle">
                                    <asp:TextBox runat="server" ID="txtreptimet1" CssClass="txbClassmatch" TextMode="Number"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle">
                                    <asp:dropDownList runat="server" ID="ddlreplacenamet1" CssClass="ddlmatch"> </asp:dropDownList>
                                </asp:TableCell>
                                <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle">
                                    <asp:Button runat="server" ID="btnaddreplacet1" CssClass="btnmatch"  Width="45px" Text="+"  OnClick="btnaddreplace_Click"/>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:Panel>
                </asp:TableCell>
                <asp:TableCell VerticalAlign="Middle" BorderWidth="10px" BorderColor="White" >
                    <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%" ID="panel2">
                        <asp:Table runat="server">
                            <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:Table runat="server" HorizontalAlign="Center">
                                      <asp:TableRow>
                                          <asp:TableCell runat="server" Width="7px"></asp:TableCell>
                                          <asp:TableCell>
                                              <div  style="width: 100%; height: 300px; overflow: scroll">
                                                  <asp:GridView ID="grvTeam2" RowStyle-HorizontalAlign="Center" runat="server" AllowPaging="false" CssClass="ddlmatch" HorizontalAlign="Right" Width="100%" >
                                                   <Columns>
                                                       <asp:TemplateField >
                                                           <ItemTemplate>
                                                               <asp:CheckBox runat="server" ID="chkplayert2" />
                                                               <asp:CheckBox runat="server" ID="chkiscaptt2" />
                                                                 <asp:TextBox runat="server" ID="txtrepltimet2" Width="23px"></asp:TextBox>
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
                        <asp:Table runat="server">
                            <asp:TableRow>
                                <asp:TableCell  runat="server" VerticalAlign="Middle">
                                    <br />&nbsp&nbsp<asp:Label runat="server" ID="lbladdreplacet2" Text="Add replace" CssClass="lblFontmatch" ></asp:Label> <br />                                        
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server"   HorizontalAlign="Center">
                                <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle">
                                    <asp:DropDownList runat="server" ID="ddlplayernamet2" CssClass="ddlmatch">
                                    </asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle">
                                    <asp:TextBox runat="server" ID="txtreptimet2" CssClass="txbClassmatch" TextMode="Number"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle">
                                    <asp:dropDownList runat="server" ID="ddlreplacenamet2" CssClass="ddlmatch"> </asp:dropDownList>
                                </asp:TableCell>
                                <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle">
                                    <asp:Button runat="server" ID="btnaddreplacet2" CssClass="btnmatch"  Width="45px" Text="+"  OnClick="btnaddreplacet2_Click"/>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:Panel>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
               <asp:TableCell>
                   <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label2" Text="Goals" Font-Size="Medium" CssClass="lblFontmatch" ></asp:Label>
               </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell VerticalAlign="Middle" BorderWidth="10px" BorderColor="White">
                    <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%"  ID="panel3">
                        <asp:Table runat="server" HorizontalAlign="Center">
                            <asp:TableRow>
                                <asp:TableCell>
                                    <br />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server" HorizontalAlign="Center">
                                <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                                    <asp:DropDownList runat="server" ID="ddlGoalPlayert1" CssClass="ddlmatch">
                                    </asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle">
                                    <asp:TextBox runat="server" ID="txtGoalMinutet1" CssClass="txbClassmatch" TextMode="Number"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle">
                                    <asp:Button runat="server" ID="btnaddgoalt1" CssClass="btnmatch"  Width="45px" Text="+" OnClick="btnaddgoalt1_Click"/>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
                        </asp:Table>
                        <asp:Table runat="server" HorizontalAlign="Center">
                            <asp:TableRow>
                                <asp:TableCell runat="server" Width="7px"></asp:TableCell>
                                <asp:TableCell>
                                    <div  style="width: 100%; height: 300px; overflow: scroll">
                                        <asp:GridView ID="grvGoalsT1" RowStyle-HorizontalAlign="Center" runat="server" AllowPaging="false" CssClass="ddlmatch" HorizontalAlign="Center" Width="100%" >
                                        <Columns>
                                            <asp:TemplateField >
                                                <ItemTemplate>
                                                        <asp:TextBox runat="server" ID="txtGoalt1" Width="23px"></asp:TextBox>
                                                </ItemTemplate>                                             
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>  
                                    </div>                                                                                                                         
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
                        </asp:Table>                      
                    </asp:Panel>
                </asp:TableCell>
                <asp:TableCell VerticalAlign="Middle" BorderWidth="10px" BorderColor="White">
                    <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                        <asp:Table runat="server" HorizontalAlign="Center"> 
                            <asp:TableRow>
                                <asp:TableCell>
                                    <br />
                                </asp:TableCell>
                            </asp:TableRow>                                                       
                            <asp:TableRow runat="server" HorizontalAlign="Center">
                                <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle"> 
                                    <asp:DropDownList runat="server" ID="ddlGoalPlayert2" CssClass="ddlmatch">
                                    </asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle">
                                    <asp:TextBox runat="server" ID="txtGoalMinutet2" CssClass="txbClassmatch" TextMode="Number"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle">
                                    <asp:Button runat="server" ID="btnaddgoalt2" CssClass="btnmatch"  Width="45px" Text="+"  OnClick="btnaddgoalt2_Click"/>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
                        </asp:Table>
                        <asp:Table runat="server" HorizontalAlign="Center">
                            <asp:TableRow>
                                <asp:TableCell runat="server" Width="7px"></asp:TableCell>
                                <asp:TableCell>
                                    <div  style="width: 100%; height: 300px; overflow: scroll">
                                        <asp:GridView ID="grvGoalsT2" RowStyle-HorizontalAlign="Center" runat="server" AllowPaging="false" CssClass="ddlmatch" HorizontalAlign="Left" Width="100%" >
                                        <Columns>
                                            <asp:TemplateField >
                                                <ItemTemplate>
                                                    <asp:TextBox runat="server" ID="txtGoalt2" Width="23px"></asp:TextBox>
                                                </ItemTemplate>                                             
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>  
                                    </div>                                                                                                                         
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
                        </asp:Table> 
                    </asp:Panel>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
               <asp:TableCell>
                   <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="Label3" Text="Cards" Font-Size="Medium" CssClass="lblFontmatch" ></asp:Label>
               </asp:TableCell>
            </asp:TableRow>
            
            <asp:TableRow>
                <asp:TableCell VerticalAlign="Middle" BorderWidth="10px" BorderColor="White">
                    <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%" ID="panel4">
                        <asp:Table runat="server">
                            <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                                    <asp:DropDownList runat="server" ID="ddlCardst1" CssClass="ddlmatch"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle">
                                    <asp:DropDownList runat="server" ID="ddlColorT1" CssClass="ddlmatch"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle">
                                    <asp:TextBox runat="server" ID="CardMinuteT1" CssClass="txbClassmatch" TextMode="Number"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle">
                                    <asp:Button runat="server" ID="btnAddCardT1" CssClass="btnmatch"  Width="45px" Text="+"  OnClick="btnAddCardT1_Click"/>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
                        </asp:Table>
                        <asp:Table runat="server" HorizontalAlign="Center">
                            <asp:TableRow>
                                <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle">                                  
                                  <asp:Table runat="server" HorizontalAlign="Center">
                                      <asp:TableRow>
                                          <asp:TableCell runat="server" Width="7px"></asp:TableCell>
                                          <asp:TableCell>
                                              <div  style="width: 110%; height: 300px; overflow: scroll">
                                                  <asp:GridView ID="grvCardsT1" RowStyle-HorizontalAlign="Center" runat="server" AllowPaging="false" CssClass="ddlmatch" HorizontalAlign="Center" Width="100%" >
                                                   <Columns>
                                                       <asp:TemplateField >
                                                           <ItemTemplate>
                                                                 <asp:TextBox runat="server" ID="txtCardcolort1" Width="40px"></asp:TextBox>
                                                                 <asp:TextBox runat="server" ID="txtCardminutet1" Width="40px"></asp:TextBox>
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
                    </asp:Panel>
                </asp:TableCell>
                
                <asp:TableCell VerticalAlign="Middle" BorderWidth="10px" BorderColor="White">
                    <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                        <asp:Table runat="server">
                            <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle"> 
                                    <asp:DropDownList runat="server" ID="ddlCardst2" CssClass="ddlmatch">
                                    </asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle">
                                    <asp:DropDownList runat="server" ID="ddlColorT2" CssClass="ddlmatch"></asp:DropDownList>
                                </asp:TableCell>
                                <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle">
                                    <asp:TextBox runat="server" ID="CardMinuteT2" CssClass="txbClassmatch" TextMode="Number"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle">
                                    <asp:Button runat="server" ID="btnAddCardT2" CssClass="btnmatch" Width="45px" Text="+"  OnClick="btnAddCardT2_Click"/>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
                        </asp:Table>
                        <asp:Table runat="server" HorizontalAlign="Center">
                            <asp:TableRow>
                                <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle">                                  
                                  <asp:Table runat="server" HorizontalAlign="Center">
                                      <asp:TableRow>
                                          <asp:TableCell runat="server" Width="7px"></asp:TableCell>
                                          <asp:TableCell>
                                              <div  style="width: 110%; height: 300px; overflow: scroll">
                                                  <asp:GridView ID="grvCardsT2" RowStyle-HorizontalAlign="Center" runat="server" AllowPaging="false" CssClass="ddlmatch" HorizontalAlign="left" Width="80%" >
                                                   <Columns>
                                                       <asp:TemplateField >
                                                           <ItemTemplate>
                                                                <asp:TextBox runat="server" ID="txtCardcolort2" Width="40px"></asp:TextBox>
                                                                 <asp:TextBox runat="server" ID="txtCardminutet2" Width="40px"></asp:TextBox>
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
                    </asp:Panel>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell Width="100%">
                    
                </asp:TableCell>
                <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle">
                    <asp:Button runat="server" ID="btnSaveAllChanges" CssClass="btnmatch" Width="120px" Text="Save" OnClick="btnSaveAllChanges_Click" Height="50px"/>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    
    </div>
    </form>
</body>
</html>
