using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject prefabExplosion;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        if (collision.tag == "Player")
        {
            Destroy(this.gameObject);
            Instantiate<GameObject>(prefabExplosion, transform.position, Quaternion.identity);
            LivesController lives = GameObject.FindObjectOfType<LivesController>();
            lives.DeleteHeart();
        }
    }

}
