using MedicoService.Properties.Medicos;

namespace MedicoServiceTests.Medicos
{
    public class MedicoTest
    {
       
        [Fact]
        public void Construtor_DadoParametros_DeveSetarCorretamente()
        {
           
            var Id_usuario_esperado = Guid.NewGuid() + "";
            var Nome_esperado = "Joazinho";
            var Esp_esperado = "endocrino";
            var Valor_esperado = 200;

            var medico = new Medico(Id_usuario_esperado, Nome_esperado, Esp_esperado, Valor_esperado);

            Assert.Equal(Id_usuario_esperado, medico.IdUsuario);

        }

        [Fact]
        public void AtualizarMedico_DadoParametros_DeveSetarCorretamente()
        {

            var Id_usuario_esperado = Guid.NewGuid() + "";
            var Nome_esperado = "Joazinho";
            var Esp_esperado = "endocrino";
            var Valor_esperado = 200;

            var medico = new Medico(Id_usuario_esperado, Nome_esperado, Esp_esperado, Valor_esperado);

            var Id_usuario_esperado_atual = Guid.NewGuid() + "";
            var Nome_esperado_atual = "Joazinho";
            var Esp_esperado_atual = "endocrino";
            var Valor_esperado_atual = 200;

            medico.AtualizarMedico(Id_usuario_esperado_atual, Nome_esperado_atual, Esp_esperado_atual, Valor_esperado_atual);

            Assert.Equal(Id_usuario_esperado_atual, medico.IdUsuario);

        }
    }
}