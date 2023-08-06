using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBoxReset : MonoBehaviour
{

    public ButtonManager death;
    bool isDead = false;
    void Update()
    {
        charDeath();
    }
    public void charDeath()
    {
        if(isDead)
        {
            death.resetScene();
            isDead = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hey u dead now");
            isDead = true;
        }
    }
}
