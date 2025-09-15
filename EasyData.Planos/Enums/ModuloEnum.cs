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

        [Modulo(PlanoEnum.Complementos, "CTe")]
        CTe = 1,

        [Modulo(PlanoEnum.Complementos, "Email")]
        Email = 2,

        [Modulo(PlanoEnum.Complementos, "Integração Maquina de Tintas")]
        IntegracaoMaquinaTintas = 3,

        [Modulo(PlanoEnum.Complementos, "Produtos Fotos")]
        ProdutosFotos = 4,

        [Modulo(PlanoEnum.Complementos, "TEF")]
        TEF = 5,

        [Modulo(PlanoEnum.Complementos, "Vendas Externas")]
        VendasExternas = 6,

        [Modulo(PlanoEnum.Gold, "Compras")]
        Compras = 7,

        [Modulo(PlanoEnum.Gold, "Contabilidade")]
        Contabilidade = 8,

        [Modulo(PlanoEnum.Gold, "Formação de Preço em Lote")]
        FormacaoPrecoLote = 9,

        [Modulo(PlanoEnum.Gold, "Logistica")]
        Logistica = 10,

        [Modulo(PlanoEnum.Gold, "Lotes")]
        Lotes = 11,

        [Modulo(PlanoEnum.Gold, "MDFe")]
        MDFe = 12,

        [Modulo(PlanoEnum.Lite, "Anexos")]
        Anexos = 13,

        [Modulo(PlanoEnum.Lite, "Cadastros")]
        Cadastros = 14,

        [Modulo(PlanoEnum.Lite, "Estoque")]
        Estoque = 15,

        [Modulo(PlanoEnum.Lite, "MDe")]
        MDe = 16,

        [Modulo(PlanoEnum.Lite, "Menu")]
        Menu = 17,

        [Modulo(PlanoEnum.Lite, "NFCe")]
        NFCe = 18,

        [Modulo(PlanoEnum.Lite, "NFe")]
        NFe = 19,

        [Modulo(PlanoEnum.Lite, "Nota Fiscal Entrada")]
        NotaFiscalEntrada = 20,

        [Modulo(PlanoEnum.Lite, "Relatorios")]
        Relatorios = 21,

        [Modulo(PlanoEnum.Lite, "Vendas")]
        Vendas = 22,

        [Modulo(PlanoEnum.Premium, "Conciliação Bancaria")]
        ConciliacaoBancaria = 23,

        [Modulo(PlanoEnum.Premium, "Filiais")]
        Filiais = 24,

        [Modulo(PlanoEnum.Premium, "Locais de Estoque")]
        LocaisEstoque = 25,

        [Modulo(PlanoEnum.Premium, "Produção")]
        Producao = 26,

        [Modulo(PlanoEnum.Start, "Cobrança API")]
        CobrancaAPI = 27,

        [Modulo(PlanoEnum.Start, "Cobrança CNAB")]
        CobrancaCNAB = 28,

        [Modulo(PlanoEnum.Start, "Conhecimento Frete Entrada")]
        CTeEntrada = 29,

        [Modulo(PlanoEnum.Start, "Financeiro")]
        Financeiro = 30,

        [Modulo(PlanoEnum.Start, "Graficos")]
        Graficos = 31,

    }
}
