<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Turmas.aspx.cs" Inherits="GestAlunos.Turmas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2>Gerir Turmas</h2>
        <br /><br />     
        <%Obter_dados() ;%>
        <br /><br />
        <h3>Adicionar Turmas</h3>
        <asp:Label ID="lbl_turma" runat="server" Text="Turma:   "></asp:Label>&nbsp;
        <asp:TextBox ID="txt_turma" runat="server"></asp:TextBox>&nbsp;
        <br /><br />
        <asp:Button ID="b_inserir" runat="server" Text="Inserir" OnClick="b_inserir_Click" />

    </main>
</asp:Content>