<%@ Page Language="C#" enableEventValidation="false" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Seguridad.Default" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0" name="viewport" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <title>Login</title>
    <link rel="apple-touch-icon" href="Web/componentes/login/assets/img/kit/free/apple-icon.png">
    <link rel="icon" href="Web/componentes/login/assets/img/kit/free/favicon.png">
    <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons"
    />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css" />
    <link rel="stylesheet" href="Web/componentes/login/assets/css/material-kit.css?v=2.0.2">
    <link href="Web/componentes/login/assets/assets-for-demo/demo.css" rel="stylesheet" />

    <style>
        #txtIngresar {
            background-color: #70BF16;
        }

        #lblCredenInco {
            color: red;
        }

        .btn {
            background-color: black !important;
        }
    </style>
</head>

<body class="signup-page ">
    <form runat="server">
        <div class="page-header header-filter" filter-color="purple" style="width: 100%; height: 100%; background-image: url(&apos;Web/Imagenes/fondo1.jpg&apos;); background-size: cover; background-position: top center;">
            <div class="container">
                <div class="row">
                    <div class="col-md-5 ml-auto mr-auto">
                        <div class="card card-signup">
                            <h2 class="card-title text-center">
                                <img src="Web/Imagenes/logo.png" alt="" style="width:60%;">
                            </h2>
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
                                                <br/>
                                                <br/>
                                                <label class="form-check-label">
                                                    <a href="#something" style="color: black" data-toggle="modal" data-target="#modal-new-user">Recuperar Contraseña</a>.
                                                </label>
                                            </div>
                                            <div class="text-center">
                                                <asp:Button runat="server" CssClass="btn btn-primary" id="btnIngresar" Text="INGRESAR" ValidationGroup="login"></asp:Button>
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
        <div id="modal-new-user" tabindex="-1" role="dialog" class="modal fade colored-header colored-header-primary">
            <div class="modal-dialog custom-width">
                <div class="modal-content">
                    <div class="modal-header" style="background-color: black;">
                        <button type="button" data-dismiss="modal" aria-hidden="true" class="close md-close">
                            <span class="mdi mdi-close"></span>
                        </button>
                        <h3 class="modal-title" style="background-color: black;">Crear Nuevo Usuario</h3>
                    </div>
                    <div class="modal-body">
                        <div class="col-md-6">
                            <div class="form-group">
                                <label>Nombres</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtNuevoNombres"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Rut</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtNuevoRut"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Sexo</label>
                                <asp:DropDownList runat="server" id="ddlNuevoSexo" CssClass="form-control">
                                    <asp:ListItem Value="Femenino">Femenino</asp:ListItem>
                                    <asp:ListItem Value="Masculino">Masculino</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <label>Nombre de Usuario</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtNuevoUsername"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Empresa</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtNuevoEmpresa"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <label>Apellidos</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtNuevoApellidos"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Fecha de Nacimiento</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtNuevoFechaNacimiento"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Perfil</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtNuevoPerfil"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Email</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtNuevoEmail"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Estado</label>
                                <asp:DropDownList runat="server" id="ddlNuevoEstado" CssClass="form-control">
                                    <asp:ListItem Value="1">Activado</asp:ListItem>
                                    <asp:ListItem Value="0">Desactivado</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" data-dismiss="modal" class="btn btn-danger md-close">Cancelar</button>
                        <button type="button" data-dismiss="modal" class="btn btn-primary md-close" style="background-color: black !important;">Guardar</button>
                    </div>
                </div>
            </div>
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