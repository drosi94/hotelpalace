<%@ Page Title="Contact Us" Language="C#" MasterPageFile="~/Hotel.master" AutoEventWireup="true" Inherits="Contact_Us" Codebehind="ContactUs.aspx.cs" %>

<%@ Register Assembly="GMaps" Namespace="Subgurim.Controles" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMaster" Runat="Server">

    <p>Contact Us</p>
        <cc1:GMap ID="GMap1" runat="server" Width="400px" Height="500px"/>
</asp:Content>

