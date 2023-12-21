using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PauPanel : MonoBehaviour, ITouchable
{
    private bool isPaused = false;

    [SerializeField]
    private GameObject PausePanel;

    [SerializeField]
    private GameObject InGameButton;

    [SerializeField]
    private GameObject InventoryPanel;
    [SerializeField]
    private GameObject ResumeButton;

    public void OnTouchedDown(Vector3 touchPosition)
    {
        PauseGame();
        SteleInventory();

    }

    public void OnTouchedStay(Vector3 touchPosition)
    {
        throw new System.NotImplementedException();
    }

    public void OnTouchedUp()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        if(isPaused == false)
        {
            PausePanel.SetActive(false);
            InGameButton.SetActive(true);
            InventoryPanel.SetActive(false);
        }
        
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        isPaused = true;

        if(isPaused == true)
        {
            PausePanel.SetActive(true);
            InGameButton.SetActive(false);
            InventoryPanel.SetActive(false);
        }

    }

    public void SteleInventory()
    {
        Time.timeScale = 0f;
        isPaused = true;

        if(isPaused == true)
        {
            InGameButton.SetActive(false);
            InventoryPanel.SetActive(true);
            PausePanel.SetActive(false);
            ResumeButton.SetActive(true);
        }
    }


}


