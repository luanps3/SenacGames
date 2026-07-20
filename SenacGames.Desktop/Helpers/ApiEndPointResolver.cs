namespace SenacGames.Desktop.Helpers
{
    public static class ApiEndPointResolver
    {
        //===============================================
        // CACHE
        //===============================================

        //Armazena o resultado após a primeira resolução
        private static string? _resolvedUrl;
        private static bool _resolved = false;

        //===============================================
        // CONSTANTES
        //===============================================
        
        ///<summary>
        ///Nome do projeto da API (usado para localizar o lauchSettings.json)
        /// </summary>
        private const string ApiProjectName = "SenacGames.API";


        ///<summary>
        ///Caminho relativo do lauchSettings.json do projeto SenacGames.API
        /// </summary>
        private const string LaunchSettingsrelativePath =
            $"{ApiProjectName}/Properties/launchSettings.json";

        ///<summary>
        ///Perfis preferidos do lauchSettings (em ordem de preferência)
        ///"http" é o preferido em desenvolvido para evitar erros de SSL
        ///</summary> 
        private static readonly string[] PreferredProfiles = ["http", "https", "IIS Express"];

        //===============================================
        // MÉTODO PRINCIPAL
        //===============================================



    }
}
