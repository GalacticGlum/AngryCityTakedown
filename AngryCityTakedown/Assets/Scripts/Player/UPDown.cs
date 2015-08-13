using UnityEngine;
using System.Collections;

public class UPDown : MonoBehaviour
{
    public bool goingUp = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.1f, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow) && goingUp == true)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.1f, 0);
        }
    }
}
