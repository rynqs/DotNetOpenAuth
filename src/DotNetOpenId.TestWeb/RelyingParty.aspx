﻿<%@ Page Language="C#" AutoEventWireup="true" UICulture="en" %>

<%-- The UICulture="en" tests for regressions on GoogleCode Issue 60. --%>
<%@ Register Assembly="DotNetOpenId" Namespace="DotNetOpenId.RelyingParty" TagPrefix="openid" %>

<script runat="server">
	protected void loginButton_Click(object sender, EventArgs e) {
		OpenIdTextBox1.LogOn();
	}
</script>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">
	<openid:OpenIdTextBox ID="OpenIdTextBox1" runat="server" />
	<asp:Button ID="loginButton" runat="server" OnClick="loginButton_Click" Text="Login" />
	</form>
</body>
</html>
