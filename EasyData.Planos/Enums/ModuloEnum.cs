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
        [Modulo(PlanoEnum.Complementos, "Configurações")]
        Configuracao = 0,

        [Description("CTe")]
        CTe = 1,

        [Description("Email")]
        Email = 2,

        [Description("Integração Maquina de Tintas")]
        IntegracaoMaquinaTintas = 3,

        [Description("Produtos Fotos")]
        ProdutosFotos = 4,

        [Description("TEF")]
        TEF = 5,

        [Description("Vendas Externas")]
        VendasExternas = 6,

        [Description("Compras")]
        Compras = 7,

        [Description("Contabilidade")]
        Contabilidade = 8,

        [Description("Formação de Preço em Lote")]
        FormacaoPrecoLote = 9,

        [Description("Logistica")]
        Logistica = 10,

        [Description("Lotes")]
        Lotes = 11,

        [Description("MDFe")]
        MDFe = 12,

        [Description("Anexos")]
        Anexos = 13,

        [Description("Cadastros")]
        Cadastros = 14,

        [Description("Estoque")]
        Estoque = 15,

        [Description("MDe")]
        MDe = 16,

        [Description("Comandos Basicos")]
        Menu = 17,

        [Description("NFCe")]
        NFCe = 18,

        [Description("NFe")]
        NFe = 19,

        [Description("Nota Fiscal Entrada")]
        NotaFiscalEntrada = 20,

        [Description("Relatorios")]
        Relatorios = 21,

        [Description("Vendas")]
        Vendas = 22,

        [Description("Conciliação Bancaria")]
        ConciliacaoBancaria = 23,

        [Description("Filiais")]
        Filiais = 24,

        [Description("Locais de Estoque")]
        LocaisEstoque = 25,

        [Description("Produção")]
        Producao = 26,

        [Description("Cobrança API")]
        CobrancaAPI = 27,

        [Description("Cobrança CNAB")]
        CobrancaCNAB = 28,

        [Description("Conhecimento Frete Entrada")]
        CTeEntrada = 29,

        [Description("Financeiro")]
        Financeiro = 30,

        [Description("Graficos")]
        Graficos = 31,


    }
}
