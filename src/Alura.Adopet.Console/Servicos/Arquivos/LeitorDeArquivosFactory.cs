using Alura.Adopet.Console.Servicos.Abstracoes;

namespace Alura.Adopet.Console.Servicos.Arquivos;

public static class LeitorDeArquivosFactory
{
    public static ILeitorDeArquivos? CreatePetFrom(string caminhoArquivo)
    {
        var extensao =  Path.GetExtension(caminhoArquivo);
        switch (extensao)
        {
            case ".csv":
                return new LeitorDeArquivoCSV(caminhoArquivo);
            case ".json":
                return new LeitorDeArquivoJson(caminhoArquivo);
            default: return null;

        }
    }
}
