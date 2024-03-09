using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    // Set the name of the cube or tag it appropriately in the Unity Editor
    public string cubeTagName = "Cube";

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object has the specified tag or name
        if (collision.gameObject.CompareTag(cubeTagName))
        {
            // Restart the current level
            RestartLevel();
        }
    }

    private void RestartLevel()
    {
        // Get the current scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Reload the current scene
        SceneManager.LoadScene(currentSceneIndex);
    }
}