
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliceRock : MonoBehaviour
{
    private Vector2 StartPosition;
    private Vector2 EndPosition;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Handle finger movements based on TouchPhase
            switch (touch.phase)
            {
                //When a touch has first been detected, change the message and record the starting position
                case TouchPhase.Began:
                    // Record initial touch position.
                    StartPosition = touch.position;
                    Debug.Log("start touching");
                    break;

                //Determine if the touch is a moving touch
                case TouchPhase.Moved:
                    // Determine direction by comparing the current touch position with the initial one
                    EndPosition = touch.position - StartPosition;
                    Debug.Log("una cerveza por favor");
                    Destroy(gameObject);
                    
                    break;

                case TouchPhase.Ended:
                    // Report that the touch has ended when it ends
                    Debug.Log("a mi me gusta la paëla !");
                    break;
            }
        }       
    }
}
