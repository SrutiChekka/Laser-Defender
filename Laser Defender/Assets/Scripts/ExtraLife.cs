using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLife : MonoBehaviour
{
    [SerializeField] int extraHealth = 100;

    private void OnTriggerEnter2D()
    {
        FindObjectOfType<Player>().LifeUp(extraHealth);
        Destroy(gameObject);
    }
}
