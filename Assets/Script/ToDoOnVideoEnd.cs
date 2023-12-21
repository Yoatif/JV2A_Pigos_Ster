using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class ToDoOnVideoEnd : MonoBehaviour
{
    
    public VideoPlayer player;
    public string NextScene;

    private void Start()
    {
        player.loopPointReached += ToDo;
    }


    public void ToDo(VideoPlayer source)
    {

        //Debug.Log("Change de scene ici");
        SceneManager.LoadScene(NextScene);


    }
}
