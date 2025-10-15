namespace ListaCompras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> listaCompras = new List<Produto>();
            string nome = string.Empty;
            decimal valorProduto = 0m;
            decimal total = 0m;
            bool continua = true;

            Console.WriteLine("INFORME OS PRODUTOS DA SUA LISTA DE COMPRAS!");
            while(continua)
            {
                Console.WriteLine("DIGITE O NOME DO PRODUTO: ");
                nome = Console.ReadLine().ToUpper();
                Console.WriteLine($"DIGITE O VALOR DE {nome}: ");
                valorProduto = Convert.ToDecimal(Console.ReadLine());
                Console.Clear();

                Produto produto = new Produto(nome, Decimal.Round(valorProduto, 2));
                listaCompras.Add(produto);

                Console.WriteLine("DESEJA ADICIONAR MAIS ALGUM PRODUTO? (S/N)");
                string resposta = Console.ReadLine().ToUpper();
                if (resposta == "N")
                {
                    continua = false;
                }
                Console.Clear();
            }

            Console.WriteLine("--- LISTA DE COMPRAS ---");
            foreach(Produto produto in listaCompras)
            {
                total += produto.ValorProduto;
                Console.WriteLine($"{produto.Nome} - R$ {produto.ValorProduto}");
            }
            Console.WriteLine($"------------------------\nTOTAL: R${total}");
        }
    }

    public class Produto
    {
        public string Nome;
        public decimal ValorProduto;

        public Produto(string nome, decimal valorProduto)
        {
            this.Nome = nome;
            this.ValorProduto = valorProduto;
        }
    }
}
