using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Test : MonoBehaviour
{
    public Enemy enemy;
    public Player player;
    public EnemyManger enemyManager;
    
	// Use this for initialization
	void Start ()
    {
        enemyManager = GameObject.FindGameObjectWithTag("EnemyManger").GetComponent<EnemyManger>();
        player = GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
