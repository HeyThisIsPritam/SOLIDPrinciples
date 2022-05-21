using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.D___SOLID
{
    public class BusinessLogicLayer // BusinessLogicLayer is a higher level module . And it not directly dependent on lower level module 
    {                               // as it has referance to a Interface which is inplemented by lower level module,Thus achived DIP 
        private readonly IRepository DAL;
        public BusinessLogicLayer(IRepository repository)
        {
            DAL = repository;
        }
        public void Save(Object details)
        {
            DAL.save(details);
            //Some more code.
        }

    }
}
