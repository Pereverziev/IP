using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;

public class ApplicationSettingsService
{

    private DBClassesDataContext dataContext;

    public ApplicationSettingsService(DBClassesDataContext dataContext)
    {
        this.dataContext = dataContext;
    }

    public DateTime getLastVisitTime()
    {
         return Convert.ToDateTime(dataContext.application_settings.Where(s => s.settingName.Equals("lastVisitTime")).First().settingValue);
    }

    public int getLearnedWordsCounter()
    {
        return Convert.ToInt32(dataContext.application_settings.Where(s => s.settingName.Equals("learnedWordsCounter")).First().settingValue);
    }

    public int getMistakeCounter()
    {
        return Convert.ToInt32(dataContext.application_settings.Where(s => s.settingName.Equals("mistakeCounter")).First().settingValue);
    }

    public int getRetryCounter()
    {
        return Convert.ToInt32(dataContext.application_settings.Where(s => s.settingName.Equals("retryCounter")).First().settingValue);
    }

    public void setLastVisitTimeToNow()
    {
        dataContext.application_settings.Single(s => s.settingName.Equals("lastVisitTime")).settingValue = DateTime.Now.ToString();
        dataContext.SubmitChanges();
    }

    public void incrementWordsCounterByOne()
    {
        application_setting wordsCounter = dataContext.application_settings.Single(s => s.settingName.Equals("learnedWordsCounter"));
        wordsCounter.settingValue = Convert.ToString(Int32.Parse(wordsCounter.settingValue) + 1);
        dataContext.SubmitChanges();
    }

    public void incrementMistakeCounterByOne()
    {
        application_setting mistakeCounter = dataContext.application_settings.Single(s => s.settingName.Equals("mistakeCounter"));
        mistakeCounter.settingValue = Convert.ToString(Int32.Parse(mistakeCounter.settingValue) + 1);
        dataContext.SubmitChanges();
    }

    public void setRetryCounter(int newValue)
    {
        dataContext.application_settings.Single(s => s.settingName.Equals("retryCounter")).settingValue = Convert.ToString(newValue);
        dataContext.SubmitChanges();
    }

    public void createMainRecords()
    {
        application_setting retryCounterProperty = new application_setting();
        retryCounterProperty.settingName = "retryCounter";
        retryCounterProperty.settingValue = "3";
        application_setting lastVisitTimeProperty = new application_setting();
        lastVisitTimeProperty.settingName = "lastVisitTime";
        lastVisitTimeProperty.settingValue = DateTime.Now.ToString();
        application_setting learnedWordsCounter = new application_setting();
        learnedWordsCounter.settingName = "learnedWordsCounter";
        learnedWordsCounter.settingValue = "0";
        application_setting mistakeCounter = new application_setting();
        mistakeCounter.settingName = "mistakeCounter";
        mistakeCounter.settingValue = "0";
        dataContext.application_settings.InsertOnSubmit(retryCounterProperty);
        dataContext.application_settings.InsertOnSubmit(lastVisitTimeProperty);
        dataContext.application_settings.InsertOnSubmit(learnedWordsCounter);
        dataContext.application_settings.InsertOnSubmit(mistakeCounter);
        dataContext.SubmitChanges();
    }
}

