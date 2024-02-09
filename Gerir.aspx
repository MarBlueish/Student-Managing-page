<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Gerir.aspx.cs" Inherits="GestAlunos.Gerir" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2>Gerir Alunos</h2>
        <br /><br />
        <%Obter_dados();%>

        
    </main>
</asp:Content>
