<%@ Page Language="C#" AutoEventWireup="true" Inherits="Login" MasterPageFile="~/Hotel.master" Codebehind="Login.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMaster" runat="server" >
    <div>
    
        <h1 class="auto-style1" style="text-align: center"><strong style="text-align: center">Log in Page</strong></h1>
        <p class="auto-style1">&nbsp;</p>
            <table class="auto-style2">
            <tr>
                <td class="auto-style4" style="text-align: right">UserName:</td>
                
                <td class="auto-style6">
                    <asp:TextBox ID="userNameTB" runat="server" style="text-align: left"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="userNameTB" ErrorMessage="UserName Is Empty" style="font-size: small; color: #FF0000; text-align: center"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Password:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="passwordTB" runat="server" style="text-align: left" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="passwordTB" ErrorMessage="Password Is Empty" style="font-size: small; color: #FF0000; text-align: center"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Button ID="logInB" runat="server" OnClick="logInB_Click" style="text-align: center; margin-left: 0px" Text="Log In" Width="129px" />
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            </table>
            <br />
            
    
    </div>
</asp:Content>
