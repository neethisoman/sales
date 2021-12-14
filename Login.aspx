<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TestApplication3.Login" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <form runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server" />
            <asp:TextBox ID="loginName" runat="server" CssClass="textBoxStyle"></asp:TextBox><br/><br/>
            <asp:TextBox ID="password" runat="server" TextMode="Password" CssClass="textBoxStyle"></asp:TextBox>
            <br />
            <div style="padding-top:30px;text-align:left">
                <asp:Button ID="loginBtn" runat="server" CssClass="buttonStyle" Text="LogIn" OnClick="Login_Click"/>
            </div>
            <ajaxToolkit:TextBoxWatermarkExtender TargetControlID="loginName" WatermarkText="User Name" ID="TextBoxWatermarkExtender1" runat="server"/>
            <ajaxToolkit:TextBoxWatermarkExtender TargetControlID="password" WatermarkText="Password" ID="TextBoxWatermarkExtender2" runat="server"/>
        </form>

    <style type="text/css">
        .textBoxStyle
        {
           	border: 0px;
	        -webkit-border-radius: 10px;
	        -moz-border-radius: 10px;
	        border-radius: 10px;
	        outline:0;
	        height:50px;
	        width: 250px;
	        padding-left:10px;
	        padding-right:10px;
        }
        .buttonStyle 
        {
          background-color: #eb0032;
          border: none;
          color: white;
          -webkit-border-radius: 10px;
	      -moz-border-radius: 10px;
	       border-radius: 10px;
          padding:6px 6px;         
          text-align: center;
          text-decoration: none;
          display: inline-block;
          font-size: 16px;
        }
    </style>
</asp:Content>

