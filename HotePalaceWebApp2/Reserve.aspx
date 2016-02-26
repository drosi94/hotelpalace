<%@ Page Title="" Language="C#" MasterPageFile="~/Hotel.master" AutoEventWireup="true" Inherits="Reserve" Codebehind="Reserve.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMaster" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td style="width: 102px; height: 58px">Start Date</td>
            <td style="width: 229px; height: 58px">
                <br />
                <br />
                <asp:TextBox ID="startDateTB" runat="server" TextMode="Date"></asp:TextBox>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
            <td style="height: 58px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="startDateTB" ErrorMessage="You Didnt Pick Start Date" style="color: #FF0000; font-size: medium"></asp:RequiredFieldValidator>
                <br />
                <br />
                 <asp:RangeValidator ID="startDateRV" runat="server" ErrorMessage="Start Day cannot be on past" ControlToValidate="startDateTB" 
                Display="Dynamic" Type="Date" style="font-size: medium; color: #FF0000" ></asp:RangeValidator >
            </td>
        </tr>
        <tr>
            <td style="width: 102px; ">End Date</td>
            <td style="width: 229px">
                <br />
                <br />
                <asp:TextBox ID="endDateTB" runat="server" TextMode="Date"></asp:TextBox>
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="endDateTB" ErrorMessage="You Didnt Pick End Date" style="color: #FF0000; font-size: medium"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:CompareValidator ID="cvtxtStartDate" runat="server"
                    ControlToCompare="startDateTB" CultureInvariantValues="true"
                    Display="Dynamic" EnableClientScript="true"
                    ControlToValidate="endDateTB"
                    ErrorMessage="Start date must be earlier than end date"
                    Type="Date" SetFocusOnError="true" Operator="GreaterThanEqual"
                    Text="Start date must be earlier than end date" style="color: #FF0000; font-size: medium"></asp:CompareValidator>            

            </td>
        </tr>
        <tr>
            <td style="width: 102px; height: 38px">Room</td>
            <td style="height: 38px; width: 229px">
                <asp:DropDownList ID="roomsDPL" runat="server">
                </asp:DropDownList>
            </td>
            <td style="height: 38px"></td>
        </tr>
         <tr>
            <td style="width: 102px; height: 48px">
                <asp:Button ID="findRoomsB" runat="server" Height="36px" OnClick="findRoomsB_Click" Text="Find Rooms" Width="97px" />
             </td>
                         <td style="width: 102px; height: 48px">
                <asp:Button ID="Sumbit" runat="server" Height="36px" OnClick="sumbitRoomsB_Click" Text="Submit" Width="97px" />
             </td>         
        </tr>
    </table>
</asp:Content>

