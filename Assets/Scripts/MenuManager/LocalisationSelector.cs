using System.Collections;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class LocalisationSelector : MonoBehaviour
{
    private bool active = false;

    
    public void ChangeLocale(int localeID)
    {
        if (active)
            return;
        StartCoroutine(SetLocale(localeID));
    }

    IEnumerator SetLocale(int _localeID)
    {
        active = true;
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_localeID];
        PlayerPrefs.SetInt("LocalKey", _localeID);
        active = false;
    }
}
