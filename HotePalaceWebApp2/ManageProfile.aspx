<%@ Page Title="" Language="C#" MasterPageFile="~/Hotel.master" AutoEventWireup="true" Inherits="ManageProfile" Codebehind="ManageProfile.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMaster" Runat="Server">

    <p>
        <asp:Table ID="formT" runat="server" Height="178px" Width="480px">
            <asp:TableRow runat="server" BorderStyle="None">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label></asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="firstNameTB" runat="server"></asp:TextBox></asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="First Name is Required" ControlToValidate="firstNameTB"></asp:RequiredFieldValidator></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label></asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="lastNameTB" runat="server"></asp:TextBox></asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Last Name is Required" ControlToValidate="lastNameTB"></asp:RequiredFieldValidator></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label></asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:DropDownList ID="genderDPL" runat="server">
                    <asp:ListItem>Undefined</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>

                </asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label4" runat="server" Text="Age"></asp:Label></asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="ageTB" runat="server" TextMode="Number"></asp:TextBox></asp:TableCell>
                <asp:TableCell runat="server"><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Age is Required" ControlToValidate="ageTB"></asp:RequiredFieldValidator></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label5" runat="server" Text="Address"></asp:Label></asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="addressTB" runat="server"></asp:TextBox></asp:TableCell>
                <asp:TableCell runat="server"><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Address is Required" ControlToValidate="addressTB"></asp:RequiredFieldValidator></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Button ID="submitB" runat="server" Text="Submit" OnClick="submitB_Click" /></asp:TableCell>
                <asp:TableCell runat="server"><input id="Reset1" type="reset" value="Reset" /></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </p>
    <p><asp:Label ID="manageProfileL" runat="server" Text="You have Already Manage You Profile" Visible="false"></asp:Label></p>
    <asp:Button ID="editProfileB" runat="server" Text="Edit Profile" Visible="False" OnClick="editProfileB_Click" />
</asp:Content>

