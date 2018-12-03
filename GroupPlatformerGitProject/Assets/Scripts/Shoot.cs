using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject prefab;
    public GameObject Mega;
    public float shootSpeed = 10;
    float timer = 0;
    public float fireRate = 0.3f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetButton("Fire1") && timer > fireRate)
        {
            timer = 0;
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            mousePosition.z = 0;
            Vector3 shootDir = mousePosition - transform.position;
            shootDir.Normalize();
            //destination - start position
            GameObject bullet = (GameObject)Instantiate(prefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir * shootSpeed;
            Destroy(bullet, 0.5f);

        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "bulletDamageUpgrade" && timer > fireRate && Input.GetButton("Fire1"))
        {
            timer = 0;
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            mousePosition.z = 0;
            Vector3 shootDir = mousePosition - transform.position;
            shootDir.Normalize();
            //destination - start position
            GameObject MegaBullet = (GameObject)Instantiate(Mega, transform.position, Quaternion.identity);
            MegaBullet.GetComponent<Rigidbody2D>().velocity = shootDir * shootSpeed;
            Destroy(MegaBullet, 0.5f);

        }
        if (collision.gameObject.name == "fireRateUpgrade")
        {
            fireRate = 0;
        }
    }
}