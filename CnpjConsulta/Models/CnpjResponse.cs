using System.Text.Json.Serialization;

public class CnpjResponse
{
    [JsonPropertyName("nome")]
    public string Nome { get; set; }

    [JsonPropertyName("fantasia")]
    public string NomeFantasia { get; set; }

    [JsonPropertyName("cnpj")]
    public string Cnpj { get; set; }

    [JsonPropertyName("situacao")]
    public string Situacao { get; set; }

    [JsonPropertyName("tipo")]
    public string Tipo { get; set; }

    [JsonPropertyName("atividade_principal")]
    public List<AtividadePrincipal> AtividadesPrincipais { get; set; }
}

public class AtividadePrincipal
{
    [JsonPropertyName("code")]
    public string Codigo { get; set; }

    [JsonPropertyName("text")]
    public string Descricao { get; set; }
}

public class SimplesNacional
{
    [JsonPropertyName("optante")]
    public bool Optante { get; set; }

    [JsonPropertyName("data_opcao")]
    public string DataOpcao { get; set; }

    [JsonPropertyName("data_exclusao")]
    public string DataExclusao { get; set; }

    [JsonPropertyName("ultima_atualizacao")]
    public DateTime UltimaAtualizacao { get; set; }
}