using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechArtProfileProject.Lib.Core.Abstraction
{
    public interface ICRUDService<T>
    {
        public void  Add(T model);
        public void Update(T oldModel);
        public void Delete(T model);
    }
}
