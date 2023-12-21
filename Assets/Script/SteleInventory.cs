using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteleInventory : MonoBehaviour
{
    public int NumberOfCollectedStele = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddStele(int plus)
    {
        NumberOfCollectedStele += plus;
    }

    public int GetSteleNumber()
    {
        return NumberOfCollectedStele;
    }
}
