<%@ Page Title="" Language="C#" enableEventValidation="false" MasterPageFile="../Control/MasterPage.master" AutoEventWireup="true" CodeBehind="MantenedorContratos.aspx.cs" Inherits="Seguridad.Web.Configuracion.MantenedorContratos" %>

    <asp:Content id="Content1" ContentPlaceHolderID="head" runat="server">
        <title>Usuarios</title>
        <style>
            .form-control {
                height: 30px !important;
                width: 90% !important;
            }

            .form-group {
                height: 48px;
            }

            #btnGuardarUsuario {
                background-color: black !important;
            }

            .btn-black {
                background-color: black;
                color: white;
            }
        </style>

        <script type="text/javascript">
            function openModalEmpresa() {
                $('#modal-new-company').modal('show');
            }

        </script>
    </asp:Content>
    <asp:Content id="Content2" ContentPlaceHolderID="contentPlaceHolder1" runat="server">
    <input id="idactual" type="hidden" runat="server" />
        <div class="row" style="margin-top:-20px !important">
            <div class="panel panel-default">
                <div class="tab-container">
                    <ul class="nav nav-tabs">
                        <li class="active">
                            <a href="#listarEmpresas" data-toggle="tab" aria-expanded="false">Crear Nueva Empresa</a>
                        </li>
                    </ul>
                    <div class="tab-content">
                        <h4><b>Datos de la Empresa</b></h4>
                        <div class="row">
                            <div class="col-md-3">
                                <label>Razon Social</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtRazonSocial" MaxLength="40" onkeypress="return caracteresTextos(event)"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label>Rut Empresa</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtRutEmpresa" MaxLength="13" onkeypress="return caracteresRut(event)"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label>Nombre Fantasia</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtNombreFantasia" MaxLength="40" onkeypress="return caracteresTextos(event)"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                            </div>
                            <div class="col-md-3">
                                <label>Dirección</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtDireccion" MaxLength="50"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label>Comuna</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtComuna" MaxLength="40" onkeypress="return caracteresTextos(event)"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label>Ciudad</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtCiudad" MaxLength="40" onkeypress="return caracteresTextos(event)"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label>Region</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtRegion" MaxLength="40" onkeypress="return caracteresTextos(event)"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label>Telefono Fijo Empresa</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtTelefonoFijoEmpresa" MaxLength="40" onkeypress="return caracteresTelefono(event)"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label>Telefono Celular Empresa</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtTelefonoCelularEmpresa" MaxLength="40" onkeypress="return caracteresTelefono(event)"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label>Representante Legal</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtRepesentanteLegal" MaxLength="40" onkeypress="return caracteresTextos(event)"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label>Telefono Celular Rep. Legal</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtTelefonoCelularRepresentanteLegal" MaxLength="40" onkeypress="return caracteresTelefono(event)"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label>Telefono Fijo Rep. Legal</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtTelefonoFijoRepresentanteLegal" MaxLength="40" onkeypress="return caracteresTelefono(event)"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label>Email Rep. Legal</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtEmailRepresentanteLegal" MaxLength="40" onkeypress="return caracteresTextos(event)"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label>Codigo Actividad</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtCodigoActividad" MaxLength="40" onkeypress="return caracteresTextos(event)"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label>Sitio Web</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtSitioWeb" MaxLength="40" onkeypress="return caracteresSitioWeb(event)"></asp:TextBox>
                            </div>
                        </div>
                        <br/>
                        <h4><b>Datos del Usuario</b> (Administrador)</h4>
                        <div class="row">
                            <div class="col-md-3">
                                <label>Email</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtEmail" MaxLength="20" onkeypress="return carateresEmail(event)"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label>Rut Usuario</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtRutUsuario" MaxLength="20" onkeypress="return caracteresRut(event)"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label>Password</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtPassword" MaxLength="20"></asp:TextBox>
                            </div>
                        </div>
                        <br/>
                        <h4><b>Datos del Contrato</b></h4>
                        <div class="row">
                            <div class="col-md-3">
                                <label>Duración del Contrato</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtDuracionContrato" MaxLength="5" onkeypress="return solonumeros(event)"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label>Fecha Inicial</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtFechaInicial" MaxLength="12" onkeypress="return caracteresFecha(event)"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label>Fecha Termino</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtFechaTermino" MaxLength="12" onkeypress="return caracteresFecha(event)"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-3">
                                <label>Cantidad de Trabajadores</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtCantidadTrabajadores" MaxLength="5" onkeypress="return solonumeros(event)"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label>Cantidad Usuarios</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtCantidadUsuarios" MaxLength="12" onkeypress="return solonumeros(event)"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label>Mensualidad</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtMensualidad" MaxLength="12" onkeypress="return solonumeros(event)"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label>Estado</label>
                                <asp:DropDownList runat="server" id="ddlEstado" CssClass="form-control">
                                    <asp:ListItem Value="1">Activado</asp:ListItem>
                                    <asp:ListItem Value="0">Desactivado</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <br/> 
                        <div class="row">
                            <div class="col-md-3">
                                <asp:Button runat="server" CssClass="btn btn-black md-close" id="btnGuardarContrato" Text="Guardar" OnClick="btnGuardarContrato_Click"></asp:Button>
                            </div>
                            <div class="col-md-3">
                                <asp:Button runat="server" CssClass="btn btn-space" Style="background-color: red; color:white;" id="btnVolver" Text="Volver" OnClick="btnVolver_Click"></asp:Button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </asp:Content>