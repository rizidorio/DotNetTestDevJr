using System.Collections.Generic;
using Tasks.HelpClasses;

namespace Tasks
{
    public class Task7
    {
        /*
         * Desenvolma um método que retorne o nome dos produtos que estão com estoque zerado
         * Dica: A classe Repository possui as informções dos Products
         */
        public static List<string> GetProductsOutOfStock() 
        {
            Repository repository = new Repository();

            List<string> names = new List<string>();

            var products = repository.Products.FindAll(x => x.Stock.Quantity == 0);

            foreach (var product in products)
            {
                names.Add(product.Name);
            }

            return names;
        }

        /*
        * Desenvolma um método que retorne a soma total das quantidades de estoque dos itens
        * Dica: A classe Repository possui as informções dos Products
        */
        public static int GetSumStock() 
        {
            Repository repository = new Repository();

            int sum = 0;

            var products = repository.Products.FindAll(x => x.Stock.Quantity > 0);

            foreach (var item in products)
            {
                sum += item.Stock.Quantity;
            }

            return sum;
        }

        /*
         * Crie um método que verifique, dado Id e quantidade solicitada do produto
         * se o mesmo possui quantidade em estoque para venda
         * Dica: A classe Repository possui as informções dos Products
         * 
         */
        public static bool IsSalePossible(int productId, int orderQuantity) 
        {
            Repository repository = new Repository();

            var product = repository.Products.Find(x => x.Id == productId);

            if (orderQuantity <= product.Stock.Quantity)
                return true;
            else
                return false;
        }
    }
}
