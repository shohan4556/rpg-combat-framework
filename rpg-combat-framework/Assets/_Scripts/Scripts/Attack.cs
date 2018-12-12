using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack {
    private readonly int damage;
    private readonly bool critial;

    public Attack(int damage, bool critial){
        this.damage = damage;
        this.critial = critial;
    }

    public int Damage(){
        return this.damage;
    }

    public bool IsCritical(){
        return this.critial;
    }
    
}
