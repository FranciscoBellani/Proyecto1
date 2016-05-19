<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inscripcion.aspx.cs" Inherits="ProgramacionWeb.Inscripcion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Formulario de Inscripcion</h2>
    <div class="row">
        <div class="col-xs-3">
            <asp:TextBox runat="server" CssClass="form-control" placeholder="Ingrese su Nombre y Apellido" ID="txtnombre"></asp:TextBox>
        </div>
        <div class="col-xs-4">
            <asp:TextBox runat="server" class="form-control" placeholder="Ingrese Edad" ID="txtedad"></asp:TextBox>
        </div>
        <div class="col-xs-5">
            <!-- DateTimePicker -->

            <div class="bootstrap-iso">
                <div class="container-fluid">
                    <div class="row">

                        <div class="input-group">
                            <div class="input-group-addon">
                                <i class="fa fa-calendar"></i>
                            </div>
                            <input class="form-control" id="Text1" name="date" placeholder="Fecha de Inscripcion" type="text" />
                        </div>
                    </div>
                    <br />
                </div>
            </div>
        </div>
        <!-- Codigo Datetimepicker -->
    </div>
    <br />
    <div class="row">
        <div class="col-xs-3">

            <asp:DropDownList ID="ddlCursos" runat="server" Height="30px" DataSourceID="SqlDataSource1">
            </asp:DropDownList>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RecuperatorioConnectionString %>" SelectCommand="SELECT [nombreCurso] FROM [Cursos]"></asp:SqlDataSource>

        </div>
    </div>

    <div class="btn-group">
        <asp:Button ID="btn2" runat="server" Text="Guardar" class="btn btn-default" CssClass="btn-danger active" OnClick="btn2_Click1"></asp:Button>
            </div>

    <div>
        <asp:GridView ID="gvAlumnos" runat="server" CssClass="table table-hover" BorderWidth="2px" BorderStyle="Solid" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="nombreAlumno" HeaderText="Nombre" />
                <asp:BoundField DataField="edad" HeaderText="Edad" />
                <asp:BoundField DataField="fechaInscripcion" HeaderText="Fecha de Inscripcion" />
                <asp:BoundField DataField="nombreCurso" HeaderText="Curso" />
            </Columns>
        </asp:GridView>
    </div>



</asp:Content>
