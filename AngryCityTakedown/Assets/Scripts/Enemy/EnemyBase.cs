using UnityEngine;
using System.Collections;

[System.Serializable]
public class EnemyBase
{
    public int health;
    public int damage;
    public EnemyType enemyType;

    public enum EnemyType
    {
       NORMAL,
       HARD,
       BOSS
    }

    public EnemyBase(EnemyBase enemy)
    {
        health = enemy.health;
        damage = enemy.damage;
        enemyType = enemy.enemyType;
    }
}
