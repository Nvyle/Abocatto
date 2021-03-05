using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooldown : MonoBehaviour
{
    public int cooldownTime;
    private int nextFireTIme;

    private void Update() {
        if(time.deltatime > nextFireTIme)
        {
            nextFireTIme = Time.deltatime + cooldownTime;
        }
        
    }
}
