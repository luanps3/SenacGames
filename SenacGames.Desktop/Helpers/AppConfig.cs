using System.Text.Json;

namespace SenacGames.Desktop.Helpers
{
    public static class AppConfig
    {
        private static JsonDocument? _config;

        ///<summary>
        ///URL base da API, Exemplo: "https://localhost:5223"
        ///
        /// Resolvida na seguinte ordem pelo ApiEndPointResolver:
        /// 1. lauchSettings.json do SenacGames.API 
        /// 2. appsettings.json ApiSessting.BaseUrl (fallback configuravel) fallback: é o valor default caso não seja encontrado no appsettings.json
        /// 3. String vazia se não encontrada (Program.cs exibe mensagem)
        ///</summary>   
        ///

    //public static string ApiBaseUrl =>
    //        //?? : Coalescência nula, retorna o valor à esquerda se não for nulo, caso contrário retorna o valor à direita
    //         ApiEndPointResolver.Resolve() ?? string.Empty;


    }
}
