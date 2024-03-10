using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col)
    {
        if (!SameType(col.gameObject))
            return;

        else if(col.gameObject.tag == "Fruit 1")
        {
            ScoreManager.instance.AddPoint();
        }
        else if(col.gameObject.tag == "Fruit 2")
        {
            ScoreManager.instance.Add2Points();
        }
        else if (col.gameObject.tag == "Fruit 3")
        {
            ScoreManager.instance.Add3Points();
        }
        else if (col.gameObject.tag == "Fruit 4")
        {
            ScoreManager.instance.Add4Points();
        }
        else if (col.gameObject.tag == "Fruit 5")
        {
            ScoreManager.instance.Add5Points();
        }
        else if (col.gameObject.tag == "Fruit 6")
        {
            ScoreManager.instance.Add6Points();
        }
    }

    bool SameType(GameObject otherObject)
    {
        return gameObject.tag == otherObject.tag;
    }
}
