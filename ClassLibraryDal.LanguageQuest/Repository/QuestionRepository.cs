using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibraryDal.LanguageQuest.Repository
{
    public class QuestionRepository:IRespository<Word>
    {
        public List<Word> All()
        {
            using (var db=new ModelLanguage())
            {
               return db.Words.ToList();
            }
        }

        public List<Word> Get(int count)
        {

            using (var db = new ModelLanguage())
            {
                return db.Words.Take(count).ToList();
            }
        }

        public void Add(Word t)
        {

            using (var db = new ModelLanguage())
            {
                 db.Words.Add(t);
                db.SaveChanges();
            }
        }

        public void Remove(Word t)
        {

            using (var db = new ModelLanguage())
            {
                db.Words.Remove(t);
                db.SaveChanges();
            }
        }
    }
}