using Apoio.Busca;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace Apoio.Testes.Busca
{    
    public class BuscaTestes
    {
        #region Busca Sequencial
        [Fact]
        public void BuscaSequencial_DeveRetornarNull_QuandoColecaoVazia()
        {
            // Arrange
            var palavras = new List<string>();

            // Act
            var valor = palavras.BuscaSequencial("a");

            // Assert
            valor.Should().BeNull();
        }

        [Theory]
        [InlineData(-3)]
        [InlineData(-2)]
        [InlineData(-1)]        
        [InlineData(0)]
        [InlineData(4)]
        [InlineData(7)]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        public void BuscaSequencial_DeveRetornarValorPadrao_QuandoNaoEncontrarValor(int valorProcurar)
        {
            // Arrange
            var numeros = new[] {1,2,3,5,6,8,9 };

            // Act
            var valor = numeros.BuscaSequencial(valorProcurar, -999);

            // Assert
            valor.Should().Be(-999);
        }
        
        [Theory]
        [InlineData("ab")]
        [InlineData("abe")]
        [InlineData("abacateiroz")]
        [InlineData("abacateiross")]
        [InlineData("abacaxa")]
        [InlineData("abacaxo")]
        [InlineData("abacaxiss")]
        [InlineData("abaciair")]
        [InlineData("abaciait")]
        [InlineData("abaciak")]
        [InlineData("abaciam")]
        [InlineData("abadd")]
        [InlineData("abadf")]
        [InlineData("abader")]
        [InlineData("abadet")]
        [InlineData("abadess")]
        [InlineData("abadessb")]        
        public void BuscaSequencial_DeveRetornarNull_QuandoNaoEncontrarValor(string valorProcurar)
        {
            // Arrange
            var palavras = new[]
            {
                "aba",
                "abacate",
                "abacateiro",
                "abacateiros",
                "abacates",
                "abacaxi",
                "abacaxis",
                "abaciais",
                "abacial",
                "abade",
                "abades",
                "abadessa"
            };

            // Act
            var valor = palavras.BuscaSequencial(valorProcurar);

            // Assert
            valor.Should().BeNull();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        public void BuscaSequencial_DeveRetornarValor_QuandoElementoExistir(int valorProcura)
        {
            // Arrange
            var numeros = new[] { 1, 2, 3, 5, 6, 8, 9 };

            // Act
            var valor = numeros.BuscaSequencial(valorProcura);

            // Assert
            valor.Should().Be(valor);
        }
#endregion

        #region Busca Binaria
        [Fact]
        public void BuscaBinaria_DeveRetornarNull_QuandoColecaoVazia()
        {
            // Arrange
            var palavras = new List<string>();

            // Act
            var valor = palavras.BuscaBinaria("a");

            // Assert
            valor.Should().BeNull();
        }

        [Theory]
        [InlineData(-3)]
        [InlineData(-2)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(4)]
        [InlineData(7)]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        public void BuscaBinaria_DeveRetornarValorPadrao_QuandoNaoEncontrarValor(int valorProcurar)
        {
            // Arrange
            var numeros = new[] { 1, 2, 3, 5, 6, 8, 9 };

            // Act
            var valor = numeros.BuscaBinaria(valorProcurar, -999);

            // Assert
            valor.Should().Be(-999);
        }

        [Theory]
        [InlineData("ab")]
        [InlineData("abe")]
        [InlineData("abacateiroz")]
        [InlineData("abacateiross")]
        [InlineData("abacaxa")]
        [InlineData("abacaxo")]
        [InlineData("abacaxiss")]
        [InlineData("abaciair")]
        [InlineData("abaciait")]
        [InlineData("abaciak")]
        [InlineData("abaciam")]
        [InlineData("abadd")]
        [InlineData("abadf")]
        [InlineData("abader")]
        [InlineData("abadet")]
        [InlineData("abadess")]
        [InlineData("abadessb")]
        public void BuscaBinaria_DeveRetornarNull_QuandoNaoEncontrarValor(string valorProcurar)
        {
            // Arrange
            var palavras = new[]
            {
                "aba",
                "abacate",
                "abacateiro",
                "abacateiros",
                "abacates",
                "abacaxi",
                "abacaxis",
                "abaciais",
                "abacial",
                "abade",
                "abades",
                "abadessa"
            };

            // Act
            var valor = palavras.BuscaBinaria(valorProcurar);

            // Assert
            valor.Should().BeNull();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        public void BuscaBinaria_DeveRetornarValor_QuandoElementoExistir(int valorProcura)
        {
            // Arrange
            var numeros = new[] { 1, 2, 3, 5, 6, 8, 9 };

            // Act
            var valor = numeros.BuscaBinaria(valorProcura);

            // Assert
            valor.Should().Be(valor);
        }
        #endregion
    }
}
