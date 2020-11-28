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
                {"Quinto termo da PG", PGQuintoTermo.Executar},
                {"Desconto produto 9%", DescontoNovePorCento.Executar},
                {"Salario liquido professor", SalarioLiquidoProfessor.Executar},
                {"Converte Celcius em Fahrenheit", CelsiusConvertFahrenheit.Executar},
                {"Calcula volume do cilindro", VolumeCilindro.Executar},
                {"Dados viajem", CombustivelParaViajem.Executar},
                {"Calcula prestacao atraso", PrestacaoAtraso.Executar},
                {"Troca de variaveis", TrocaVariaveis.Executar},
                {"Gorjeta do restaurante", GorjetaRestaurante.Executar},
                {"Minutos passados", CalculaMinutosPassados.Executar},
                {"Numero arredondado", PartesNumeroReal.Executar},
                {"Quantos salarios minimos voçe ganha? ", QuantosSalariosMinimosGanha.Executar},
                {"Peso em gramas", PesoGramas.Executar},
                {"Sucessor acima de sessenta", SucessorAcimaSessenta.Executar},
                {"Quadrado da diferença e Diferença dos quadrados", QuadradoDaDiferenca.Executar},
                {"Lados diferentes de um poligono", DiagonaisPoligono.Executar},
                {"Poupança progamada", PoupancaProgamada.Executar},
                {"Locadora", Locadora.Executar},
                {"Inverso ou Absoluto de um numero", InversoNumero.Executar},
                {"Impar ou par", ImparOuPar.Executar},
                {"Positivo, negativo ou nulo", PositivoNegativoNulo.Executar},
                {"Capital do Brasil", CapitalBrasil.Executar},
                {"Calculadora simples", Calculadora.Executar},
                {"Gravidade dos planetas", GravidadePlanetas.Executar},
                {"Decisoes positivo negativo", DecisoesNegPos.Executar},
                {"Multiplo de tres", MultiploDeTres.Executar},
                {"Divisivel por 3 e por 7", DivisivelTresESete.Executar},
                
            });

            central.SelecionarEExecutar();
        }
    }
}
