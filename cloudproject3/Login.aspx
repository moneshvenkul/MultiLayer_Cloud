<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Lumino - Login</title>
	<link href="css/bootstrap.min.css" rel="stylesheet">
	<link href="css/datepicker3.css" rel="stylesheet">
	<link href="css/styles.css" rel="stylesheet">
	<!--[if lt IE 9]>
	<script src="js/html5shiv.js"></script>
	<script src="js/respond.min.js"></script>
	<![endif]-->
</head>
<body>
	<div class="row">
		<div class="col-xs-10 col-xs-offset-1 col-sm-8 col-sm-offset-2 col-md-4 col-md-offset-4">
			<div class="login-panel panel panel-default">
				<div class="panel-heading">Log in</div>
				<div class="panel-body">
                     <form id="form1" runat="server" role="form">
					
						<fieldset>
							<div class="form-group">
<asp:TextBox ID="TextBox1" runat="server" class="form-control" placeholder="E-mail" name="email"  ></asp:TextBox>
								
							</div>
							<div class="form-group">
                                <asp:TextBox ID="TextBox2" runat="server" class="form-control" placeholder="Password" name="password" type="password"  ></asp:TextBox>
							
							</div>
                            	<div class="form-group">
							<asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Login" OnClick="Button1_Click" Width="101px" />
                                    </div>
                            <div class="form-group">
                            <asp:Button ID="Button2" runat="server" class="btn btn-primary" Text="Register" OnClick="Button2_Click" />
                                </div>
							
					</form>
				</div>
			</div>
		</div><!-- /.col-->
	</div><!-- /.row -->	
	

<script src="js/jquery-1.11.1.min.js"></script>
	<script src="js/bootstrap.min.js"></script>
</body>
</html>
