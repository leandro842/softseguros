<%@ Page Title="Exibe" Language="C#" MasterPageFile="~/FormularioPrincipal.Master" AutoEventWireup="true" CodeBehind="ExibeCotacao.aspx.cs" Inherits="SoftSeguros.ExibeCotacao" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
   
<asp:Content ID="Content4" ContentPlaceHolderID="cphcphCorpoPrincipal" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

     <table width="1200">
                <tr>
                    <td colspan="2" height="100" class="classTextoContato" align="center" valign="middle">
                        Dados da Sua Cotação!
                    </td>
                </tr>
                <tr>
                    <td class="classInfoContato">
                        Nome:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblNome" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classInfoContato">
                        Email:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblEmail" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classInfoContato">
                        Telefone:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblFone" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classInfoContato">
                        Celular:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblCel" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classInfoContato">
                        Sexo:
                    </td>
                    <td class="classInfoContato">

                        <asp:Label ID="lblSexo" runat="server"></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Data de Nascimento:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblDataNascimento" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Estado civil:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblEstadoCivil" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Escolaridade:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblEscolaridade" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Profissão:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblProfissao" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Nome do Banco:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblNomeBanco" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Estudante:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblEstudante" runat="server"></asp:Label>
                        <br />
                        <asp:Label ID="lblEstudantePeriodo" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        CEP do Endereço:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblCepEndereco" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Logradouro:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblLogradouro" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Bairro:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblBairro" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Localidade:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblLocalidade" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        UF:
                    </td>
                    <td class="classInfoContato">  
                        <asp:Label ID="lblUf" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        CPF Segurado:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblCpfSegurado" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        CNH Segurado:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblCnhSegurado" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        CPF Condutor 1:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblCpfCond1" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        CNH Condutor 1:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblCnhCond1" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Parentesco do Condutor com o Segurado:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblParentescoCondutor" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Marca do Veiculo:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblMarcaVeiculo" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Modelo do Veiculo:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblModeloVeiculo" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Ano de Fabricaçao:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblAnoFabricacao" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Ano do Modelo:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblAnoModelo" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Carro Zero:
                    </td>
                    <td class="classInfoContato">

                        <asp:Label ID="lblCarroZero" runat="server"></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Combustivel:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblCombustivel" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Chassi:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblChassi" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Placa:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblPlaca" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Possui dispositivo anti furto:
                    </td>
                    <td class="classInfoContato">

                        <asp:Label ID="lblDispAntFurto" runat="server"></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Possui Kit Gas:
                    </td>
                    <td class="classInfoContato">

                        <asp:Label ID="lblKitGas" runat="server"></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Possui Blindagem:
                    </td>
                    <td class="classInfoContato">

                        <asp:Label ID="lblBlindagem" runat="server"></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        CEP pernoite:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblCepPernoite" runat="server"></asp:Label>
                    </td>
                </tr>
               
                <tr>
                    <td class="classLabelInfoContato">
                        Veiculo Utilizado para trabalho:
                    </td>
                    <td class="classInfoContato">

                        <asp:Label ID="lblUsoTrabalho" runat="server"></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Possui estacionamento fechado no trabalho:
                    </td>
                    <td class="classInfoContato">
                                            
                        <asp:Label ID="lblEstacionamentoTrab" runat="server"></asp:Label>
                                            
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Possui garagem fechada em casa:
                    </td>
                    <td class="classInfoContato">
                                           
                        <asp:Label ID="lblGaragemCasa" runat="server"></asp:Label>
                                           
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Portao manual:
                    </td>
                    <td class="classInfoContato">
                        <asp:Label ID="lblPortao" runat="server"></asp:Label>       
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Veiculo uso comercial:
                    </td>
                    <td class="classInfoContato">
                                          
                        <asp:Label ID="lblUsoComercial" runat="server"></asp:Label>
                                          
                    </td>
                </tr>
                <tr>
                    <td colspan="2" height="50" class="classBtn" align="center" valign="middle">
                        <a href ="Default.aspx">Página Inicial  </a>
                    </td>
                </tr>
            </table>
</asp:Content>

