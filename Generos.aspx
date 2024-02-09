<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Generos.aspx.cs" Inherits="GestAlunos.Generos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2>Gerir Generos</h2>
        <br /><br />  
        <% Obter_dados(); %>
        <br /><br />
        <h3>Adicionar Géneros</h3>
        <asp:Label ID="lbl_genero" runat="server" Text="Turma:   "></asp:Label>&nbsp;
        <asp:TextBox ID="txt_genero" runat="server"></asp:TextBox>
        <br /><br />
        
        <asp:Button ID="b_inserir" runat="server" Text="Inserir" OnClick="b_inserir_Click" />

       
    </main>
</asp:Content>