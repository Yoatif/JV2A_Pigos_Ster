using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ReplaceLifeBar : MonoBehaviour
{
    public Slider slider;
    public Image[] colorizedImages;
    public PlayerMovement ChangingValue;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void LifeChanger()
    {
        var hp = ChangingValue.life / 3f;
        slider.value = hp;
        foreach (var image in colorizedImages)
        {
            image.color = Color.Lerp(Color.red, Color.green, hp);
        }

    }
}
