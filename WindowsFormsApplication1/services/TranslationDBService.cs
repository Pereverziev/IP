using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

enum TranslationRecordStatus { NEW, SCHEDULED_FOR_RETRY, FAILED }

class TranslationDBService
{
    private DBClassesDataContext dataContext;

    public TranslationDBService(DBClassesDataContext dataContext)
    {
        this.dataContext = dataContext;
    }

    public ICollection<Translation> getAll()
    {
        return dataContext.Translations.ToList();
    }

    public ICollection<Translation> getRecordsForExercise(int wordsCount)
    {
        return dataContext.Translations.Take(wordsCount).ToList();
    }

    public void create(Translation record)
    {
        dataContext.Translations.InsertOnSubmit(record);
        dataContext.SubmitChanges();
    }

    internal void update(Translation record)
    {
        Translation r = dataContext.Translations.Single(t => t.Id == record.Id);
        r.retry_count = record.retry_count;
        dataContext.SubmitChanges();
    }
    public int getIdTByWord(int id)
    {
        //return dataContext.Words.Where(w => w.word1 == word1).ToList().First().word1;
        //return dataContext.Words.Where(w => w.word1 == word1).ToList().First().Id;
        int res = -1;
        try
        {
            res = dataContext.Translations.Where(t => t.word_id_1 == id).ToList().First().Id;
        }
        catch (Exception InvalidOperationException)
        {
            res = dataContext.Translations.Where(t => t.word_id_2 == id).ToList().First().Id;
        }
        return res;

    }

    public int getRetryCountTByID(int id)
    {
        return (int)dataContext.Translations.Where(t => t.Id == id).ToList().First().retry_count.GetValueOrDefault(0);
    }
}

