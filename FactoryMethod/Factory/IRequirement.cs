using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface IRequirement
    {
        int Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        string Type { get; set; }
        int Priority { get; set; }

        //void Edit(string title, string description, int priority);

        void Delete();
    }
}