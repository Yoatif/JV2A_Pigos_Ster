using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningRock : MonoBehaviour, ITouchable
{
    public int TapCounter;
    public int NumberOfTap;

    public void OnTouchedDown(Vector3 touchPosition)
    {
        TapCounter++;

        if (TapCounter >= NumberOfTap)
        {
            Destroy(gameObject);
        }
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

}
