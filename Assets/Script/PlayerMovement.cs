using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // create the animation
    public Animator walkAnimation;
    public Animator MiningAnimation;
    public float walkSpeed = 1f;
    public bool ActiveWalk = true;

    //life sprite
    public int life = 3;
    

    //rock falling detector
    public GameObject rock;
    public GameObject Stele;


    public SteleInventory steleInventory;
    public WallDetection Detection;

    // Start is called before the first frame update
    void Start()
    {
        walkAnimation = GetComponent<Animator>();
        steleInventory = FindObjectOfType <SteleInventory>();
        
    }

    // Update is called once per frame
    void Update()
    {

        /*if (ActiveWalk == true && Detection.WallDetector() == false)
        {
            transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);
        }

        if (ActiveWalk == false)
        {
            walkAnimation.SetBool("Marche", false); // modify the bool to sto 

        }*/

        transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);


    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("FallingRock"))
        {
            Debug.Log("touché");
            life--;
        }
    }

    public int LifeChanger(int life)
    {
        return life;
    }
}   

