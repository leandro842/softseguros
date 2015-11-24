<%@ Page Title="" Language="C#" MasterPageFile="~/FormularioPrincipal.Master" AutoEventWireup="true" CodeBehind="Cotacao.aspx.cs" Inherits="SoftSeguros.Cotacao" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
   
<asp:Content ID="Content4" ContentPlaceHolderID="cphcphCorpoPrincipal" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <script type="text/javascript">
        function RedirectDecision() {
            confirm('Cotação Cadastrada com Sucesso!')
            window.location = "ExibeCotacao.aspx";
        }
    </script>

     <table width="1200">
                <tr>
                    <td colspan="2" height="100" class="classTextoContato" align="center" valign="middle">
                        Faça sua Cotação!
                    </td>
                </tr>
                <tr>
                    <td class="classInfoContato">
                        Nome:
                    </td>
                    <td class="classInfoContato">
                        <asp:TextBox ID="txtNome" runat="server" Width="450"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="classInfoContato">
                        Email:
                    </td>
                    <td class="classInfoContato">
                        <asp:TextBox ID="txEmail" runat="server" Width="450"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="classInfoContato">
                        Telefone:
                    </td>
                    <td class="classInfoContato">
                        <asp:TextBox ID="txtTelefone" runat="server" Width="450"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="classInfoContato">
                        Celular:
                    </td>
                    <td class="classInfoContato">
                        <asp:TextBox ID="txtCelular" runat="server" Width="450"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="classInfoContato">
                        Sexo:
                    </td>
                    <td class="classInfoContato">
                        <fieldset style="width:400px">
                            <legend>Sexo:</legend>
                            <asp:RadioButton ID="MaleRadioButton" Text="Masculino" runat="server" GroupName="SexoGrupo" />
                            <asp:RadioButton ID="FameleRadioButton" Text="Feminino" runat="server" GroupName="SexoGrupo" />
                        </fieldset>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Data de Nascimento (dd/MM/yyyy):
                    </td>
                    <td class="classInfoContato">
                        <asp:TextBox ID="txtDate" runat="server" Width="450"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Estado civil:
                    </td>
                    <td class="classInfoContato">
                        <ajaxToolkit:ComboBox ID="CombEstCivil" runat="server">
                            <asp:ListItem Selected ="True">Solteiro(a)</asp:ListItem>
                            <asp:ListItem>Casado(a)</asp:ListItem>
                            <asp:ListItem>Amaziado(a)</asp:ListItem>
                            <asp:ListItem>Divorciado(a)</asp:ListItem>
                            <asp:ListItem>Víuvo(a)</asp:ListItem>
                        </ajaxToolkit:ComboBox>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Escolaridade:
                    </td>
                    <td class="classInfoContato">
                        <ajaxToolkit:ComboBox ID="CombEscolaridade" runat="server" Width="250">
                            <asp:ListItem Selected ="True">Ensino Fundamental Completo</asp:ListItem>
                            <asp:ListItem>Ensino Fundamental Incompleto</asp:ListItem>
                            <asp:ListItem>Ensino Médio Completo</asp:ListItem>
                            <asp:ListItem>Ensino Médio Incompleto</asp:ListItem>
                            <asp:ListItem>Ensino Superior Completo</asp:ListItem>
                            <asp:ListItem>Ensino Superior Incompleto</asp:ListItem>
                        </ajaxToolkit:ComboBox>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Profissão:
                    </td>
                    <td class="classInfoContato">
                        <asp:TextBox ID="txtProfissao" runat="server" Width="450"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Nome do Banco:
                    </td>
                    <td class="classInfoContato">
                        <ajaxToolkit:ComboBox ID="CombBanco" runat="server" Width="250">
                            <asp:ListItem Selected ="True">Banco do Brasil</asp:ListItem>
                            <asp:ListItem>Bradesco</asp:ListItem>
                            <asp:ListItem>Itaú</asp:ListItem>
                            <asp:ListItem>Caixa</asp:ListItem>
                            <asp:ListItem>Santander</asp:ListItem>
                            <asp:ListItem>HSBC</asp:ListItem>
                        </ajaxToolkit:ComboBox>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Estudante:
                    </td>
                    <td class="classInfoContato">
                        <fieldset style="width:400px" name="cboEstudante">
                            <legend>Estudante:</legend>
                            <asp:RadioButton ID="SimEstudante" Text="Sim" runat="server" GroupName="EstudGrupo"  AutoPostBack="true"  OnCheckedChanged="Estudante_CheckedChanged"/>
                            <asp:RadioButton ID="NãoEstudante" Text="Não" runat="server" GroupName="EstudGrupo"  AutoPostBack="true" OnCheckedChanged="Estudante_CheckedChanged"/>  
                        </fieldset>
                        &nbsp
                        <fieldset  style ="width:400px" name="cboTurno">
                            <legend>Período:</legend>
                            <asp:RadioButton ID="DiurnoRadioButton" Text="Diurno" runat="server" GroupName="PeriGrupo" />
                            <asp:RadioButton ID="NoturnoRadioButton" Text="Noturno" runat="server" GroupName="PeriGrupo" />
                        </fieldset>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        CEP do Endereço:
                    </td>
                    <td class="classInfoContato">
                        <asp:TextBox ID="txtCEP" runat="server" Width="450"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Logradouro:
                    </td>
                    <td class="classInfoContato">
                        <asp:TextBox ID="txtLogradouro" runat="server" Width="450"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Bairro:
                    </td>
                    <td class="classInfoContato">
                        <asp:TextBox ID="txtBairro" runat="server" Width="450"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Localidade:
                    </td>
                    <td class="classInfoContato">
                        <asp:TextBox ID="txtLocalidade" runat="server" Width="450"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        UF:
                    </td>
                    <td class="classInfoContato">  
                        <ajaxToolkit:ComboBox ID="CombUf" runat="server" Width="30">
                            <asp:ListItem Selected ="True">AC</asp:ListItem>
                            <asp:ListItem>AL</asp:ListItem>
                            <asp:ListItem>AP</asp:ListItem>
                            <asp:ListItem>AM</asp:ListItem>
                            <asp:ListItem>BA</asp:ListItem>
                            <asp:ListItem>CE</asp:ListItem>
                            <asp:ListItem>DF</asp:ListItem>
                            <asp:ListItem>ES</asp:ListItem>
                            <asp:ListItem>GO</asp:ListItem>
                            <asp:ListItem>MA</asp:ListItem>
                            <asp:ListItem>MT</asp:ListItem>
                            <asp:ListItem>MS</asp:ListItem>
                            <asp:ListItem>MG</asp:ListItem>
                            <asp:ListItem>PA</asp:ListItem>
                            <asp:ListItem>PB</asp:ListItem>
                            <asp:ListItem>PR</asp:ListItem>
                            <asp:ListItem>PE</asp:ListItem>
                            <asp:ListItem>PI</asp:ListItem>
                            <asp:ListItem>RJ</asp:ListItem>
                            <asp:ListItem>RN</asp:ListItem>
                            <asp:ListItem>RS</asp:ListItem>
                            <asp:ListItem>RO</asp:ListItem>
                            <asp:ListItem>RR</asp:ListItem>
                            <asp:ListItem>SC</asp:ListItem>
                            <asp:ListItem>SP</asp:ListItem>
                            <asp:ListItem>SE</asp:ListItem>
                            <asp:ListItem>TO</asp:ListItem>
                        </ajaxToolkit:ComboBox>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        CPF Segurado:
                    </td>
                    <td class="classInfoContato">
                        <asp:TextBox ID="txtCPFSegurado" runat="server" Width="450"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        CNH Segurado:
                    </td>
                    <td class="classInfoContato">
                        <asp:TextBox ID="txtCNHSegurado" runat="server" Width="450"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        CPF Condutor 1:
                    </td>
                    <td class="classInfoContato">
                        <asp:TextBox ID="txtCPFCondutor_a" runat="server" Width="450"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        CNH Condutor 1:
                    </td>
                    <td class="classInfoContato">
                        <asp:TextBox ID="txtCNHCondutor_a" runat="server" Width="450"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Parentesco do Condutor com o Segurado:
                    </td>
                    <td class="classInfoContato">
                        <ajaxToolkit:ComboBox ID="CombParentesco" runat="server" Width="250">
                            <asp:ListItem Selected ="True">Cônjuge</asp:ListItem>
                            <asp:ListItem>Filho(a)</asp:ListItem>
                            <asp:ListItem>Cobertura Aberta</asp:ListItem>
                        </ajaxToolkit:ComboBox>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Marca do Veiculo:
                    </td>
                    <td class="classInfoContato">
                        <asp:TextBox ID="txtVeiculo" runat="server" Width="450"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Modelo do Veiculo:
                    </td>
                    <td class="classInfoContato">
                        <asp:TextBox ID="txtModelo" runat="server" Width="450"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Ano de Fabricaçao:
                    </td>
                    <td class="classInfoContato">
                        <asp:TextBox ID="txtAnofabricacao" runat="server" Width="450"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Ano do Modelo:
                    </td>
                    <td class="classInfoContato">
                        <asp:TextBox ID="txtAnoModelo" runat="server" Width="450"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Carro Zero?
                    </td>
                    <td class="classInfoContato">
                        <fieldset  style ="width:400px" name="cboTurno">
                            <legend>Carro Zero?:</legend>
                            <asp:RadioButton ID="SimZero" Text="Sim" runat="server" GroupName="ZeroGrupo" />
                            <asp:RadioButton ID="NaoZero" Text="Não" runat="server" GroupName="ZeroGrupo" />
                        </fieldset>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Combustivel:
                    </td>
                    <td class="classInfoContato">
                        <ajaxToolkit:ComboBox ID="CombCombustivel" runat="server" Width="250">
                            <asp:ListItem Selected ="True">Gasolina</asp:ListItem>
                            <asp:ListItem>Álcool</asp:ListItem>
                            <asp:ListItem>Gás</asp:ListItem>
                            <asp:ListItem>Diesel</asp:ListItem>
                        </ajaxToolkit:ComboBox>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Chassi:
                    </td>
                    <td class="classInfoContato">
                        <asp:TextBox ID="txtChassi" runat="server" Width="450"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Placa:
                    </td>
                    <td class="classInfoContato">
                        <asp:TextBox ID="txtPlaca" runat="server" Width="450"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Possui dispositivo anti furto?
                    </td>
                    <td class="classInfoContato">
                       <fieldset  style ="width:400px" name="cboTurno">
                            <legend>Possui dispositivo anti furto?</legend>
                            <asp:RadioButton ID="SimDispositivo" Text="Sim" runat="server" GroupName="DispGrupo" />
                            <asp:RadioButton ID="NaoDispositivo" Text="Não" runat="server" GroupName="DispGrupo" />
                        </fieldset>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Possui Kit Gas?
                    </td>
                    <td class="classInfoContato">
                        <fieldset  style ="width:400px" name="cboTurno">
                            <legend>Possui Kit Gas?</legend>
                            <asp:RadioButton ID="SimGas" Text="Sim" runat="server" GroupName="GasGrupo" />
                            <asp:RadioButton ID="NaoGas" Text="Não" runat="server" GroupName="GasGrupo" />
                        </fieldset>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Possui Blindagem?
                    </td>
                    <td class="classInfoContato">
                        <fieldset  style ="width:400px" name="cboTurno">
                            <legend>Possui Blindagem?</legend>
                            <asp:RadioButton ID="SimBlindagem" Text="Sim" runat="server" GroupName="BlinGrupo" />
                            <asp:RadioButton ID="NaoBlindagem" Text="Não" runat="server" GroupName="BlinGrupo" />
                        </fieldset>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Carro é utilizado para lazer?
                    </td>
                    <td class="classInfoContato">
                        <fieldset  style ="width:400px" name="cboTurno">
                            <legend>Carro é utilizado para lazer?</legend>
                            <asp:RadioButton ID="SimLazer" Text="Sim" runat="server" GroupName="LazerGrupo" />
                            <asp:RadioButton ID="NaoLazer" Text="Não" runat="server" GroupName="LazerGrupo" />
                        </fieldset>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        CEP pernoite:
                    </td>
                    <td class="classInfoContato">
                        <asp:TextBox ID="txtcepPernoite" runat="server" Width="450"></asp:TextBox>
                    </td>
                </tr>
               
                <tr>
                    <td class="classLabelInfoContato">
                        Veiculo Utilizado para trabalho?
                    </td>
                    <td class="classInfoContato">
                       <fieldset  style ="width:400px" name="cboTurno">
                            <legend>Veiculo Utilizado para trabalho?</legend>
                            <asp:RadioButton ID="SimTrab" Text="Sim" runat="server" GroupName="TrabGrupo" AutoPostBack="true" OnCheckedChanged="Trabalho_CheckedChanged"/>
                            <asp:RadioButton ID="NaoTrab" Text="Não" runat="server" GroupName="TrabGrupo" AutoPostBack="true" OnCheckedChanged="Trabalho_CheckedChanged"/>
                        </fieldset>
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Possui estacionamento fechado no trabalho?
                    </td>
                    <td class="classInfoContato">
                        <fieldset  style ="width:400px" name="cboTurno">
                            <legend>Possui estacionamento fechado no trabalho?</legend>
                            <asp:RadioButton ID="SimEstTrab" Text="Sim" runat="server" GroupName="EstTrabGrupo" />
                            <asp:RadioButton ID="NaoEstTrab" Text="Não" runat="server" GroupName="EstTrabGrupo" />
                        </fieldset>                    
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Possui garagem fechada em casa?
                    </td>
                    <td class="classInfoContato">
                        <fieldset  style ="width:400px" name="cboTurno">
                            <legend>Possui garagem fechada em casa?</legend>
                            <asp:RadioButton ID="SimGarFechaCasa" Text="Sim" runat="server" GroupName="GarFechaGrupo" />
                            <asp:RadioButton ID="NaoGarFechaCasa" Text="Não" runat="server" GroupName="GarFechaGrupo" />
                        </fieldset>                    
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Portao manual?
                    </td>
                    <td class="classInfoContato">
                        <fieldset  style ="width:400px" name="cboTurno">
                            <legend>Portao manual?</legend>
                            <asp:RadioButton ID="SimPortManual" Text="Sim" runat="server" GroupName="PortManualGrupo" />
                            <asp:RadioButton ID="NaoPortManual" Text="Não" runat="server" GroupName="PortManualGrupo" />
                        </fieldset>                    
                    </td>
                </tr>
                <tr>
                    <td class="classLabelInfoContato">
                        Veiculo uso comercial?
                    </td>
                    <td class="classInfoContato">
                        <fieldset  style ="width:400px" name="cboTurno">
                            <legend>Veiculo uso comercial?</legend>
                            <asp:RadioButton ID="SimUsoComercial" Text="Sim" runat="server" GroupName="UsoComerGrupo" />
                            <asp:RadioButton ID="NaoUsoComercial" Text="Não" runat="server" GroupName="UsoComerGrupo" />
                        </fieldset>                    
                    </td>
                </tr>
                <tr>
                    <td colspan="2" height="50" class="classBtn" align="center" valign="middle">
                        <asp:Button ID="btnEnviar" runat="server" Text="Enviar" onclick="btnEnviar_Click"/> 
                        &nbsp;
                        <input type="button" name="btnEnviar" value="Limpar" />
                    </td>
                </tr>
            </table>
</asp:Content>

