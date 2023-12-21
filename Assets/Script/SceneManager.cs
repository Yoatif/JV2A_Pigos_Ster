using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour, ITouchable
{
    public string sceneToLoad; // Le nom de la sc�ne � charger


    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void OnTouchedDown(Vector3 touchPosition)
    {
        LoadScene();
    }

    public void OnTouchedStay(Vector3 touchPosition)
    {
    }

    public void OnTouchedUp()
    {
    }
}
