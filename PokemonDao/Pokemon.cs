using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDao
{
    class Pokemon
    {
        private string name;
        private string category;
        private string gender;
        private List<Element> elements;

        public List<Element> Elements
        {
            get { return elements; }
            set { elements = value; }
        }


        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }


        public string Category
        {
            get { return category; }
            set { category = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Pokemon()
        {

        }

    }
}
