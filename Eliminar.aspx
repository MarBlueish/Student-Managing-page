<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="GestAlunos.Eliminar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2>Eliminar</h2>
        <br />
        <asp:label ID="lbl_nome" runat="server" Text="Nome:   "></asp:label>&nbsp;
        <asp:TextBox ID="txt_nome" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_email" runat="server" Text="E-mail:  "></asp:Label>&nbsp;
        <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_data_nasc" runat="server" Text="Data de Nascimento: "></asp:Label>&nbsp;
        <asp:TextBox ID="txt_data_nasc" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_morada" runat="server" Text="Morada:     "></asp:Label>&nbsp;
        <asp:TextBox ID="txt_morada" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_genero" runat="server" Text="Género:    "></asp:Label>&nbsp;
        <asp:DropDownList ID="dd_genero" runat="server"></asp:DropDownList>
        <br />
        <asp:Label ID="Lab" runat="server" Text="Turma:    "></asp:Label>&nbsp;
        <asp:DropDownList ID="dd_turma" runat="server"></asp:DropDownList>
        <br />
        <asp:Label ID="lab_numero" runat="server" Text="Número:    "></asp:Label>&nbsp;
        <asp:TextBox ID="txt_numero" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="b_eliminar" runat="server" Text="Eliminar" OnClick="b_eliminar_Click" />
    </main>
</asp:Content>