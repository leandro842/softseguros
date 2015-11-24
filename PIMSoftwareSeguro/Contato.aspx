<%@ Page Title="" Language="C#" MasterPageFile="~/FormularioPrincipal.Master" AutoEventWireup="true" CodeBehind="Contato.aspx.cs" Inherits="SoftSeguros.Contato" %>
<asp:Content ID="Content4" ContentPlaceHolderID="cphcphCorpoPrincipal" runat="server">
    <form name="frmContato" method="post" action="Contato.aspx">
        <table width="1200">
            <tr>
                <td colspan="2" height="100" class="classTextoContato" align="center" valign="middle">
                    Entre em contato com a gente!Um de nossos consultores poderá te ajudar!
                </td>
            </tr>
            <tr>
                <td class="classLabelInfoContato">
                    Nome:
                </td>
                <td class="classInfoContato">
                    <input type="text" name="txtNome" value="" size="130" />
                </td>
            </tr>
            <tr>
                <td class="classLabelInfoContato">
                    Email:
                </td>
                <td class="classInfoContato">
                    <input type="text" name="txEmail" value="" size="130" />
                </td>
            </tr>
            <tr>
                <td class="classLabelInfoContato">
                    Telefone:
                </td>
                <td class="classInfoContato">
                    <input type="text" name="txtTelefone" value="" size="130" />
                </td>
            </tr>
            <tr>
                <td class="classLabelInfoContato">
                    Preferencia de contato:
                </td>
                <td class="classInfoContato">
                    <select name="cboMeioContato">
                        <option value="" selected>Escolha a preferencia do meio de contato</option>
                        <option value="T">Telefone</option>
                        <option value="E">Email</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td colspan="2" height="50" class="classBtn" align="center" valign="middle">
                    <input type="button" name="btnEnviar" value="Enviar" onclick="fnValidarDados()" />
                    &nbsp;
                    <input type="button" name="btnLimpar" value="Limpar" onclick="fnLimparDados()" />
                </td>
            </tr>
        </table>
    </form>
</asp:Content>
