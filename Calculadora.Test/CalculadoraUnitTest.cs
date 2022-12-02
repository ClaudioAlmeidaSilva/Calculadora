using CalculadoraApp;

namespace Calculadora.Test
{
    public class CalculadoraUnitTest
    {
        public class CalculadoraTest
        {
            [Fact]
            public void Adicao_DeveRetornarOValorCorreto()
            {
                Operacoes o = new Operacoes();
                var resultado = o.Adicao(2, 2);
                //Verifica se o resultado é igual a 4.
                Assert.Equal(4, resultado);
            }

            [Fact]
            public void Adicao_DeveValidarSeSomaEstaIncorreta()
            {
                Operacoes o = new Operacoes();
                var resultado = o.Adicao(3, 2);
                //Verifica se está calculando        
                Assert.NotEqual(10, resultado);
            }

            [Fact]
            public void Subtracao_DeveRetornarOValorCorreto()
            {
                Operacoes o = new Operacoes();
                var resultado = o.Subtracao(10, 2);
                //Verifica se o resultado é igual a 8        
                Assert.Equal(8, resultado);
            }

            [Fact]
            public void Subtracao_DeveValidarSeSubtracaoEstaIncorreta()
            {
                Operacoes o = new Operacoes();
                var resultado = o.Adicao(12, 6);
                //Verifica se está calculando        
                Assert.NotEqual(4, resultado);
            }

            [Fact]
            public void Mutiplicacao_DeveRetornarOValorCorreto()
            {
                Operacoes o = new Operacoes();
                var resultado = o.Mutiplicacao(20, 10);
                //Verifica se o resultado é igual a 200        
                Assert.Equal(200, resultado);
            }

            [Fact]
            public void Mutiplicacao_DeveValidarSeMutiplicacaoEstaIncorreta()
            {
                Operacoes o = new Operacoes();
                var resultado = o.Mutiplicacao(6, 6);
                //Verifica se está calculando        
                Assert.NotEqual(20, resultado);
            }

            [Fact]
            public void Divisao_DeveRetornarOValorCorreto()
            {
                Operacoes o = new Operacoes();
                var resultado = o.Divisao(10, 2);
                //Verifica se o resultado é igual a 200        
                Assert.Equal(5, resultado);
            }

            [Fact]
            public void Divisao_DeveValidarSeDivisaoEstaIncorreta()
            {
                Operacoes o = new Operacoes();
                var resultado = o.Adicao(6, 6);
                //Verifica se está calculando        
                Assert.NotEqual(20, resultado);
            }
        }
    }
}