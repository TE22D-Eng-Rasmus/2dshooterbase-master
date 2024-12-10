using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEditor;
using UnityEngine;

public class BoltController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]


    TMP_Text pointsText;

    float speed = 7f;
    int points = 0;

    void Start()
    {

        pointsText.text = points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = Vector2.up;

        transform.Translate(movement * speed * Time.deltaTime);

        if (transform.position.y > Camera.main.orthographicSize + 1)
        {

            GameObject.Find("Ship").GetComponent<ShipController>().UpdatePoints(4);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
            points++;
            pointsText.text = points.ToString();

        }
    }

}