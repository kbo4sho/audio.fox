using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Player Manager class, thinking we would hold player data such as:
    //     - Health / Stamina / Jumps / Loop Combos
    public float health = 100;
    void Update()
    {
        // Probably will want to to split this kind of logic into its own HealthManager script, but lets let it rock for now
        // -- controls the degradation of the health bar over time
       if (health > 0) {
            health -= Time.time * 0.005f;
       }
    }
}
