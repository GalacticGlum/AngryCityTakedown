using UnityEngine;
using System.Collections;

public class BottomBorder : MonoBehaviour
{
    BackgroundScale backgroundScale;
    BoxCollider2D bxCollider2d;
    public GameObject bg;
    public float offSet = 0.1f;

	// Use this for initialization
	void Start ()
    {
        bg = GameObject.FindGameObjectWithTag("BG");
        backgroundScale = GameObject.FindGameObjectWithTag("BG").GetComponent<BackgroundScale>();
        bxCollider2d = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float y = (backgroundScale.screenHeight / 2);
        y = -y;
        bxCollider2d.transform.localScale = new Vector3(backgroundScale.screenWidth / backgroundScale.spriteRenderer.sprite.bounds.size.x, bxCollider2d.transform.localScale.y, 1);
        transform.position = new Vector3(backgroundScale.spriteRenderer.transform.position.x / 2, y - (offSet), 0);
	}
}
