using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HP : MonoBehaviour {

    public int health = 20;
    public Text healthText;
    public Slider healthBar;
    float timer = 0;
    public float HealthRegen = 0.3f;
    public int lives = 10;

    void Start()
    {
        healthText.GetComponent<Text>().text = "Health: " + health;
        healthBar.GetComponent<Slider>().value = health;
        //PlayerPrefs.SetInt("Lives", lives);
        lives = PlayerPrefs.GetInt("Lives");
    }
   
    void OnCollisionEnter2D(Collision2D collision)
    {
        healthText.GetComponent<Text>().text = "Health: " + health;
        healthBar.GetComponent<Slider>().value = health;
        timer += Time.deltaTime;
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
            
        }
        if (collision.gameObject.tag == "HealthPotion")
        {
            health += 5;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Enemy1")
        {
            health -= 2;
        }
        if (collision.gameObject.tag == "Boss")
        {
            health -= 20;
        }
         
        if (health <= 0)
        {
            PlayerPrefs.SetInt("Lives", lives = 1);
            //reload the level
            SceneManager.LoadScene("LoseScreen");

        }
        
       



    
    }
    void OnEnterTrigger2D(Collider2D collision)
    {
        //this is for the refill of health in an HP zone
    }

    public void HealthUp()
    {
        health += 1;
        Destroy(gameObject);    }

}
