<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Listagem.aspx.cs" Inherits="GestAlunos.Listagem" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2>Listagem de Alunos</h2>
        <%Lista_dados();%>
    </main>
</asp:Content>
