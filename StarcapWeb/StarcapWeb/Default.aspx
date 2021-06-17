<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StarcapWeb.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <style>
        #Contenido_TipoRdl label{
            margin-left: 10px;
        }
    </style>
    <div class="row mt-5">
        <div class="col-12 col-md-6 col-lg-5 mx-auto">
            <div class="card">
                <div class="card-header bg-success text-white text-center">
                    <h5>Registrar Cliente</h5>
                </div>
                <div class="card-body">
                    <div class="mb-3">
                        <label class="form-label" for="NombreTxt">Nombre</label>
                        <asp:TextBox runat="server" ID="NombreTxt" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="NombreTxtVal" runat="server" CssClass="text-danger" ErrorMessage="Debe Ingresar el nombre" ControlToValidate="NombreTxt"></asp:RequiredFieldValidator>

                    </div>
                    <div class="mb-3">
                        <label class="form-label" for="RutTxt">Rut</label>
                        <asp:TextBox runat="server" ID="RutTxt" CssClass="form-control"></asp:TextBox>
                        <asp:CustomValidator ID="RutVal" runat="server" ErrorMessage="CustomValidator"
                            CssClass="text-danger" ControlToValidate="RutTxt" OnServerValidate="RutVal_ServerValidate"></asp:CustomValidator>
                    </div>
                    <div class="mb-3">
                        <label class="form-label" for="CafeDdl">Café favorito</label>
                        <asp:DropDownList runat="server" ID="CafeDdl" CssClass="form-select">
                        </asp:DropDownList>
                    </div>
                    <div class="mb-3">
                        <label class="form-label" for="TipoRdl">Tipo de Cliente</label>
                        <asp:RadioButtonList runat="server" ID="TipoRdl">
                            <asp:ListItem Text="Silver" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Gold" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Platinum" Value="3"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                </div>
                <div class="card-footer d-grid gap-1">
                    <asp:Button runat="server" ID="GuardarBtn" CssClass="btn btn-dark" Text="Registrar"/>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
