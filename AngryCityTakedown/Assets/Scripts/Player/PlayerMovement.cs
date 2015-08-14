using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public Player player;
    Rigidbody2D rigidbody2d;

	// Use this for initialization
	void Start ()
    {
	    rigidbody2d = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Player>();
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody2d.transform.position += Vector3.up * player.playerSpeed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody2d.transform.position += Vector3.right * player.playerSpeed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody2d.transform.position += Vector3.left * player.playerSpeed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody2d.transform.position += Vector3.down * player.playerSpeed;
        }
    }
}
