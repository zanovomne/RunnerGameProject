using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinScreen : MonoBehaviour
{
    // Set the name of the cube or tag it appropriately in the Unity Editor
    public string winTagName = "Win";

    // Reference to the TextMeshPro object for displaying "You Win" text
    public TextMeshProUGUI winText;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the trigger is the cube with the specified tag or name
        if (other.CompareTag(winTagName))
        {
            // Display "You Win" text
            if (winText != null)
            {
                winText.text = "You Win!";
            }

            // You can add additional logic or actions here if needed

            // For example, you might want to wait a few seconds and then restart the level
            Invoke("RestartLevel", 3f);
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
