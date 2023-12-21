using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ReadingStele : MonoBehaviour, ITouchable
{
    // define the text to print for the stele
    

    public GameObject StelePicture;
    public GameObject Description;

    public GameObject StelePicture1;
    public GameObject Description1;

    public GameObject StelePicture2;
    public GameObject Description2;

    public GameObject StelePicture3;
    public GameObject Description3;

    public GameObject StelePicture4;
    public GameObject Description4;

    public LanguageOption language;
    
    public void OnTouchedDown(Vector3 touchPosition)
    {
        StelePrinter();
    }

    public void OnTouchedStay(Vector3 touchPosition)
    {
    }

    public void OnTouchedUp()
    {
    }

    void Start()
    {
        StelePicture.SetActive(false);
        Description.SetActive(false);
        Description1.SetActive(false);
        StelePicture1.SetActive(false);
        Description2.SetActive(false);
        StelePicture2.SetActive(false);
        Description3.SetActive(false);
        StelePicture3.SetActive(false);
        Description4.SetActive(false);
        StelePicture4.SetActive(false);


    }


    public void StelePrinter()
    {
        StelePicture.SetActive(true);
        Description.SetActive(true) ;
        Description1.SetActive(false);
        StelePicture1.SetActive(false);
        Description2.SetActive(false);
        StelePicture2.SetActive(false);
        Description3.SetActive(false);
        StelePicture3.SetActive(false);
        Description4.SetActive(false);
        StelePicture4.SetActive(false);
    }
}
