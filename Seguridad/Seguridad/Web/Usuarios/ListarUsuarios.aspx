﻿<%@ Page Title="" Language="C#" enableEventValidation="false" MasterPageFile="../Control/MasterPage.master" AutoEventWireup="true" CodeBehind="ListarUsuarios.aspx.cs" Inherits="Sistema.Web.Usuarios.ListarUsuarios" %>
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
        </style>
    </asp:Content>
    <asp:Content id="Content2" ContentPlaceHolderID="contentPlaceHolder1" runat="server">
        <div class="row" style="margin-top:-20px !important">
            <div class="panel panel-default">
                <div class="tab-container">
                    <ul class="nav nav-tabs">
                        <li class="active">
                            <a href="#listarUsuarios" data-toggle="tab" aria-expanded="false">Listar Usuarios</a>
                        </li>
                        <li>
                            <a href="#nuevoUsuario" data-toggle="tab" aria-expanded="false">Crear Usuario</a>
                        </li>
                    </ul>
                    <div class="tab-content">
                        <div id="listarUsuarios" class="tab-pane active cont">
                            <table>
                                <tr>
                                    <th>Username</th>
                                    <th style="width: 10px"></th>
                                    <th>Rut</th>
                                    <th style="width: 10px"></th>
                                    <th>Nombre</th>
                                    <th style="width: 10px"></th>
                                    <th>Apellido</th>
                                    <th style="width: 10px"></th>
                                    <th>Estado</th>
                                    <th style="width: 10px"></th>
                                    <th></th>
                                    <th style="width: 10px"></th>
                                    <th></th>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox runat="server" CssClass="form-control" id="txtFiltroUsername"></asp:TextBox>
                                    </td>
                                    <td></td>
                                    <td>
                                        <asp:TextBox runat="server" CssClass="form-control" id="txtFiltroRut"></asp:TextBox>
                                    </td>
                                    <td></td>
                                    <td>
                                        <asp:TextBox runat="server" CssClass="form-control" id="txtFiltroNombre"></asp:TextBox>
                                    </td>
                                    <td></td>
                                    <td>
                                        <asp:TextBox runat="server" CssClass="form-control" id="txtFiltroApellido"></asp:TextBox>
                                    </td>
                                    <td></td>
                                    <td>
                                        <asp:TextBox runat="server" CssClass="form-control"></asp:TextBox>
                                    </td>
                                    <td></td>
                                    <td>
                                        <asp:Button runat="server" CssClass="btn btn-space btn-primary" Text="Buscar"></asp:Button>
                                    </td>
                                    <td></td>
                                    <td>
                                        <asp:Button runat="server" CssClass="btn btn-space btn-default" Text="Limpiar" id="btnLimpiar" OnClick="btnLimpiar_Click"></asp:Button>
                                    </td>
                                </tr>
                            </table>
                            <br/>
                            <asp:GridView runat="server" id="gvTabla" CssClass="table table-condensed table-striped" AutoGenerateColumns="true">
                            </asp:GridView>
                            <button data-toggle="modal" data-target="#modal-new-user" type="button" class="btn btn-space btn-primary">Crear Usuario</button>
                        </div>
                        <div id="nuevoUsuario" class="tab-pane cont">
                            <div class="row">
                                <div class="col-md-3"></div>
                                <div class="col-md-6" style="background-color:#EEEEEE">
                                    <div class="panel-heading panel-heading-divider">Nuevo Usuario
                                        <span class="panel-subtitle">* Campos Obligatorios</span>
                                    </div>
                                    <div class="panel-body">
                                        <form>
                                            <table class="table">
                                                <tr>
                                                    <td>Nombres *</td>
                                                    <td>
                                                        <asp:TextBox runat="server" id="txtNombres" CssClass="form-control"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Apellido Paterno *</td>
                                                    <td>
                                                        <asp:TextBox runat="server" id="txtApellidoPaterno" CssClass="form-control"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Apellido Materno *</td>
                                                    <td>
                                                        <asp:TextBox runat="server" id="txtApellidoMaterno" CssClass="form-control"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Rut *</td>
                                                    <td>
                                                        <asp:TextBox runat="server" id="txtRut" CssClass="form-control"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Sexo *</td>
                                                    <td>
                                                        <asp:DropDownList runat="server" id="ddlSexo" CssClass="form-control">
                                                            <asp:ListItem Value="0">Seleccione</asp:ListItem>
                                                            <asp:ListItem Value="Femenino">Femenino</asp:ListItem>
                                                            <asp:ListItem Value="Masculino">Masculino</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Username *</td>
                                                    <td>
                                                        <asp:TextBox runat="server" id="txtUsername" CssClass="form-control"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Email</td>
                                                    <td>
                                                        <asp:TextBox runat="server" id="txtEmail" CssClass="form-control"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Telefono Fijo</td>
                                                    <td>
                                                        <asp:TextBox runat="server" id="txtTelefonoFijo" CssClass="form-control"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Telefono Movil</td>
                                                    <td>
                                                        <asp:TextBox runat="server" id="txtTelefonoMovil" CssClass="form-control"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Dirección</td>
                                                    <td>
                                                        <asp:TextBox runat="server" id="txtDireccion" CssClass="form-control"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td></td>
                                                    <td>
                                                        <asp:Button runat="server" id="btnGuardar" CssClass="btn btn-primary" Text="Guardar" OnClick="btnGuardar_Click"></asp:Button>
                                                    </td>
                                                </tr>
                                            </table>
                                        </form>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div id="modal-new-user" tabindex="-1" role="dialog" class="modal fade colored-header colored-header-primary">
            <div class="modal-dialog custom-width">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" data-dismiss="modal" aria-hidden="true" class="close md-close">
                            <span class="mdi mdi-close"></span>
                        </button>
                        <h3 class="modal-title">Crear Nuevo Usuario</h3>
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
                        <button type="button" data-dismiss="modal" class="btn btn-default md-close">Cancelar</button>
                        <button type="button" data-dismiss="modal" class="btn btn-primary md-close">Guardar</button>
                    </div>
                </div>
            </div>
        </div>
    </asp:Content>