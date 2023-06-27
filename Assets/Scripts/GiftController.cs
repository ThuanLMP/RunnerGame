using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        if (collision.tag == "Player")
        {
            LivesController lives = GameObject.FindObjectOfType<LivesController>();
            lives.AddHeart();
        }
    }
}
