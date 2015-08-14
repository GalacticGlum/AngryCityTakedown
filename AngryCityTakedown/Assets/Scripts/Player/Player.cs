using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    public int playerHealth;
    public int playerDamage;
    public bool isDead;

    public Player(Player player)
    {
        playerHealth = player.playerHealth;
        playerDamage = player.playerDamage;
        isDead = player.isDead;
    }

}
