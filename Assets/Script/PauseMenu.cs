using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour, ITouchable
{
    private bool isPaused = true;

    [SerializeField]
    private GameObject ResumeButton;

    [SerializeField]
    private GameObject InGameButton;

    [SerializeField]
    private GameObject InventoryPanel;
    public void OnTouchedDown(Vector3 touchPosition)
    {
        ResumeGame();
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
        if (isPaused == true)
        {
            ResumeButton.SetActive(true);
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1.0f;
        isPaused = false;

        if (isPaused == false)
        {
            ResumeButton.SetActive(false);
            InventoryPanel.SetActive(false);
            InGameButton.SetActive(true);
        }
    }
}
