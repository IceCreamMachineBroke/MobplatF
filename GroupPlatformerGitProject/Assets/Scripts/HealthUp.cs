using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUp : MonoBehaviour
{
    public int healthBoost;
    private PlayerController player;
    // Use this for initialization
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }
    void Update()
    {

    }

    public void HealthUp2()
    {
        player.health += healthBoost;
        Destroy(gameObject);
    }
    

}