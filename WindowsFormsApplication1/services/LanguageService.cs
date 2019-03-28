using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


class LanguageService
{
    private DBClassesDataContext dataContext;

    public LanguageService(DBClassesDataContext dataContext)
    {
        this.dataContext = dataContext;
    }

    public ICollection<Language> getAll()
    {
        return dataContext.Languages.ToList();
    }

    public void create(Language record)
    {
        dataContext.Languages.InsertOnSubmit(record);
        dataContext.SubmitChanges();
    }

    public Language getNativeLanguage()
    {
        return dataContext.Languages.Where(r => r.nativeUserLanguage).ToList().ElementAt(0);
    }

    public Int32 getIdByTitle(String title)
    {
        return dataContext.Languages.Where(r => r.title.Equals(title)).ToList().ElementAt(0).Id;
    }
}

