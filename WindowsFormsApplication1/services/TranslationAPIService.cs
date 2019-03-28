using Google.Cloud.Translation.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TranslationAPIService
{
    private TranslationClient client;

    public TranslationAPIService(TranslationClient client)
    {
        this.client = client;
    }

    public String translateWord(String word, String toLanguageShortTitle)
    {
        return client.TranslateText(word, toLanguageShortTitle).TranslatedText;
    }
}

