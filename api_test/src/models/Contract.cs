namespace src.Models;

public class Contract
{
    public Contract()
    {
        this.DataCriacao = DateTime.Now;
        this.Valor = 0;
        this.TokenId = "0000000";
        this.pago = false;
    }

    public Contract(string TokenId, double Valor)
    {
        this.DataCriacao = DateTime.Now;
        this.Valor = Valor;
        this.TokenId = TokenId;
    }

    public DateTime DataCriacao {get; set;}
    public string TokenId {get; set;}
    public double Valor { get; set; }

    public bool pago { get; set; }
    
}