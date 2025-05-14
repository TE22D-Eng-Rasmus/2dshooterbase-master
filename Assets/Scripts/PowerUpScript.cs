using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{

  float speed = 4;
  // Start is called before the first frame update
  void Start()
  {
    Vector2 position = new();
    position.y = Camera.main.orthographicSize + 1;
    position.x = Random.Range(-5f, 5f);
    transform.position = position;
  }
  // Update is called once per frame
  void Update()
  {
    Vector2 movement = Vector2.down;
    transform.Translate(movement * speed * Time.deltaTime);

    if (transform.position.y < -Camera.main.orthographicSize - 1)
    {

      Destroy(this.gameObject);
    }
  }
  private void OnTriggerEnter2D(Collider2D other)
  {

    if (other.gameObject.tag == "Player")
    {
      Destroy(this.gameObject);
      // other.GetComponent<ShipController>().

    }

    else if (other.gameObject.tag == "Player2")
    {
      Destroy(this.gameObject);

    }

    else if (other.gameObject.tag == "Player3")
    {
      Destroy(this.gameObject);

    }

  }
}
