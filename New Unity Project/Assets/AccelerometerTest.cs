using UnityEngine;
using System.Collections;

public class AccelerometerTest : MonoBehaviour {
    //RGB
    float red = 0.5f;
    float blue = 0.5f;
    float green = 0.5f;

    
    
    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Close on 'back'
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
        //do something

        //red
        if (Input.acceleration[0] > 0)
        {
            this.red += 0.01f;
        }

        if (Input.acceleration[0] < 0)
        {
            this.red -= 0.01f;
        }

        /*
        //blue
        if (Input.acceleration[1] > 0)
        {
            this.blue += 0.01f;
        }

        if (Input.acceleration[1] < 0)
        {
            this.blue -= 0.01f;
        }
       
       
        //green
        if (Input.acceleration[2] > 0)
        {
            this.green += 0.01f;
        }

        if (Input.acceleration[2] < 0)
        {
            this.green -= 0.01f;
        }
        */
        gameObject.GetComponent<Renderer>().material.color = new Color(this.red, this.green, this.blue);
    }
}


