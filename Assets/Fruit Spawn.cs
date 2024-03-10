using UnityEngine;

public class FruitSpawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnDelay = 0.0f;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && timer >= spawnDelay)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0;

            mousePosition.y = 4;

            Instantiate(objectToSpawn, mousePosition, Quaternion.identity);

            timer = 0f;
        }
    }
}
