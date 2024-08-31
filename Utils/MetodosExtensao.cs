namespace Solid.Utils;
static class MetodosExtensao
{
    public static string CaixaAltaPrimeiraLetra(this string palavra)
    {
        if (palavra.Length > 0)
        {
            // Array de caracteres (array) / copir as palavras para array. 
            char[] array = palavra.ToCharArray();
            array[0] = char.ToUpper(array[0]);

            // instância do método. 
            return new string(array);
        }
        return palavra;
    }
}