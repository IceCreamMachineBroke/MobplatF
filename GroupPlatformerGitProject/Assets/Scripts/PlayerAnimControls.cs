using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimControls : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        if (Mathf.Abs(x) > Mathf.Abs(y))
        {
            GetComponent<Animator>().SetFloat("X", x);
            GetComponent<Animator>().SetFloat("Y", y);
        } else if (Mathf.Abs(y) > Mathf.Abs(x))
        {
            GetComponent<Animator>().SetFloat("X", x);
            GetComponent<Animator>().SetFloat("Y", y);
        }
        if (x == 0 && y == 0)
        {
            GetComponent<Animator>().SetBool("Idle", true);
            GetComponent<Animator>().SetBool("Jumping", false);

        }
        else
        {
            GetComponent<Animator>().SetBool("Idle", false);
            
        }
        /*if(x != 0)
        {
            GetComponent<Animator>().SetFloat("X", x);
            GetComponent<Animator>().SetBool("Idle", false);
        }
        else if(y != 0)
        {
            GetComponent<Animator>().SetFloat("Y", y);
            GetComponent<Animator>().SetBool("Idle", false);
        }
        else
        {
            GetComponent<Animator>().SetFloat("X", x);
            GetComponent<Animator>().SetFloat("Y", 0);
        }*/
        
	}
}
