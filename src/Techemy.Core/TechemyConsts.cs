using Techemy.Debugging;

namespace Techemy
{
    public class TechemyConsts
    {
        public const string LocalizationSourceName = "Techemy";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "08a73984e54f4e80930d6f21f07e867e";
    }
}
