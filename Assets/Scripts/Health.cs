using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    //public float current = 3.0f;
    [HideInInspector]
    public float current;
    public BalanceOfPerson balanceOfPersonSO;

    private void Start()
    {
        current = balanceOfPersonSO.Health;
    }

    public void ApplyDamage(float damage)
    {
        current -= damage;
    }
}
