using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replacement : MonoBehaviour, ITouchable
{
    public Sprite ReplacementSprite;
    public Sprite ActualSprite;
    public GameObject previousRock;

    private int TapCounter = 0;
    [SerializeField]
    private int NumberOfTap;

    public void OnTouchedDown(Vector3 touchPosition)
    {
        TapCounter++;
        Debug.Log(TapCounter);

        if (TapCounter >= NumberOfTap)
        {
            
            RockDestruction();
        }
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
        GetComponent<SpriteRenderer>().sprite = ActualSprite;
    }

    // Update is called once per frame
    void Update()
    {
        if(previousRock == null)
        {
            GetComponent<SpriteRenderer>().sprite = ReplacementSprite;
        }        
    }

    public void RockDestruction()
    {
        Destroy(gameObject);
    }
}
