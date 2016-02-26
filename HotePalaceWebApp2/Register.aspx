<%@ Page Title="" Language="C#" MasterPageFile="~/Hotel.master" AutoEventWireup="true" Inherits="Register" Codebehind="Register.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMaster" Runat="Server">

     <div>
    
        <h1 style="text-align: center; height: 64px">Register Page<br />
            <br />
        </h1>
        <table class="auto-style1">
            <tr>
                <td class="auto-style8" style="font-family: 'Times New Roman'; text-decoration: underline; color: #69696A; font-size: medium;">User Name:</td>
                <td class="auto-style9">
                    <asp:TextBox ID="userNameTB" runat="server" Width="180px" style="font-size: medium"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="userNameTB" ErrorMessage="User Name Is Required" ForeColor="Red" style="font-size: medium"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5" style="font-family: 'Times New Roman'; text-decoration: underline; color: #69696A; font-size: medium;">Email:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="emailTB" runat="server" TextMode="Email" Width="180px" style="font-size: medium"></asp:TextBox>
                </td>
                <td class="auto-style11" style="font-size: medium">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="emailTB" ErrorMessage="Email Is Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emailTB" ErrorMessage="Your Email Is Wrong." ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4" style="font-family: 'Times New Roman'; text-decoration: underline; color: #69696A; font-size: medium;">Password:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="passwordTB" runat="server" TextMode="Password" Width="180px" style="font-size: medium"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="passwordTB" ErrorMessage="Password Is Required" ForeColor="Red" style="font-size: medium"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5" style="font-family: 'Times New Roman'; text-decoration: underline; color: #69696A; font-size: medium;">Confim Password</td>
                <td class="auto-style6">
                    <asp:TextBox ID="confirmPasswordTB" runat="server" TextMode="Password" Width="180px" style="font-size: medium"></asp:TextBox>
                </td>
                <td class="auto-style11" style="font-size: medium">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="confirmPasswordTB" ErrorMessage="Confirm Password Is Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="passwordTB" ControlToValidate="confirmPasswordTB" ErrorMessage="Both Passwords Must be Same." ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5" style="font-family: 'Times New Roman'; text-decoration: underline; color: #69696A; font-size: medium;">Country</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="countryDDL" runat="server" DataSourceID="SqlDataSourceCountries" DataTextField="name" DataValueField="name" Width="180px" style="font-size: medium">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSourceCountries" runat="server" ConnectionString="<%$ ConnectionStrings:p3120038ConnectionString %>" SelectCommand="SELECT [name] FROM Website.[Countries]
Order by name ASC"></asp:SqlDataSource>
                </td>
                <td class="auto-style11" style="font-size: medium">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Button ID="submitButton" runat="server" OnClick="Button1_Click" Text="Submit" Width="71px" />
                    <input id="Reset1" type="reset" value="Reset" /></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>

</asp:Content>

