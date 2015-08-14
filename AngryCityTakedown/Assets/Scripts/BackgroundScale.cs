using UnityEngine;
using System.Collections;

public class BackgroundScale : MonoBehaviour
{
    Camera camera;
    public SpriteRenderer spriteRenderer;
    public float screenHeight;
    public float screenWidth;

	// Use this for initialization
	void Start ()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }
	// Update is called once per frame
	void Update ()
    {
        screenHeight = camera.orthographicSize * 2;
        screenWidth = screenHeight / Screen.height * Screen.width;

        transform.localScale = new Vector3(screenWidth / spriteRenderer.sprite.bounds.size.x, screenHeight / spriteRenderer.sprite.bounds.size.y, 1);

	}
}
