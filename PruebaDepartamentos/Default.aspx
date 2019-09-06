<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PruebaDepartamentos._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row mt-4">

            <%--Taps Barrra--%>
            <div class="col-3">
                <div class="list-group" id="list-tab" role="tablist">
                    <a class="list-group-item list-group-item-action active show" data-toggle="tab" href="#listDepartamentos" role="tab" aria-controls="list-home" aria-selected="false">Departamentos</a>
                    <a class="list-group-item list-group-item-action" data-toggle="tab" href="#listCiudad" role="tab" aria-controls="list-Nutricion" aria-selected="false">Ciudad</a>
                    <a class="list-group-item list-group-item-action" data-toggle="tab" href="#listRelacion" role="tab" aria-controls="list-Parenteral" aria-selected="false">Relacion Departamento ciudad</a>
                </div>
            </div>
            <%--Taps Cuerpo--%>
            <div class="col-9">
                <div class="tab-content" id="nav-tabContent">
                    <div class="tab-pane fade active show" id="listDepartamentos" role="tabpanel" aria-labelledby="list-home-list">
                        <div class="row">
                            <div class="col-lg-6 col-md-6 col-xs-12">
                                <label for="TxtDepartamento">Ingrese Departamento:</label>
                                <input type="text" class="form-control" id="TxtDepartamento" >
                            </div>
                            <div class="col-lg-6 col-md-6 col-xs-12 align-bottom">
                                <button type="button" onclick="LlenarDatasetDep()" class="btn btn-primary">Guardar</button>
                            </div>
                        </div>
                        <div class="row mt-4" id="Pintar grilla">
                            <table class="table" id="TblDepartamentos">
                                <thead class="thead-dark">
                                    <tr>
                                        <th scope="col">#</th>
                                        <th scope="col">Departamento</th>
                                        <th scope="col">Actualizar</th>
                                        <th scope="col">Borrar</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <th scope="row">1</th>
                                        <td>ServiceReference1</td>
                                        <td>Otto</td>
                                        <td>@mdo</td>
                                    </tr>
                                    <tr>
                                        <th scope="row">2</th>
                                        <td>Jacob</td>
                                        <td>Thornton</td>
                                        <td>@fat</td>
                                    </tr>
                                    <tr>
                                        <th scope="row">3</th>
                                        <td>Larry</td>
                                        <td>the Bird</td>
                                        <td>@twitter</td>
                                    </tr>
                                </tbody>
                            </table>

                        </div>
                    </div>
                    <div class="tab-pane fade" id="listCiudad" role="tabpanel" aria-labelledby="list-profile-list">
                    </div>
                    <div class="tab-pane fade" id="listRelacion" role="tabpanel" aria-labelledby="list-messages-list">
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
