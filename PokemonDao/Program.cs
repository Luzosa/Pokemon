using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDao
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon_DaoImpl dao = new Pokemon_DaoImpl();
            List<Pokemon> pokemons = new List<Pokemon>();
            Pokemon Ivysaur = new Pokemon() { Name = "Ivysaur", Gender = "Male", Category = "Seed", Elements = new List<Element>() { new Element() { Name = "Grass" } } };
            pokemons = dao.GetPokemons();

            dao.AddPokemon(Ivysaur);

            foreach (var item in pokemons)
            {
                Console.WriteLine("Name: " + item.Name);
                Console.WriteLine("Category: " + item.Category);
                Console.WriteLine("Gender: " + item.Gender);
                Console.Write("Elements: ");
                for (int i = 0; i < item.Elements.Count; i++)
                {
                    Console.Write(item.Elements[i].Name);
                    if(i == 0)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("");
                
            }
            Console.ReadKey();
        }
    }
}
