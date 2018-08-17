<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Seguridad.Default" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0" name="viewport" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <title>Login</title>
    <link rel="apple-touch-icon" href="Web/componentes/login/assets/img/kit/free/apple-icon.png">
    <link rel="icon" href="Web/componentes/login/assets/img/kit/free/favicon.png">
    <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css" />
    <link rel="stylesheet" href="Web/componentes/login/assets/css/material-kit.css?v=2.0.2">
    <link href="Web/componentes/login/assets/assets-for-demo/demo.css" rel="stylesheet" />
        <style>
            #txtIngresar
            {
                background-color: #70BF16;
            }

            #lblCredenInco{
            color:red;
            }
        </style>
</head>
<body class="signup-page ">
<form runat="server">
    <div class="page-header header-filter" filter-color="purple" style="background-image: url(&apos;Web/componentes/login/assets/img/kit/free/bg7.jpg&apos;); background-size: cover; background-position: top center;">
        <div class="container">
            <div class="row">
                <div class="col-md-5 ml-auto mr-auto">
                    <div class="card card-signup">
                        <h2 class="card-title text-center"><img src="Web/Imagenes/fdiaz.png" alt="" style="width:60%;"></h2>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-md-11 mr-auto">
                                    <form class="form">
                                        <div class="form-group">
                                            <div class="input-group">
                                                <div class="input-group-prepend">
                                                    <span class="input-group-text">
                                                        <i class="material-icons">account_box</i>
                                                    </span>
                                                </div>
                                                <asp:TextBox runat="server" id="txtUsername" Text="admin" CssClass="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="input-group">
                                                <div class="input-group-prepend">
                                                    <span class="input-group-text">
                                                        <i class="material-icons">lock_outline</i>
                                                    </span>
                                                </div>
                                                <asp:TextBox runat="server" id="txtPassword" CssClass="form-control" Text="Admin" TextMode="Password"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-check">
                                             <asp:Label runat="server" Visible="false" id="lblCredenInco" CssClass="form-check-label rojo">Credenciales Incorrectas</asp:Label>
                                                    <br/><br/>
                                            <label class="form-check-label">
                                                <a href="#something">Recuperar Contraseña</a>.
                                            </label>
                                        </div>
                                        <div class="text-center">
                                            <asp:Button runat="server" CssClass="btn btn-primary btn-round" id="btnIngresar" Text="INGRESAR" ValidationGroup="login"></asp:Button>
                                        </div>
                                    </form>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <footer class="footer ">
            <div class="container">
                <nav class="pull-left">
                    <ul>
                        <li>
                            <a href="#"></a>
                        </li>
                    </ul>
                </nav>
            </div>
        </footer>
    </div>
</form>
</body>
<script src="Web/componentes/login/assets/js/core/jquery.min.js"></script>
<script src="Web/componentes/login/assets/js/core/popper.min.js"></script>
<script src="Web/componentes/login/assets/js/bootstrap-material-design.js"></script>
<script src="Web/componentes/login/assets/js/plugins/moment.min.js"></script>
<script src="Web/componentes/login/assets/js/plugins/bootstrap-datetimepicker.min.js"></script>
<script src="Web/componentes/login/assets/js/plugins/nouislider.min.js"></script>
<script src="Web/componentes/login/assets/js/material-kit.js?v=2.0.2"></script>
<script src="Web/componentes/login/assets/assets-for-demo/js/material-kit-demo.js"></script>
</html>