<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Phone.aspx.cs" Inherits="DatatableDemo.WebFormUI.Phone" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="Content/DataTables/css/dataTables.bootstrap4.min.css" rel="stylesheet" />
    <link href="Content/DataTables/css/jquery.dataTables.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" style="margin-top:20px">
        <table class="table table-striped table-bordered table-hover"
            id="phoneTable" width="100%">
            <thead>
                <tr>
                    <th>Adı</th>
                    <th>Soyadı</th>
                    <th>Mesaj</th>
                    <th>Telefon</th>
                    <th>Oluşturma Tarihi</th>
                    <th>Oluşturan Kullanıcı</th>
                </tr>
            </thead>
        </table>
    </div>
</asp:Content>
<asp:Content ContentPlaceHolderID="FooterContent" runat="server">
    <script src="Scripts/DataTables/jquery.dataTables.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.26.0/moment.min.js"></script>
    <script src="https://cdn.datatables.net/plug-ins/1.10.21/dataRender/datetime.js"></script>
    <script type="text/javascript" src="Scripts/pages/phone.js"></script>
</asp:Content>
