<%@ Page Title="" Language="C#" enableEventValidation="false" MasterPageFile="../Control/MasterPage.master" AutoEventWireup="true" CodeBehind="MantenedorEmpresas.aspx.cs" Inherits="Seguridad.Web.Configuracion.MantenedorEmpresas" %>
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
        <div class="row" style="margin-top:-20px !important">
            <div class="panel panel-default">
                <div class="tab-container">
                    <ul class="nav nav-tabs">
                        <li class="active">
                            <a href="#listarEmpresas" data-toggle="tab" aria-expanded="false">Empresas</a>
                        </li>
                    </ul>
                    <div class="tab-content">
                        <div id="listarEmpresas" class="tab-pane active cont">
                            <table>
                                <tr>
                                    <th>Nombre Empresa</th>
                                    <th style="width: 10px"></th>
                                    <th>Rut Empresa</th>
                                    <th style="width: 10px"></th>
                                    <th>Estado</th>
                                    <th style="width: 10px"></th>
                                    <th></th>
                                    <th style="width: 10px"></th>
                                    <th></th>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox runat="server" CssClass="form-control" id="txtFiltroNombreEmpresa" onkeypress="return caracteresTextos(event)"></asp:TextBox>
                                    </td>
                                    <td></td>
                                    <td>
                                        <asp:TextBox runat="server" CssClass="form-control" id="txtFiltroRutEmpresa" onkeypress="return caracteresRut(event)"></asp:TextBox>
                                    </td>
                                    <td></td>
                                    <td style="width:200px;">
                                        <asp:DropDownList runat="server" id="ddlFiltroEstadoEmpresa" CssClass="form-control">
                                            <asp:ListItem Value="-1">--Seleccione--</asp:ListItem>
                                            <asp:ListItem Value="1">Activado</asp:ListItem>
                                            <asp:ListItem Value="0">Desactivado</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td></td>
                                    <td>
                                        <asp:Button runat="server" CssClass="btn btn-space" Text="Buscar" Style="background-color: black !important; color:white;"
                                            id="btnBuscarEmpresa" OnClick="btnBuscarEmpresa_Click"></asp:Button>
                                    </td>
                                    <td></td>
                                    <td>
                                        <asp:Button runat="server" CssClass="btn btn-space" Text="Limpiar" id="btnLimpiarFiltroEmpresa" Style="background-color: red !important; color:white;"
                                            OnClick="btnLimpiarFiltroEmpresas_Click"></asp:Button>
                                    </td>
                                </tr>
                            </table>
                            <br/>
                            <asp:GridView runat="server" id="gvTablaEmpresa" CssClass="table table-condensed table-striped" AutoGenerateColumns="false" OnRowCommand="gvTablaEmpresas_RowCommand">
                                <Columns>
                                    <asp:TemplateField HeaderText="ID" Visible="true">
                                        <ItemTemplate>
                                            <asp:Label runat="server" Text='<%# Eval("id_empresa") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Rut" Visible="true">
                                        <ItemTemplate>
                                            <asp:Label runat="server" Text='<%# Eval("rut_empresa") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="nombre" Visible="true">
                                        <ItemTemplate>
                                            <asp:Label runat="server" Text='<%# Eval("nombre_fantasia") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Estado" Visible="true">
                                        <ItemTemplate>
                                            <asp:Label runat="server" Text='<%# Eval("estado") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField Visible="true">
                                        <ItemTemplate>
                                        <p data-toggle="modal" data-target="#modal-new-company">
                                             <asp:Button runat="server" Text="Editar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" CssClass="btn btn-danger md-close" CommandName="Actualizar" ID="btnEditarEmpresa" /></p>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                            <asp:Button runat="server" CssClass="btn btn-space" Style="background-color: black; color:white;" id="btnNuevaEmpresa" Text="Crear Empresa" OnClick="btnNuevaEmpresa_Click"></asp:Button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server" />
    <asp:UpdatePanel runat="server" UpdateMode="Conditional">
        <ContentTemplate>
        <div id="modal-new-company" tabindex="-1" role="dialog" class="modal fade colored-header colored-header-primary">
            <div class="modal-dialog custom-width">
                <div class="modal-content">
                    <div class="modal-header" style="background-color: black;">
                        <button type="button" data-dismiss="modal" aria-hidden="true" class="close md-close">
                            <span class="mdi mdi-close"></span>
                        </button>
                        <h3 class="modal-title" style="background-color: black;">Empresa</h3>
                    </div>
                    <div class="modal-body">
                        <div class="col-md-6">
                            <div class="form-group">
                                <label>Id Empresa</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtIdEmpresa" Enabled="false" TabIndex="1"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Razon Social</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtRazonSocial" MaxLength="40" onkeypress="return caracteresTextos(event)" TabIndex="3"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Dirección</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtDireccion" MaxLength="40" TabIndex="5"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Comuna</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtComuna" MaxLength="40" onkeypress="return caracteresTextos(event)" TabIndex="7"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Telefono Fijo Empresa</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtTelefonoFijoEmpresa" MaxLength="40" onkeypress="return caracteresTelefono(event)" TabIndex="9"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Email Empresa</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtEmailEmpresa" MaxLength="40" onkeypress="return caracteresEmail(event)" TabIndex="11"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Representante Legal</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtRepesentanteLegal" MaxLength="40" onkeypress="return caracteresTextos(event)" TabIndex="13"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Telefono Celular Rep. Legal</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtTelefonoCelularRepresentanteLegal" MaxLength="40" onkeypress="return caracteresTelefono(event)" TabIndex="15"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Codigo Actividad</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtCodigoActividad" MaxLength="40" TabIndex="17"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Estado</label>
                                <asp:DropDownList runat="server" id="ddlEstadoEmpresa" CssClass="form-control" TabIndex="19">
                                    <asp:ListItem Value="1">Activado</asp:ListItem>
                                    <asp:ListItem Value="0">Desactivado</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <label>Rut Empresa</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtRutEmpresa" MaxLength="40" onkeypress="return caracteresRut(event)" TabIndex="2"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Nombre Fantasia</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtNombreFantasia" MaxLength="40" onkeypress="return caracteresTextos(event)" TabIndex="4"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Ciudad</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtCiudad" MaxLength="40" onkeypress="return caracteresTextos(event)" TabIndex="6"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Region</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtRegion" MaxLength="40" onkeypress="return caracteresTextos(event)" TabIndex="8"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Telefono Celular Empresa</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtTelefonoCelularEmpresa" MaxLength="40" onkeypress="return caracteresTelefono(event)" TabIndex="10"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Sitio Web</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtSitioWeb" MaxLength="40" onkeypress="return caracteresSitioWeb(event)" TabIndex="11"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Telefono Fijo Rep. Legal</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtTelefonoFijoRepresentanteLegal" MaxLength="40" onkeypress="return caracteresTelefono(event)" TabIndex="14"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Email Rep. Legal</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtEmailRepresentanteLegal" MaxLength="40" onkeypress="return caracteresTextos(event)" TabIndex="16"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Logo</label>
                                <asp:TextBox runat="server" CssClass="form-control" id="txtLogo" MaxLength="40" TabIndex="18"></asp:TextBox>
                            </div>
                            <div class="form-group">
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" data-dismiss="modal" class="btn btn-danger md-close">Cancelar</button>
                        <asp:Button runat="server" CssClass="btn btn-black md-close" id="btnGuardarEmpresa" Text="Guardar" OnClick="btnGuardarEmpresa_Click"></asp:Button>
                    </div>
                </div>
            </div>
        </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </asp:Content>