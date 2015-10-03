<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApplication2.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-weight: bold;
            text-decoration: underline;
            background-color: #FFFFFF;
        }
        .auto-style2 {
            width: 100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
         <table align="center" style="width: 443px; background-color: #006699">
<tr>
<td></td>
<td align="right" class="auto-style2" >
</td>
<td align="left">
    <span class="auto-style1">Registration Form</span>
  </td>
</tr>
<tr>
<td></td>
<td align="right" class="auto-style2" >
<asp:Label ID="lbluser" runat="server" Text="Username"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtuser" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td></td>
<td align="right" class="auto-style2" >
<asp:Label ID="lblpwd" runat="server" Text="Password"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
</td>
</tr>
<tr>
<td></td>
<td align="right" class="auto-style2" >
<asp:Label ID="lblcnfmpwd" runat="server" Text="Confirm Password"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtcnmpwd" runat="server" TextMode="Password"></asp:TextBox>
</td>
</tr>
<tr>
<td></td>
<td align="right" class="auto-style2">
<asp:Label ID="lblfname" runat="server" Text="FirstName"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td></td>
<td align="right" class="auto-style2">
<asp:Label ID="lbllname" runat="server" Text="LastName"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td></td>
<td align="right" class="auto-style2">
<asp:Label ID="lblemail" runat="server" Text="Email"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td></td>
<td align="right" class="auto-style2" >
<asp:Label ID="lblCnt" runat="server" Text="Phone No"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtphone" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td></td>
<td align="right" class="auto-style2" >
<asp:Label ID="lbladd" runat="server" Text="Location"></asp:Label>
</td>
<td align="left">
<asp:TextBox ID="txtlocation" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td></td>
<td class="auto-style2"></td>

<td align="left" ><asp:Button ID="btnsubmit" runat="server" Text="Save"
onclick="btnsubmit_Click" />
<input type="reset" value="Reset" />
</td>
</tr>
<tr>
<td></td>
<td class="auto-style2"></td>
<td>
<span style= "color:Red; font-weight :bold"> <asp:Label ID="lblErrorMsg" runat="server"></asp:Label></span>
</td>
</tr>
</table>














    </div>
    </form>
</body>
</html>
