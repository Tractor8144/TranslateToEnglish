using Google.Apis.Auth.OAuth2;
using Google.Apis.Translate.v2;
using Google.Cloud.Translation.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TranslateExtension
{
    internal class TextTranslatorService
    {
        //private readonly string _credentialPath = "F:\\11-Proj\\TranslateExtension\\TranslateExtension\\client_secret_502567034006-7igrnftdb2bt6eqgp1qktbs499v1jade.apps.googleusercontent.com.json";
        public TextTranslatorService()
        {
        }
        public async Task<string> TranslateTextAsync(string query, string targetLanguage = "en")
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return "No text to translate.";
            }
            TranslationClient _translationClient;
            try
            {
                GoogleCredential credential = await GoogleCredential.GetApplicationDefaultAsync();
                _translationClient = await TranslationClient.CreateAsync(credential);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating TranslationClient or getting Google Cloud API credentials: " + ex.Message);
                return "";
            }

            var response = await _translationClient.TranslateTextAsync(query, targetLanguage);
            return response.TranslatedText;
        }
    }
}
