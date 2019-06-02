using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using WindowsFormsApplication1;

enum TranslationRecordStatus { NEW, SCHEDULED_FOR_RETRY, FAILED }

public class TranslationDBService
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

    public void create(Translation record)
    {
        dataContext.Translations.InsertOnSubmit(record);
        dataContext.SubmitChanges();
    }

    internal void update(Translation record)
    {
        if (record.retry_count == 0)
        {
            application_setting wordsCounter = dataContext.application_settings.Single(s => s.settingName.Equals("learnedWordsCounter"));
            wordsCounter.settingValue = Convert.ToString(Int32.Parse(wordsCounter.settingValue) + 1);
        }
        Translation r = dataContext.Translations.Single(t => t.Id == record.Id);
        r.retry_count = record.retry_count;
        dataContext.SubmitChanges();
    }

    public List<Translation> getWordsForMatchTest()
    {
        return dataContext.Translations.Where(tr => tr.retry_count > 0).Take(4).ToList();
    }

    public Translation getWordForConstructorTest()
    {
        //return dataContext.Translations.Where(tr => tr.retry_count > 0).First();
        //return dataContext.Translations.OrderBy(tr => tr.retry_count).First();
        return dataContext.Translations.OrderBy(tr => tr.retry_count).First();
    }

}

