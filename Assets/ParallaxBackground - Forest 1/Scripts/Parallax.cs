 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private Vector2 parallaxEffect;
    private Transform cameraTransform;
    private Vector3 lastCameraPosition;
    private float textureSizeX;


    void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        Texture2D texture = sprite.texture;
        textureSizeX = texture.width / sprite.pixelsPerUnit;
    }

    void LateUpdate() 
    {
        Vector3 movementDelta = cameraTransform.position - lastCameraPosition;
        transform.position += new Vector3 (movementDelta.x * parallaxEffect.x, movementDelta.y * parallaxEffect.y);
        lastCameraPosition = cameraTransform.position;

        if (Mathf.Abs(cameraTransform.position.x - transform.position.x) >= textureSizeX) 
        {
            float offsetPostitionX = (cameraTransform.position.x - transform.position.x) % textureSizeX;
            transform.position = new Vector3(cameraTransform.position.x + offsetPostitionX, transform.position.y);
        }

    }
}
