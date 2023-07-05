using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LivesController : MonoBehaviour
{
    public GameObject heartPrefab; // Prefab của hình trái tim
    public Canvas targetCanvas; // Canvas để đặt trái tim vào
    public int numberOfHearts = 3;
    private List<GameObject> listHeartObjects;
    public float distanceBetweenHearts = 100f; // Khoảng cách ngang giữa các trái tim
    void Start()
    {
        listHeartObjects = new List<GameObject>();
        InitializeObjectPool();
    }
    void InitializeObjectPool()
    {
        // Tạo và khởi tạo đối tượng trái tim trong Object Pool
        for (int i = 0; i < 3; i++)
        {
            float x = 220f + i * distanceBetweenHearts;
            Vector3 position = new Vector3(x, 155f, 0f);
            GameObject heartObject = Instantiate(heartPrefab, targetCanvas.transform);
            heartObject.transform.localPosition = position;
            heartObject.SetActive(true);
            listHeartObjects.Add(heartObject);
        }
    }

    public void DeleteHeart()
    {
        numberOfHearts = numberOfHearts - 1;
        if (numberOfHearts == 0)
        {
            SceneManager.LoadScene(2);
        }
        listHeartObjects[numberOfHearts].SetActive(false);
    }
    public void AddHeart()
    {
        if (numberOfHearts < 3)
        {
            numberOfHearts = numberOfHearts + 1;
        }

        listHeartObjects[numberOfHearts - 1].SetActive(true);

    }
}
