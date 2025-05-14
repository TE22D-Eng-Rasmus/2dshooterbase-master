using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using System.Diagnostics.CodeAnalysis;
using TMPro;

public class ShipController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]

    float speed = 0.02f;

    [SerializeField]

    GameObject Boltprefab;

    [SerializeField]

    Transform GunPosition;

    float timeBetweenShots = 0.2f;
    float timeSinceLastShot = 0;

    [SerializeField]
    static public int maxHealth = 5;
    static public int currentHealth;

    [SerializeField]
    Slider hpBar;

    [SerializeField]
    Text UpdatePoint;


bool PowerUpActive = false;
float PowerTime = 0f;



    void Start()
    {
        currentHealth = maxHealth;
        hpBar.maxValue = maxHealth;
        hpBar.value = currentHealth;


        




    }

    // Update is called once per frame
    void Update()
    {

        float xInput = Input.GetAxisRaw("Horizontal");
        print(xInput);

        float yInput = Input.GetAxisRaw("Vertical");
        print(yInput);

        Vector2 movement = new Vector2(xInput, yInput) * speed * Time.deltaTime;

        // Vector2 movement2 = new Vector2(0, 1) * speed * yInput;

        transform.Translate(movement);

        timeSinceLastShot += Time.deltaTime;

        if (Input.GetAxisRaw("Fire1") > 0 && timeSinceLastShot > timeBetweenShots)
        {
            timeSinceLastShot = 0;
            Instantiate(Boltprefab, GunPosition.position, Quaternion.identity);
        }

        if (button2.Button2 == true)
        {

            

        }

       if (PowerUpActive == true){
         PowerTime += Time.deltaTime;
         if (PowerTime >5f){
            PowerTime = 0;
            PowerUpActive = false;
            timeBetweenShots = 0.2f;
         }
       }

    }

    public void UpdatePoints(int p)
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        AddHealth(other);
        if (other.tag == "Enemy")
        {
            currentHealth--;
            hpBar.value = currentHealth;
            if (currentHealth <= 0)
            {
                SceneManager.LoadScene(3);

            }

        }
    }

    public void AddHealth(Collider2D other)
    {

        if (other.tag == "Health")
        {
            currentHealth++;
            hpBar.value = currentHealth;
            if (currentHealth > 5)
            {
                currentHealth = 5;
                hpBar.value = currentHealth;
            }
        }

    }


    public void PowerShoot(Collider2D other)
    {

        if (other.tag == "PowerUp")
        {
            while (PowerTime>= 5f){
            timeBetweenShots = 0.01f;
             PowerUpActive = true;
        }
        

    }

    }

}
