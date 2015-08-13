using UnityEngine;
using System.Collections;

[System.Serializable]
public class Enemy {

    public string enemyName;
    public int enemyHealth;
    public int enemyDamage;
    public EnemyType enemyType;
    public bool isDead;
    public int enemyID;

    public enum EnemyType
    {
        NORMAL,
        HARD,
        BOSS
    }

    public Enemy(Enemy enemy)
    {
        enemyName = enemy.enemyName;
        enemyHealth = enemy.enemyHealth;
        enemyDamage = enemy.enemyDamage;
        enemyType = enemy.enemyType;
        enemyID = enemy.enemyID;
        isDead = enemy.isDead;
    }

    public Enemy()
    {
    }
}
