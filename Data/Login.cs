using Newtonsoft.Json;
public class Login{ 
    
   [JsonProperty("Usuario")] 
   public string? Usuario { get; set; }

   [JsonProperty("Senha")] 
   public string? Senha { get; set; }

}