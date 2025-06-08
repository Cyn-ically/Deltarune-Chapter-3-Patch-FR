
EnsureDataLoaded();

ScriptMessage("Appuyez sur continuer pour commencer la traduction du jeu.");
Dictionary<string, string> translations = new Dictionary<string, string>();
// REWORK

for (int i = 0; i < Data.Strings.Count; i++)
{
string original = Data.Strings[i].Content;
if (translations.ContainsKey(original))
{
Data.Strings[i].Content = translations[original];
}
}

ScriptMessage("Merci d'avoir utilisé le script de traduction !\n\nSi vous avez des suggestions ou des corrections, n'hésitez pas à les partager ou a me suivre ! sur \nhttps://github.com/Cyn-ically/Deltarune-Chapter-3-Patch-FR\nou\nhttps://www.youtube.com/@Cyn-ically/videos\n\nBon jeu !");
