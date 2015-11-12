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
                <asp:ImageButton runat="server" ID="imgLogoHome" src="Images/logo0.png" />
            </ul>
        </nav>          
    </div>
    <div>
       <%-- <nav class="admenu">                
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
        </nav>    --%>      
        </div>
       <div>        
        <br />
        <asp:Table runat="server" BorderStyle="None" BackColor="White" Height="100%" Width="90%" HorizontalAlign="Center" CssClass="roundedChart">
            <asp:TableRow runat ="server">
              <asp:TableCell VerticalAlign="Bottom" BorderWidth="10px" BorderColor="White">
                  <asp:Panel runat="server" CssClass="roundedChart2" BackColor="WhiteSmoke" Width="100%">
                      <asp:Table runat="server">
                          <asp:TableRow runat="server">                                                            
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Top">                                  
                                  <br />&nbsp&nbsp&nbsp<asp:Label runat="server" ID="lbldatetime" Text="DateTime" Font-Size="Medium" CssClass="lblFontmatch" ></asp:Label>
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Top">
                                  <br />&nbsp<asp:Label runat="server" ID="lblStadium" Text="Stadium" Font-Size="Medium" CssClass="lblFontmatch" ></asp:Label>
                              </asp:TableCell>
                          </asp:TableRow>
                          <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txtmatchdatetime" CssClass="txbClassmatch" Width="200px" Text="" TextMode="DateTime" ></asp:TextBox>
                              </asp:TableCell>    
                              <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                  &nbsp&nbsp&nbsp<asp:TextBox runat="server" ID="txtmatchstadium" CssClass="txbClassmatch" Width="200px" Text="" ></asp:TextBox>
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
                                <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle" Width ="230px">                                  
                                  <br />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label runat="server" ID="team1" Text="Team1" Font-Size="Medium" CssClass="lblFontmatch" ></asp:Label> &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp                                       
                              </asp:TableCell>
                              <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle" Width ="230px">                                 
                                  <br />&nbsp&nbsp&nbsp&nbsp<asp:Label runat="server" ID="team2" Text="Team2" Font-Size="Medium" CssClass="lblFontmatch" ></asp:Label>                                        
                              </asp:TableCell>
                            </asp:TableRow>
                            <%-- Grid views components --%>
                            <asp:TableRow runat="server">                              
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">                                  
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
                              <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Bottom">                                  
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
                            
                            <%-- Add a replace --%>
                            <asp:TableRow runat="server">
                                     <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle" Width ="600px">
                                         <asp:Table runat="server">
                                             <asp:TableRow>
                                                 <asp:TableCell  runat="server" HorizontalAlign="Left" VerticalAlign="Top">
                                                     <br />&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label runat="server" ID="lbladdreplace" Text="Add replace" CssClass="lblFontmatch" ></asp:Label> <br />                                        
                                                 </asp:TableCell>

                                             </asp:TableRow>
                                             <asp:TableRow runat="server">
                                                  <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Bottom">
                                                     <asp:DropDownList runat="server" ID="ddlplayernamet1" CssClass="ddlmatch">
                                                     </asp:DropDownList>
                                                 </asp:TableCell>
                                                 <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                                     <asp:TextBox runat="server" ID="txtreptimet1" CssClass="txbClassmatch" TextMode="Number"></asp:TextBox>
                                                 </asp:TableCell>
                                                 <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                                     <asp:dropDownList runat="server" ID="ddlreplacenamet1" CssClass="ddlmatch"> </asp:dropDownList>
                                                 </asp:TableCell>
                                                 <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Bottom">
                                                     <asp:Button runat="server" ID="btnaddreplacet1" CssClass="btnmatch"  Width="45px" Text="+"  OnClick="btnaddreplace_Click"/>
                                                 </asp:TableCell>
                                             </asp:TableRow>
                                             <asp:TableRow>
                                                 <asp:TableCell>

                                                 </asp:TableCell>
                                             </asp:TableRow>
                                         </asp:Table>  
                                     </asp:TableCell>
                                     <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Width ="600px">                                  
                                           <asp:Table runat="server">
                                             <asp:TableRow>
                                                 <asp:TableCell  runat="server" HorizontalAlign="Right" VerticalAlign="Top">
                                                     <br />&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label runat="server" ID="lbladdreplacet2" Text="Add replace" CssClass="lblFontmatch" ></asp:Label> <br />                                        
                                                 </asp:TableCell>

                                             </asp:TableRow>
                                             <asp:TableRow runat="server">
                                                  <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Bottom">
                                                     <asp:DropDownList runat="server" ID="ddlplayernamet2" CssClass="ddlmatch">
                                                     </asp:DropDownList>
                                                 </asp:TableCell>
                                                 <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                                     <asp:TextBox runat="server" ID="txtreptimet2" CssClass="txbClassmatch" TextMode="Number"></asp:TextBox>
                                                 </asp:TableCell>
                                                 <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                                     <asp:dropDownList runat="server" ID="ddlreplacenamet2" CssClass="ddlmatch"> </asp:dropDownList>
                                                 </asp:TableCell>
                                                 <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Bottom">
                                                     <asp:Button runat="server" ID="btnaddreplacet2" CssClass="btnmatch"  Width="45px" Text="+"  OnClick="btnaddreplacet2_Click"/>
                                                 </asp:TableCell>
                                             </asp:TableRow>
                                         </asp:Table>     
                                    </asp:TableCell>
                            </asp:TableRow>
                            <%-- Goals --%>
                            <asp:TableRow>
                                <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle" Width ="100px">
                                     <br />&nbsp&nbsp&nbsp&nbsp&nbsp
                                         <asp:Table runat="server">
                                             <asp:TableRow>
                                                 <asp:TableCell  runat="server" HorizontalAlign="Left" VerticalAlign="Top">
                                                     <br />&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label runat="server" ID="lblGoalst1" Text="Goals Team 1" CssClass="lblFontmatch" ></asp:Label> <br />                                        
                                                 </asp:TableCell>
                                             </asp:TableRow>
                                             <asp:TableRow runat="server">
                                                  <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                                     <asp:DropDownList runat="server" ID="ddlGoalPlayert1" CssClass="ddlmatch">
                                                     </asp:DropDownList>
                                                 </asp:TableCell>
                                                 <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                                     <asp:TextBox runat="server" ID="txtGoalMinutet1" CssClass="txbClassmatch" TextMode="Number"></asp:TextBox>
                                                 </asp:TableCell>
                                                 <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Bottom">
                                                     <asp:Button runat="server" ID="btnaddgoalt1" CssClass="btnmatch"  Width="45px" Text="+" OnClick="btnaddgoalt1_Click"/>
                                                 </asp:TableCell>
                                             </asp:TableRow>
                                         </asp:Table>  
                                     </asp:TableCell>
                                     <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle" Width ="100px">                                  
                                           <asp:Table runat="server">
                                             <asp:TableRow>
                                                 <asp:TableCell  runat="server" HorizontalAlign="Right" VerticalAlign="Bottom">
                                                     <br /><br />&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label runat="server" ID="lblGoalst2" Text="Goals Team 2" CssClass="lblFontmatch" ></asp:Label>                                      
                                                 </asp:TableCell>
                                             </asp:TableRow>

                                               <asp:TableRow> 
                                                   <asp:TableCell>
                                                       &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                                                   </asp:TableCell>
                                               </asp:TableRow>
                                             <asp:TableRow runat="server">
                                                  <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Bottom"> 
                                                     <asp:DropDownList runat="server" ID="ddlGoalPlayert2" CssClass="ddlmatch">
                                                     </asp:DropDownList>
                                                 </asp:TableCell>
                                                 <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Bottom">
                                                     <asp:TextBox runat="server" ID="txtGoalMinutet2" CssClass="txbClassmatch" TextMode="Number"></asp:TextBox>
                                                 </asp:TableCell>
                                                 <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Bottom">
                                                     <asp:Button runat="server" ID="btnaddgoalt2" CssClass="btnmatch"  Width="45px" Text="+"  OnClick="btnaddgoalt2_Click"/>
                                                 </asp:TableCell>
                                             </asp:TableRow>
                                         </asp:Table>     
                                    </asp:TableCell>
                            </asp:TableRow>
                            <%-- Row that contains the gridview for the goals --%>
                            <asp:TableRow>
                                <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">                                  
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
                                  </asp:Table> 
                              </asp:TableCell>  
                              <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">                                  
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
                                  </asp:Table> 
                              </asp:TableCell>   
                            </asp:TableRow>
                            <%-- Card Code --%>
                            <asp:TableRow>
                                <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle" Width ="100px">
                                         <asp:Table runat="server">
                                             <asp:TableRow>
                                                 <asp:TableCell  runat="server" HorizontalAlign="Left" VerticalAlign="Top">
                                                     <br />&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label runat="server" ID="lblCardst1" Text="Cards Team 1" CssClass="lblFontmatch" ></asp:Label> <br />                                        
                                                 </asp:TableCell>
                                             </asp:TableRow>
                                             <asp:TableRow runat="server">
                                                  <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">
                                                     <asp:DropDownList runat="server" ID="ddlCardst1" CssClass="ddlmatch"></asp:DropDownList>
                                                 </asp:TableCell>
                                                 <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Bottom">
                                                     <asp:DropDownList runat="server" ID="ddlColorT1" CssClass="ddlmatch"></asp:DropDownList>
                                                 </asp:TableCell>
                                                 <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                                     <asp:TextBox runat="server" ID="CardMinuteT1" CssClass="txbClassmatch" TextMode="Number"></asp:TextBox>
                                                 </asp:TableCell>
                                                 <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Bottom">
                                                     <asp:Button runat="server" ID="btnAddCardT1" CssClass="btnmatch"  Width="45px" Text="+"  OnClick="btnAddCardT1_Click"/>
                                                 </asp:TableCell>
                                             </asp:TableRow>
                                             <asp:TableRow>
                                                 <asp:TableCell>

                                                 </asp:TableCell>
                                             </asp:TableRow>
                                         </asp:Table>  
                                     </asp:TableCell>
                                     <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle" Width ="100px">                                  
                                           <asp:Table runat="server">
                                             <asp:TableRow>
                                                 <asp:TableCell  runat="server" HorizontalAlign="Right" VerticalAlign="Top">
                                                     <br />&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label runat="server" ID="lblCardst2" Text="Cards Team 2" CssClass="lblFontmatch" ></asp:Label>                                    
                                                 </asp:TableCell>

                                             </asp:TableRow>
                                             <asp:TableRow runat="server">
                                                  <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Bottom"> &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                                                     <asp:DropDownList runat="server" ID="ddlCardst2" CssClass="ddlmatch">
                                                     </asp:DropDownList>
                                                 </asp:TableCell>
                                                 <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                                      <asp:DropDownList runat="server" ID="ddlColorT2" CssClass="ddlmatch"></asp:DropDownList>
                                                 </asp:TableCell>
                                                 <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                                                     <asp:TextBox runat="server" ID="CardMinuteT2" CssClass="txbClassmatch" TextMode="Number"></asp:TextBox>
                                                 </asp:TableCell>
                                                 <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Bottom">
                                                     <asp:Button runat="server" ID="btnAddCardT2" CssClass="btnmatch" Width="45px" Text="+"  OnClick="btnAddCardT2_Click"/>
                                                 </asp:TableCell>
                                             </asp:TableRow>
                                         </asp:Table>     
                                    </asp:TableCell>
                            </asp:TableRow>
                            <%-- Code Cards Gridviews --%>
                            <asp:TableRow>
                                 <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Bottom">                                  
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
                              <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Bottom">                                  
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
                <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Bottom">
                    <asp:Button runat="server" ID="btnSaveAllChanges" CssClass="btnmatch" Width="120px" Text="Save" OnClick="btnSaveAllChanges_Click" Height="50px"/>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
           <br />  
    
    </div>
    </form>
</body>
</html>
