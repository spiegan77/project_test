using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("Friendly Deal");
                break;
            case "Obstacle":
                Debug.Log("This is an Obstacle");
                break;
            case "Finish":
                Debug.Log("I'm finish. like the crackers");
                break;
            default:
                Debug.Log("You sploded");
                ReloadScene();
                break;

        }
    }

    private static void ReloadScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
