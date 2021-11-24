using System.Collections.Generic;

namespace verysmall
{
    // 1. Está totalmente coeso?
    // 2. Tem apenas uma responsabilidade?
    // 3. Qual é o início e o fim?
    // 4. Como seria para gerar um outro formato de arquivo (Ex.: XML, JPG, SVG, etc)
    // 5. Está aberto a extensões?
    // 6. Está fechado para alterações?
    class Program
    {
        // OCP - Open-Closed Principle
        abstract public class Arquivo
        {
            public abstract void Gerar();
        }

        public class ArquivoDocx : Arquivo
        {
            public override void Gerar()
            {
            }
        }

        public class ArquivoXlsx : Arquivo
        {
            public override void Gerar()
            {
                // 
            }
        }

        public class ArquivoPdf : Arquivo
        {
            public override void Gerar()
            {
                
            }
        }

        public class GeradorDeArquivos
        {
            public void GerarArquivos(IEnumerable<Arquivo> arquivos)
            {
                foreach (Arquivo arquivo in arquivos)
                    arquivo.Gerar();
            }
        }
    }
}