<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="BlazorFormsDemo.About" %>
<%@ Register Src="~/Controls/Banner.ascx" TagPrefix="uc" TagName="Banner" %>

<div>
	<h1>Blazor Core WebForms Demo</h1>
	<p>Welcome to the Blazor Core WebForms Demo</p>


	<uc:Banner runat="server" ID="InnerOpenAuthLogin" />
</div>