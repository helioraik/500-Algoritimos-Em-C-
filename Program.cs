using System;
using System.Collections.Generic;
using Algoritimos_Origin;

namespace _500_Algoritimos_Origin
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Algarismos das Dezenas", AlgarismosDasDezenas.Executar},
                {"Captura data", CapturaData.Executar},
                {"Sucessor e Antecessor", SucessorAntecessor.Executar},
                {"Soma simples", SomaSimples.Executar},
                {"Produto simples", ProdutoSimples.Executar},
                {"Terça parte de um numero real", TercaPartNum.Executar},
                {"Media aritimetica dois numeros", MediaDoisNumeros.Executar},
                {"Divisão detalhada ", DivisaoEmDetalhes.Executar},
                {"Media Ponderada", MediaPonderada.Executar},
                {"Funcoes matematicas", FuncoesMathGeo.Executar},
                {"Raiz e quandrado", RaizAndQuadrado.Executar},
                {"Reajust de 1%", ReajusteUmPorcento.Executar},
                {"Calculo de Energia", CalculoEnergia.Executar},
                {"Funcoes de String", FuncoesString.Executar},
                {"Calculos retangulo", CalculosRetangulo.Executar},
                {"Calculos circulo", CalculosCirculo.Executar},
                {"Calculos quadrado", CalculosQuadrado.Executar},
                {"Calculo Diagonal Paralelepipedo", CalculoDiagonalParalelepipedo.Executar},
                {"Area losango", AreaLosango.Executar},
                {"Area triangulo", AreaTriangulo.Executar},
                {"Media truncada e arrendodada", MediaFinalDuasNotas.Executar},
                {"Hipotenusa trinagulo retangulo", CalcHipotenusa.Executar},
                {"Decimo termo da PA", PADecimoTermo.Executar},
                
            });

            central.SelecionarEExecutar();
        }
    }
}
