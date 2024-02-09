<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminaT.aspx.cs" Inherits="GestAlunos.EliminaT" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2>Eliminar Turmas</h2>
        <br /><br />     
        <asp:Label ID="lbl_numero" runat="server" Text="ID:   "></asp:Label>&nbsp;
        <asp:TextBox ID="txt_id" ReadOnly="true" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="lbl_nome" runat="server" Text="Turma:   "></asp:Label>&nbsp;
        <asp:TextBox ID="txt_turma" ReadOnly="true" runat="server"></asp:TextBox>
        <asp:Button ID="b_eliminar" runat="server" Text="Eliminar" OnClick="b_eliminar_Click" />    
       
    </main>
</asp:Content>