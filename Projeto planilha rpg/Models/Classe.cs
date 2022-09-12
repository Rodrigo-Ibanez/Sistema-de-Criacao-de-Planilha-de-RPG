

namespace Projeto_planilha_rpg.Models
{
    public class Classe
    {

        private List<string> planilha = new List<string>();
        public void nomeDoPersonagem()
        {   
            Console.WriteLine("Digite o nome do seu personagem:");
            string i = Console.ReadLine();
            planilha.Add(i);
            
        }

        public void classeDoPersonagem()
        {
            Console.WriteLine("Digite a classe do seu personagem:");
            string x = Console.ReadLine();
            planilha.Add(x);
            
        }

        public void mostrarPlanilha()
        {
            if (planilha.Any())
            {
                Console.WriteLine($"A planilha Completa:");
                
                foreach (var nome in planilha)
                {
                    Console.WriteLine($"{nome}");
                    
                }
                
              
            }
            else
            {
                Console.WriteLine("A planilha está incompleta.");
            }
        }
        

        
    }
}