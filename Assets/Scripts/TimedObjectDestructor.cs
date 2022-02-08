using UnityEngine;
using System.Collections;

public class TimedObjectDestructor : MonoBehaviour {

	public float timeOut = 1.0f;
	public bool detachChildren = false;

	// Use this for initialization
	void Awake () {
		// invote the DestroyNow funtion to run after timeOut seconds
		Invoke ("DestroyNow", timeOut);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void DestroyNow ()
	{
		if (detachChildren) { // detach the children before destroying if specified
			transform.DetachChildren ();
		}
		//DestroyObject (gameObject);
		Destroy(gameObject);
		// Removes this script instance from the game object   Destroy(this);
		//Removes the rigidbody from the game object           Destroy(GetComponent<Rigidbody>());
		//// Kills the game object in 5 seconds after loading the object                 Destroy(gameObject, 5);
		/* // When the user presses Ctrl, it will remove the
    // BoxCollider component from the game object
    void Update()
    {
        if (Input.GetButton("Fire1") && GetComponent<BoxCollider>())
        {
            Destroy(GetComponent<BoxCollider>());
        }
    }*/

	}
}
