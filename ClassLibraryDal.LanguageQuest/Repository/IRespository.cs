using System.Collections.Generic;

namespace ClassLibraryDal.LanguageQuest.Repository
{
    public interface IRespository<T>
    {

        List<T> All();

        List<T> Get(int count);

        void Add(T t);


        void Remove(T t);

    }
}
