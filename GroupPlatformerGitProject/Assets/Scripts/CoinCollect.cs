using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinCollect : MonoBehaviour {

    public int coinCount = 0;
    public Text coinText;
    public AudioClip soundToPlay;
    public GameObject door;
    void Start()
    {
        coinText.GetComponent<Text>().text = "Coins: " + coinCount;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Camera.main.GetComponent<AudioSource>().PlayOneShot(soundToPlay);
            coinCount++;
            Destroy(collision.gameObject);
            coinText.GetComponent<Text>().text = "Coins: " + coinCount;
            /* if (collision.gameObject.tag == "Ligma" && coinCount == 50)
             {
                 SceneManager.LoadScene("Game2");
             }*/
        }
         
    {
            if (collision.gameObject.tag == "Ligma" && coinCount >= 50)
     door.SetActive(false);
    }
}
 
    
   
            
    
     
}
