using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class quit : MonoBehaviour {

    public Button Quit;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    public void QuitScreen()
    {
        Application.Quit ();
        Debug.Log("Appquit");
    }
}
