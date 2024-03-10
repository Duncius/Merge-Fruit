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
        return gameObject.tag == otherObject.tag;
    }
}
