using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnButtonClick : MonoBehaviour
{
    Button button;
    Image image;

    [SerializeField]
    Sprite spriteIdle;

    [SerializeField]
    Sprite spritePressed;

    [SerializeField]
    Mario_controlar mario;

    int lastButton;

    float timeToRun;
    void Start()
    {
        image = GetComponent<Image>();
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    private void Asadse()
    {
        
    }

    

    
    public void ABUtton( bool state)
    {
        mario.aPressed = state;

    }
    public void UpButton(bool button)
    {
        mario.Axis += button ? -1 : 1;
        int intButton = button ? 1 : -1;
        if (intButton == lastButton)
        {
            timeToRun = Time.time + 1f;
        }
        else if (Time.time > timeToRun)
        {
            lastButton = 0;
        }
        Debug.Log("not run");
        mario.running = false;
    }

    public void DownButton(bool button)
    {
        if (Time.time > timeToRun)
        {
            lastButton = 0;
        }
        mario.Axis += button ? 1 : -1;
        int intButton = button ? 1 : -1;
        Debug.Log((intButton,lastButton));
        if(intButton == lastButton && Time.time <= timeToRun)
        {
            Debug.Log("run");
            mario.running = true;
        }
        else
        {
            lastButton = intButton;
        }
    }
    



}
