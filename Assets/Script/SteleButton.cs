using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SteleButton : MonoBehaviour
{
    [SerializeField]
    private GameObject SteleI;
    [SerializeField]
    private GameObject SteleII;
    [SerializeField]
    private GameObject SteleIII;
    [SerializeField]
    private GameObject SteleIV;
    [SerializeField]
    private GameObject SteleV;
    [SerializeField]
    private GameObject SteleIGB;
    [SerializeField]
    private GameObject SteleIIGB;
    [SerializeField]
    private GameObject SteleIIIGB;
    [SerializeField]
    private GameObject SteleIVGB;
    [SerializeField]
    private GameObject SteleVGB;
    [SerializeField]
    private GameObject ResumeButton;
    [SerializeField]
    private GameObject Return;
    [SerializeField]
    private GameObject InventoryPannel;

    public SteleInventory Inventory;
    public LanguageOption language;



    // Start is called before the first frame update
    void Start()
    {
        Inventory = FindObjectOfType<SteleInventory>();

    }

    // Update is called once per frame
    void Update()
    {
            if (Inventory.GetSteleNumber() == 1)
            {
                SteleIGB.SetActive(true);
                ResumeButton.SetActive(true);
            }
            if (Inventory.GetSteleNumber() == 2)
            {
                SteleIGB.SetActive(true);
                SteleIIGB.SetActive(true);
                ResumeButton.SetActive(true);
            }
            if (Inventory.GetSteleNumber() == 3)
            {
                SteleIGB.SetActive(true);
                SteleIIGB.SetActive(true);
                SteleIIIGB.SetActive(true);
                ResumeButton.SetActive(true);
            }
            if (Inventory.GetSteleNumber() == 4)
            {
                SteleIGB.SetActive(true);
                SteleIIGB.SetActive(true);
                SteleIIIGB.SetActive(true);
                SteleIVGB.SetActive(true);
                ResumeButton.SetActive(true);
            }
            if (Inventory.GetSteleNumber() == 5)
            {
                InventoryPannel.SetActive(true);                
                SteleIGB.SetActive(true);
                SteleIIGB.SetActive(true);
                SteleIIIGB.SetActive(true);
                SteleIVGB.SetActive(true);
                SteleVGB.SetActive(true);
                Return.SetActive(true);
            }
            
            }
    }

