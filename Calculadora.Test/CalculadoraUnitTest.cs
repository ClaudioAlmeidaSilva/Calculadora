namespace Calculadora.Test
{
    public class CalculadoraUnitTest
    {
        public class CalculadoraTest
        {
            [Fact]
            public void Soma_DeveRetornarOValorCorreto()
            {
                CalculadoraConsole c = new CalculadoraConsole();
                var resultado = c.Soma(10, 20);
                //Verifica se o resultado é igual a 30        
                Assert.AreEqual(30, resultado);
            }
        }
    }
}