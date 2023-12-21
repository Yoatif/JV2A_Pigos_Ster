using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class FollowingPlayer : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    private Vector3 offset;

    private float Speed = 0.125f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Vector3 desiredPosition = player.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, Speed);
            transform.position = smoothedPosition;
        }

    }
}
