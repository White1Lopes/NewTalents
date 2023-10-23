using NewTalents;

namespace TestsNewTalents
{
    public class UnitTest1
    {
        private Calculadora _calculadora { get; set; }

        public UnitTest1()
        {
            _calculadora = new Calculadora(DateOnly.FromDateTime(DateTime.UtcNow).ToString());
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void Somar_NumerosInteiros_RetornarNumeroEsperado(int val1, int val2, int resultado)
        {
            int resultadoCalculadora = _calculadora.Somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void Multiplicar_NumerosInteiros_RetornarNumeroEsperado(int val1, int val2, int resultado)
        {

            int resultadoCalculadora = _calculadora.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void Dividir_NumerosInteiros_RetornarNumeroEsperado(int val1, int val2, int resultado)
        {

            int resultadoCalculadora = _calculadora.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void Subtrair_NumerosInteiros_RetornarNumeroEsperado(int val1, int val2, int resultado)
        {

            int resultadoCalculadora = _calculadora.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(5, 0)]
        public void Dividir_DivisorZero_RetornarExcecao(int val1, int val2)
        {
            Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(val1, val2));
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 })]
        public void Historico_SomarNumerosEPegarHistorico_RetornarHistoricoComValores(int[] valores)
        {
            for (var i = 0; valores.Length > i; i += 2)
            {
                _calculadora.Somar(valores[i], valores[i + 1]);
            }
            var lista = _calculadora.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);

        }

        [Theory]
        [InlineData(new int[] { 2, 4, 6, 8, 10, 12, 14, 16 })]
        public void EhPar_VerificarNumerosInteirosPares_RetornarVerdadeiro(int[] valores)
        {
            foreach (var valor in valores) 
                Assert.True(_calculadora.EhPar(valor));

        }

        [Theory]
        [InlineData(new int[] { 1, 3, 5, 7, 9, 11, 13, 15 })]
        public void EhPar_VerificarNumerosInteirosImpares_RetornarFalso(int[] valores)
        {
            foreach (var valor in valores)
                Assert.False(_calculadora.EhPar(valor));

        }
    }
}