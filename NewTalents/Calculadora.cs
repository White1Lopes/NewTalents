namespace NewTalents
{
    public class Calculadora
    {
        private List<string> ListaHistorico;
        private string Data;
        
        public Calculadora(string data)
        {
            ListaHistorico = new List<string>();
            Data = data;
        }

        public int Somar(int val1, int val2)
        {
            int res = val1 + val2;
            InserirHistoricoNaLista(res, nameof(Somar));
            return res;
        }

        public int Subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            InserirHistoricoNaLista(res, nameof(Subtrair));
            return res;
        }

        public int Multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            InserirHistoricoNaLista(res, nameof(Multiplicar));
            return res;
        }

        public int Dividir(int val1, int val2)
        {
            int res = val1 / val2;
            InserirHistoricoNaLista(res, nameof(Dividir));
            return res;
        }

        public bool EhPar(int val)
        {
            bool res = val % 2 == 0;
            InserirHistoricoNaLista(res, nameof(EhPar));
            return res;
        }

        public List<string> Historico()
        {
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
            return ListaHistorico;
        }

        private void InserirHistoricoNaLista(object res, string metodo)
        {
            ListaHistorico.Insert(0, $"Método: {metodo} - Res: {res} - data: {Data}");
        }
    }
}
