using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDal.LanguageQuest;
using ClassLibraryDal.LanguageQuest.Repository;

namespace ClassLibraryService.LanguageQuest.Services
{
   public  class QuestionService:IService<Word>
   {
       private readonly IRespository<Word> _repository = new QuestionRepository();

        public List<Word> All()
        {
            return _repository.All();
        }

        public List<Word> Get(int count)
        {
            return _repository.Get(count);
        }

        public void Add(Word t)
        {
           _repository.Add(t);
        }

        public void Remove(Word t)
        {
           _repository.Remove(t);
        }
    }

    
}
