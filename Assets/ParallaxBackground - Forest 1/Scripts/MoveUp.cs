using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{

   public float moveSpeed = 5f;

    public void MoveUp1()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
    }

    public void MoveDown1()
    {
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
    }
}
