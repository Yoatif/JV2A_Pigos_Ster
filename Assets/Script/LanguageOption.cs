using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageOption : MonoBehaviour, ITouchable
{
    public bool French;
    public bool English;
    public void OnTouchedDown(Vector3 touchPosition)
    {
    }

    public void OnTouchedStay(Vector3 touchPosition)
    {
    }

    public void OnTouchedUp()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        French = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetFrenchLanguage(bool French, bool English)
    {
        French = true;
        English = false;
        
    }
    public bool GetFrenchLanguage()
    {
        return French;
    }
    public void SetEnglishLanguage(bool English, bool French)
    {
        English = true;
        French = false;
    }
    public bool GetEnglishLanguage()
    {
        return English;
    }
}
