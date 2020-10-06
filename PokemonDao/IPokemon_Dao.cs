using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDao
{
    interface IPokemon_Dao
    {
        List<Pokemon> GetPokemons();
        void UpdatePokemon(string id);
        void DeletePokemon(string id);
        void AddPokemon(Pokemon pokemon);
    }
}
