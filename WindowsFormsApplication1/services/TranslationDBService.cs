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

    public void create(Translation record)
    {
        dataContext.Translations.InsertOnSubmit(record);
        dataContext.SubmitChanges();
    }

}

