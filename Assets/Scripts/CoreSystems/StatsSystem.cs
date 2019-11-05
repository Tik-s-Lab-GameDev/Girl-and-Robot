﻿using UnityEngine;

public class StatsSystem : MonoBehaviour
{
    // Start is called before the first frame update

    public float maxHp = 100f;
    private float currHp;
    public float dmg = 25f;
    public float addDmg;
    public bool isDie = false;

    void Start()
    {
        currHp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        shouldDie();
    }

    public void shouldDie()
    {
        if (currHp <= 0) Die();
    }

    public void Die()
    {
        isDie = true;
        Destroy(this.gameObject);
    }

    public void SetAddDmg(float addDmg)
    {
        this.addDmg = addDmg;
    }

    public void TakeDamage(float dmg)
    {
        if (currHp - dmg <= 0) Die();
        else currHp -= dmg;
    }

    public float GiveDamage()
    {
        return dmg + addDmg;
    }
}
