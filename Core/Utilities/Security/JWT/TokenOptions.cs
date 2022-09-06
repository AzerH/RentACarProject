namespace Core.Utilities.Security.JWT
{
    public class TokenOptions
    {
        public string Audience { get; set; } // istifadəci kütləsi
        public string Issuer { get; set; } // imzalayan
        public int AccessTokenExpiration { get; set; } //müddət
        public string SecurityKey { get; set; }
    }

}
