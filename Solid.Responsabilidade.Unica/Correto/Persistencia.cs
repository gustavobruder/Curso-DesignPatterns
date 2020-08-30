using System.IO;

namespace Solid.Responsabilidade.Unica.Correto
{
    public class Persistencia
    {
        public void CriarArquivoDiario(Diario diario, string arquivo, bool overwrite = false)
        {
            if (overwrite || !File.Exists(arquivo))
            {
                File.WriteAllText(arquivo, diario.ToString());
            }
        }
    }
}