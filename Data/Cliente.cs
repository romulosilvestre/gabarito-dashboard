using Newtonsoft.Json;

public class Cliente
{
    /*

     Nome = nome;
        Cpf = cpf;
        Telefone = telefone;
        Email = email;
        DataNascimento = dataNascimento;
        Funcao = funcao;

    */

    [JsonProperty("Id")]
    public int Id { get; set; }

    [JsonProperty("Nome")]
    public string? Nome { get; set; }


    [JsonProperty("Cpf")]
    public string? Cpf { get; set; }

    [JsonProperty("Telefone")]
    public string? Telefone { get; set; }
    [JsonProperty("Email")]
    public string? Email { get; set; }

    [JsonProperty("DataNascimento")]

    public DateTime DataNascimento { get; set; }

}