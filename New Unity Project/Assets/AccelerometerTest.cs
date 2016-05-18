using UnityEngine;
using System.Collections;

public class AccelerometerTest : MonoBehaviour {
    //RGB
    float red = 0.5f;
    float blue = 0.5f;
    float green = 0.5f;
	public float speed = 3f;
	public Color altColor = Color.white;
	public Renderer rend;


	void Example() {
		altColor.g = 1f;
		altColor.r = 0f;
		altColor.b = 0f;
		altColor.a = 0f;
	}
    // Use this for initialization
    void Start () {
		Example ();
		gameObject.GetComponent<Renderer> ().material.color = altColor;
    }

    // Update is called once per frame
    void Update()
    {
        //Close on 'back'
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
        //do something


        //red
        if (Input.acceleration.x > 0)
        {
			altColor.r += 0.01f;
			gameObject.GetComponent<Renderer> ().material.color = altColor;
        }

        if (Input.acceleration.x < 0 && altColor.r > 0.3f)
        {
			altColor.r -= 0.01f;
			gameObject.GetComponent<Renderer> ().material.color = altColor;
        }

       
        //blue
        if (Input.acceleration.y > 0)
        {
			altColor.b += 0.01f;
			gameObject.GetComponent<Renderer> ().material.color = altColor;
        }

        if (Input.acceleration.y < 0 && altColor.b > 0.3f)
        {
			altColor.b -= 0.01f;
			gameObject.GetComponent<Renderer> ().material.color = altColor;
		}
       
       
        //green
		if (Input.acceleration.z > 0)
        {
			altColor.g += 0.01f;
			gameObject.GetComponent<Renderer> ().material.color = altColor;
        }

        if (Input.acceleration.z < 0 && altColor.g > 0.3f)
        {
			altColor.g -= 0.01f;
			gameObject.GetComponent<Renderer> ().material.color = altColor;
        }
        

    }
}


