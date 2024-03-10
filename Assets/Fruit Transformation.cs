using UnityEngine;

public class FruitTransformation : MonoBehaviour
{
    public bool doNothing;
    public GameObject spawnPrefab;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (doNothing || !IsSameType(col.gameObject))
            return;

        col.gameObject.GetComponent<FruitTransformation>().doNothing = true;
        Destroy(col.gameObject);

        Instantiate(spawnPrefab, transform.position, transform.rotation);

        Destroy(gameObject);
    }

    bool IsSameType(GameObject otherObject)
    {
        // You can compare tags or names here.
        // For example, comparing tags:
        return gameObject.tag == otherObject.tag;
        // Or comparing names:
        // return gameObject.name == otherObject.name;
    }
}
