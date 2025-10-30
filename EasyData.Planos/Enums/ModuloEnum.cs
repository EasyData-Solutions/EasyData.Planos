using EasyData.Planos.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyData.Planos.Enums
{
    public enum ModuloEnum
    {
        #region Lite

        [Modulo(PlanoEnum.Lite, "Configurações")]
        Configuracao = 100,

        [Modulo(PlanoEnum.Lite, "Clientes")]
        Clientes = 101,

        [Modulo(PlanoEnum.Lite, "Fornecedor")]
        Fornecedor = 102,

        [Modulo(PlanoEnum.Lite, "Usuarios")]
        Usuarios = 103,

        [Modulo(PlanoEnum.Lite, "Produtos")]
        Produtos = 104,

        [Modulo(PlanoEnum.Lite, "Tributação")]
        Tributacao = 105,

        [Modulo(PlanoEnum.Lite, "Contas Bancárias")]
        ContasBancarias = 106,

        [Modulo(PlanoEnum.Lite, "Cartões")]
        Cartoes = 107,

        [Modulo(PlanoEnum.Lite, "Favorecido")]
        Favorecido = 108,

        [Modulo(PlanoEnum.Lite, "Cadastro Observações")]
        CadastroObservacao = 109,

        [Modulo(PlanoEnum.Lite, "Nota Fiscal Entrada")]
        NotaFiscalEntrada = 110,

        [Modulo(PlanoEnum.Lite, "Vendas")]
        Vendas = 111,

        [Modulo(PlanoEnum.Lite, "Relatórios")]
        Relatorios = 112,

        [Modulo(PlanoEnum.Lite, "Estoque Movimentações")]
        EstoqueMovimentacao = 113,

        [Modulo(PlanoEnum.Lite, "Menu")]
        Menu = 114,

        #endregion

        #region Start

        [Modulo(PlanoEnum.Start, "Formação Preço")]
        FormacaoPreco = 200,

        [Modulo(PlanoEnum.Start, "Cadastros Financeiros")]
        CadastroFinanceiro = 201,

        [Modulo(PlanoEnum.Start, "Tipos Documentos")]
        TipoDocumento = 202,

        [Modulo(PlanoEnum.Start, "Status")]
        Status = 203,

        [Modulo(PlanoEnum.Start, "Financeiro")]
        Financeiro = 204,

        [Modulo(PlanoEnum.Start, "Contagem Estoque")]
        ContagemEstoque = 205,

        [Modulo(PlanoEnum.Start, "Contabilidade")]
        Contabilidade = 206,

        [Modulo(PlanoEnum.Start, "Cobrança CNAB")]
        CobrancaCNAB = 207,

        [Modulo(PlanoEnum.Start, "Graficos")]
        Grafico = 208,

        #endregion

        #region Gold

        [Modulo(PlanoEnum.Gold, "Temas")]
        Temas = 300,

        [Modulo(PlanoEnum.Gold, "Transportador")]
        Transportador = 301,

        [Modulo(PlanoEnum.Gold, "Locais Estoque")]
        LocaisEstoque = 302,

        [Modulo(PlanoEnum.Gold, "Condição de Pagamento")]
        CondicaoPagamento = 303,

        [Modulo(PlanoEnum.Gold, "Rotas")]
        Rotas = 304,

        [Modulo(PlanoEnum.Gold, "Campanhas")]
        Campanhas = 305,

        [Modulo(PlanoEnum.Gold, "OrdemFornecimento")]
        OrdemFornecimento = 306,

        [Modulo(PlanoEnum.Gold, "Pedido Administrativo")]
        PedidoAdministrativo = 307,

        [Modulo(PlanoEnum.Gold, "Conhecimento Frete")]
        ConhecimentoFrete = 308,

        [Modulo(PlanoEnum.Gold, "Romaneio")]
        Romaneio = 309,

        [Modulo(PlanoEnum.Gold, "Classificar Pedido")]
        ClassificarPedido = 310,

        [Modulo(PlanoEnum.Gold, "Carregamento")]
        Carregamento = 311,

        [Modulo(PlanoEnum.Gold, "Manifesto MDFe")]
        ManifestoMDFe = 312,

        [Modulo(PlanoEnum.Gold, "Entrega")]
        Entrega = 313,

        [Modulo(PlanoEnum.Gold, "SPED")]
        SPED = 314,

        [Modulo(PlanoEnum.Gold, "Veiculos")]
        Veiculos = 315,


        #endregion

        #region Premium

        [Modulo(PlanoEnum.Premium, "Ativos")]
        Ativos = 400,

        [Modulo(PlanoEnum.Premium, "Assistente Compras")]
        AssistenteCompras = 401,

        [Modulo(PlanoEnum.Premium, "Conciliação Bancaria")]
        ConciliacaoBancaria = 402,

        [Modulo(PlanoEnum.Premium, "Integração Filiais")]
        IntegracaoFiliais = 403,

        [Modulo(PlanoEnum.Premium, "Produção")]
        Producao = 404,

        [Modulo(PlanoEnum.Premium, "Lotes")]
        Lotes = 405,

        [Modulo(PlanoEnum.Premium, "Ajuste ICMS")]
        AjusteICMS = 406,

        #endregion

        #region Complementos

        [Modulo(PlanoEnum.Complementos, "CTe")]
        CTe = 1,

        [Modulo(PlanoEnum.Complementos, "Integração Maquina de Tintas")]
        IntegracaoMaquinaTintas = 2,

        [Modulo(PlanoEnum.Complementos, "Fotos Produtos")]
        FotosProdutos = 3,

        [Modulo(PlanoEnum.Complementos, "TEF")]
        TEF = 4,

        [Modulo(PlanoEnum.Complementos, "Pedido Externo")]
        PedidoExterno = 5,

        [Modulo(PlanoEnum.Complementos, "Comissão")]
        Comissao = 6,

        [Modulo(PlanoEnum.Complementos, "Documentos")]
        Documentos = 7,

        [Modulo(PlanoEnum.Complementos, "Cobrança API")]
        CobrancaAPI = 8,

        [Modulo(PlanoEnum.Complementos, "Conferência Pedido")]
        ConferenciaPedido = 9,

        [Modulo(PlanoEnum.Complementos, "Exportar Dados")]
        ExportarDados = 10,

        #endregion








    }
}