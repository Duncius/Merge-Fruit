using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
