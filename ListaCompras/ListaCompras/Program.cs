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

            Console.WriteLine("INFORME OS 3 PRODUTOS DA SUA LISTA DE COMPRAS!");
            while(listaCompras.Count < 3)
            {
                Console.WriteLine("DIGITE O NOME DO PRODUTO: ");
                nome = Console.ReadLine().ToUpper();
                Console.WriteLine($"DIGITE O VALOR DE {nome}: ");
                valorProduto = Convert.ToDecimal(Console.ReadLine());
                Console.Clear();

                Produto produto = new Produto(nome, valorProduto);
                listaCompras.Add(produto);
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
