using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryService.LanguageQuest.Services
{
    public interface IService<T>
    {
        List<T> All();

        List<T> Get(int count);

        void Add(T t);


        void Remove(T t);
    }
}
