namespace TesteLive.Models.Response
{
    public class ErrorResponse
    {
        public ErrorResponse (int codigo, System.Exception erro)
        {
            this.Codigo = codigo;
            this.Erro = erro.Message;
        }

        public int Codigo { get; set; }
        public System.Exception Erro { get; set; }
    }
}