using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mining : MonoBehaviour, ITouchable
{
    private int TapCounter;

    [SerializeField]
    private int NumberOfTap;

    public void RockDestruction()
    {
        Destroy(gameObject);
    }

    public void OnTouchedDown(Vector3 touchPosition)
    {
        TapCounter++;
        Debug.Log(TapCounter);

        if (TapCounter >= NumberOfTap)
        {
            Debug.Log("détruit");
            RockDestruction();
        }
    }

    public void OnTouchedStay(Vector3 touchPosition)
    {
    }

    public void OnTouchedUp()
    {
    }
}
