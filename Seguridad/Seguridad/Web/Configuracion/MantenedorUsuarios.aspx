<%@ Page Title="" Language="C#" enableEventValidation="false" MasterPageFile="../Control/MasterPage.master" AutoEventWireup="true" CodeBehind="MantenedorUsuarios.aspx.cs" Inherits="Seguridad.Web.Configuracion.MantenedorUsuarios" %>
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
        </style>

        <script type="text/javascript">
            function openModalUsuario() {
                $('#modal-new-user').modal('show');
            }

        </script>
    </asp:Content>
    <asp:Content id="Content2" ContentPlaceHolderID="contentPlaceHolder1" runat="server">
        <div class="row" style="margin-top:-20px !important">
            <div class="panel panel-default">
                <div class="tab-container">
                    <ul class="nav nav-tabs">
                        <li class="active">
                            <a href="#listarUsuarios" data-toggle="tab" aria-expanded="false">Usuarios</a>
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
                                        <asp:TextBox runat="server" CssClass="form-control" id="txtFiltroUsername" onkeypress="return caracteresTextos(event)"></asp:TextBox>
                                    </td>
                                    <td></td>
                                    <td>
                                        <asp:TextBox runat="server" CssClass="form-control" id="txtFiltroRut" onkeypress="return caracteresRut(event)"></asp:TextBox>
                                    </td>
                                    <td></td>
                                    <td>
                                        <asp:TextBox runat="server" CssClass="form-control" id="txtFiltroNombre" onkeypress="return caracteresTextos(event)"></asp:TextBox>
                                    </td>
                                    <td></td>
                                    <td>
                                        <asp:TextBox runat="server" CssClass="form-control" id="txtFiltroApellido" onkeypress="return caracteresTextos(event)"></asp:TextBox>
                                    </td>
                                    <td></td>
                                    <td style="width:200px;">
                                        <asp:DropDownList runat="server" id="ddlFiltroEstado" CssClass="form-control">
                                            <asp:ListItem Value="-1">--Seleccione--</asp:ListItem>
                                            <asp:ListItem Value="1">Activado</asp:ListItem>
                                            <asp:ListItem Value="0">Desactivado</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td></td>
                                    <td>
                                        <asp:Button runat="server" CssClass="btn btn-space" Text="Buscar" Style="background-color: black !important; color:white;"
                                            id="btnBuscar" OnClick="btnBuscar_Click"></asp:Button>
                                    </td>
                                    <td></td>
                                    <td>
                                        <asp:Button runat="server" CssClass="btn btn-space" Text="Limpiar" id="btnLimpiar" Style="background-color: red !important; color:white;"
                                            OnClick="btnLimpiar_Click"></asp:Button>
                                    </td>
                                </tr>
                            </table>
                            <br/>
                            <asp:GridView runat="server" id="gvTablaUsuarios" CssClass="tablesDM" AutoGenerateColumns="false"
                                OnRowCommand="gvTablaUsuarios_RowCommand" EmptyDataText="Sin Resultados" PageSize="15">
                                <Columns>
                                    <asp:TemplateField HeaderText="ID" Visible="true">
                                        <ItemTemplate>
                                            <asp:Label runat="server" Text='<%# Eval("id_usuario") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Usuario" Visible="true">
                                        <ItemTemplate>
                                            <asp:Label runat="server" Text='<%# Eval("usuario").ToString() %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="nombre" Visible="true">
                                        <ItemTemplate>
                                            <asp:Label runat="server" Text='<%# Eval("nombres").ToString() + " " + Eval("apellido_pat").ToString() + " " + Eval("apellido_mat").ToString() %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Estado" Visible="true">
                                        <ItemTemplate>
                                            <asp:Label runat="server" Text='<%# Eval("estado").ToString() == "1" ? "Activo" : "Inactivo"  %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField Visible="true">
                                        <ItemTemplate>
                                            <p data-toggle="modal" data-target="#modal-new-user">
                                                <asp:Button runat="server" Text="Editar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" CssClass="btn btn-danger md-close"
                                                    CommandName="Actualizar" ID="btnEditarUsuario" />
                                            </p>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            <HeaderStyle cssclass="headerDM"/>
                            </asp:GridView>
                            <br/>
                            <asp:Button runat="server" CssClass="btn btn-space" Style="background-color: black; color:white;" id="btnNuevoUsuario" Text="Crear Usuario"
                                OnClick="btnNuevoUsuario_Click"></asp:Button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <asp:UpdatePanel runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <div id="modal-new-user" tabindex="-1" role="dialog" class="modal fade colored-header colored-header-primary">
                    <div class="modal-dialog custom-width">
                        <div class="modal-content">
                            <div class="modal-header" style="background-color: black;">
                                <button type="button" data-dismiss="modal" aria-hidden="true" class="close md-close">
                                    <span class="mdi mdi-close"></span>
                                </button>
                                <h3 class="modal-title" style="background-color: black;">Usuario</h3>
                            </div>
                            <div class="modal-body">
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label>Id Usuario</label>
                                        <asp:TextBox runat="server" CssClass="form-control" id="txtIdUsuario" Enabled="false" TabIndex="1"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label>Password</label>
                                        <asp:TextBox runat="server" CssClass="form-control" id="txtPassword" TextMode="Password" MaxLength="40" TabIndex="3"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label>Rut</label>
                                        <asp:TextBox runat="server" CssClass="form-control" id="txtRut" MaxLength="40" onkeypress="return caracteresRut(event)" TabIndex="5"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label>Apellido Paterno</label>
                                        <asp:TextBox runat="server" CssClass="form-control" id="txtApellidoPaterno" MaxLength="40" onkeypress="return caracteresTextos(event)"
                                            TabIndex="7"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label>Email</label>
                                        <asp:TextBox runat="server" CssClass="form-control" id="txtEmail" MaxLength="40" onkeypress="return caracteresEmail(event)"
                                            TabIndex="9"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label>Fono Celular</label>
                                        <asp:TextBox runat="server" CssClass="form-control" id="txtFonoCelular" MaxLength="40" onkeypress="return caracteresTelefono(event)"
                                            TabIndex="11"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label>Nombre de Usuario</label>
                                        <asp:TextBox runat="server" CssClass="form-control" id="txtUsername" MaxLength="40" onkeypress="return caracteresTextos(event)"
                                            TabIndex="2"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label>Repetir Password</label>
                                        <asp:TextBox runat="server" CssClass="form-control" id="txtRepetirPassword" TextMode="Password" MaxLength="40" TabIndex="4"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label>Nombres</label>
                                        <asp:TextBox runat="server" CssClass="form-control" id="txtNombres" MaxLength="40" onkeypress="return caracteresTextos(event)"
                                            TabIndex="6"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label>Apellido Materno</label>
                                        <asp:TextBox runat="server" CssClass="form-control" id="txtApellidoMaterno" MaxLength="40" onkeypress="return caracteresTextos(event)"
                                            TabIndex="8"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label>Estado</label>
                                        <asp:DropDownList runat="server" id="ddlEstadoUsuario" CssClass="form-control" TabIndex="10">
                                            <asp:ListItem Value="1">Activado</asp:ListItem>
                                            <asp:ListItem Value="0">Desactivado</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="form-group">
                                    </div>
                                </div>
                            </div>
                            <div class="modal-footer">
                                <button type="button" data-dismiss="modal" class="btn btn-danger md-close">Cancelar</button>
                                <asp:Button runat="server" CssClass="btn btn-black md-close" id="btnGuardarUsuario" Text="Guardar" OnClick="btnGuardarUsuario_Click"></asp:Button>
                            </div>
                        </div>
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </asp:Content>