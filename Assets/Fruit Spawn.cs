using UnityEngine;

public class FruitSpawn : MonoBehaviour
{
    public GameObject objectToSpawn;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0;

            mousePosition.y = 4;

            Instantiate(objectToSpawn, mousePosition, Quaternion.identity);
        }
    }
}
