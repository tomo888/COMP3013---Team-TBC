using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int HP = 100;
    public Slider healthBar;
    // Start is called before the first frame update
    public void TakeDamage()
    {
        HP -= 1;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = HP;

        if (HP <= 0) {
            Destroy(gameObject);
        }
    }
}
