using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningButton : MonoBehaviour, ITouchable
{
    [SerializeField]
    private GameObject Player;

    public float MaxRockDistance = 5.0f;

    private GameObject NearestRock;
    public void DestroyRock()
    {
        FindNearestRock();
        if (NearestRock != null)
        {
            Destroy(NearestRock); 
        }
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    public void FindNearestRock()
    {
        GameObject[] Rocks = GameObject.FindGameObjectsWithTag("RockWall");
        float distanceMin = Mathf.Infinity;
        NearestRock = null;

        foreach(GameObject rock in Rocks)
        {
            float distance = Vector3.Distance(rock.transform.position, Player.transform.position);

            if(distance < distanceMin && distance < MaxRockDistance)
            {
                distanceMin = distance;
                NearestRock = rock;
            }

        }
    }

    public void OnTouchedDown(Vector3 touchPosition)
    {
        throw new System.NotImplementedException();
    }

    public void OnTouchedStay(Vector3 touchPosition)
    {
        throw new System.NotImplementedException();
    }

    public void OnTouchedUp()
    {
        throw new System.NotImplementedException();
    }
}
