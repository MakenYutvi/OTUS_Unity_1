using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "BalanceOfPerson")]
public class BalanceOfPerson : ScriptableObject
{
    [SerializeField]
    private float health;
    [SerializeField]
    private float damage;

    public float Health
    {
        get
        {
            return health;
        }

    }

    public float Damage
    {
        get
        {
            return damage;
        }
    }
}



