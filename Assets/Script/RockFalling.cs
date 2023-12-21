using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockFalling : MonoBehaviour
{
    // GameObject to instantiate
    public GameObject rockPrefabs;
    public GameObject stelePrefabs;

    // creating limitation for spawning the rock 
    public Transform limitL;
    public Transform limitR;
    public Transform limitH;

    //creating rules for the spawning interval
    private bool spawnZone = false;
    public GameObject DetectionArea;
    public int rockNumber = 5;
    public float startDelay = 2f;
    public float spawnInterval = 3f;
    //public bool IsEntered = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (spawnZone == false)
        {

            TriggerVibration();
            for (int i = 0; i < rockNumber; i++)
            {
                SpawnRandomRock();
            }
            /*Vector3 spawnPos = new Vector3(Random.Range(limitL.position.x, limitR.position.x), limitH.position.y, limitH.position.y);
            Instantiate(stelePrefabs, spawnPos, Quaternion.identity);*/
            spawnZone = true;
        }
    }

    public void SpawnRandomRock()
    {
        Vector3 spawnPos = new Vector3(Random.Range(limitL.position.x, limitR.position.x), limitH.position.y, limitH.position.y);

        Instantiate(rockPrefabs, spawnPos,
            rockPrefabs.transform.rotation);
    }


    void TriggerVibration()
    {
        
        if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            
            Handheld.Vibrate();
        }
        else
        {
            //Debug.LogWarning("La vibration n'est pas prise en charge sur cette plateforme.");
            
        }
    }
}
