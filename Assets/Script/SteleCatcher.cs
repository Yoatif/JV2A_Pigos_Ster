using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteleCatcher : MonoBehaviour, ITouchable
{
    public SteleInventory steleInventory;
    // Start is called before the first frame update
    void Start()
    {
        steleInventory = FindObjectOfType<SteleInventory>();

    }

    public void CatchingStele()
    {
        steleInventory.AddStele(1);
        Destroy(gameObject);
    }

    public void OnTouchedDown(Vector3 touchPosition)
    {
        CatchingStele();
    }

    public void OnTouchedStay(Vector3 touchPosition)
    {
    }

    public void OnTouchedUp()
    {
    }
}
