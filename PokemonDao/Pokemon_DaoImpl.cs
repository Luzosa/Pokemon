using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDao
{
    class Pokemon_DaoImpl : IPokemon_Dao
    {
        public void AddPokemon(Pokemon pokemon)
        {
            string connetionString = @"Server=(localdb)\MSSQLLocalDB;Database=PokemonDB;Trusted_Connection=True;";
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand command = new SqlCommand("dbo.InsertPokemon", cnn);
            command.Parameters.AddWithValue("@name", pokemon.Name);
            command.Parameters.AddWithValue("@element", pokemon.Elements);
            command.Parameters.AddWithValue("@category", pokemon.Category);
            command.Parameters.AddWithValue("@gender", pokemon.Gender);
            cnn.Close();
        }

        public void DeletePokemon(string id)
        {
            throw new NotImplementedException();
        }

        public List<Pokemon> GetPokemons()
        {
            List<Pokemon> pokemons = new List<Pokemon>();
            List<Element> element = new List<Element>();
            string connetionString = @"Server=(localdb)\MSSQLLocalDB;Database=PokemonDB;Trusted_Connection=True;";
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            SqlCommand command = new SqlCommand("dbo.GetPokemon", cnn);
            cnn.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                element.Add(new Element()
                {
                    Name = reader["ElementOne"].ToString()
                });

                element.Add(new Element()
                {
                    Name = reader["ElementTwo"].ToString()
                });

                pokemons.Add(new Pokemon()
                {
                    Name = reader["Name"].ToString(),
                    Gender = reader["Gender_Name"].ToString(),
                    Category = reader["Category"].ToString(),
                    Elements = element
                });
                return pokemons;
            }
            cnn.Close();
            return null;

        }

        public void UpdatePokemon(string id)
        {
            throw new NotImplementedException();
        }

        public Pokemon_DaoImpl()
        {

        }
    }
}
