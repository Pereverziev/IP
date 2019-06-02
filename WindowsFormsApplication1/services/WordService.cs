using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using WindowsFormsApplication1;

public class WordService
{
    private DBClassesDataContext dataContext;

    public WordService(DBClassesDataContext dataContext)
    {
        this.dataContext = dataContext;
    }

    public ICollection<Word> getAll()
    {
        return dataContext.Words.ToList();
    }

    public void create(Word record)
    {
        dataContext.Words.InsertOnSubmit(record);
        dataContext.SubmitChanges();
    }

    public void batchCreate(IList<Word> wordList)
    {
        dataContext.Words.InsertAllOnSubmit(wordList);
        dataContext.SubmitChanges();
    }

    public bool checkIfWordsExistInDb(String word1, String word2)
    {
        return dataContext.Words.Where(w => w.word1 == word1 || w.word1 == word2).ToList().Count() == 0;
    }

    public ICollection<Word> getWordsByLanguageId(long id)
    {
        return dataContext.Words.Where(w => w.language_id == id).ToList();
    }

    public String getWordById(int id)
    {
        return dataContext.Words.Where(w => w.Id == id).ToList().First().word1;
    }
    public int getIdByWord(string word1)
    {
        return dataContext.Words.Where(w => w.word1 == word1).ToList().First().Id;
    }
}

