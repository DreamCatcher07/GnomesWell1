using UnityEngine;
using UnityEngine.SceneManagement;

// Manages the main menu.
public class MainMenu : MonoBehaviour
{
    public string sceneToLoad;               // Name of the scene to load
    public RectTransform loadingOverlay;     // UI component for "Loading..."
    AsyncOperation sceneLoadingOperation;    // Background scene loading

    void Start()
    {
        // Ensure loading overlay is invisible
        if (loadingOverlay != null)
            loadingOverlay.gameObject.SetActive(false);
        else
            Debug.LogWarning("Loading overlay is not assigned in the inspector.");

        // Check if scene exists in Build Settings
        if (IsSceneInBuildSettings(sceneToLoad))
        {
            // Begin loading the scene in the background
            sceneLoadingOperation = SceneManager.LoadSceneAsync(sceneToLoad);
            sceneLoadingOperation.allowSceneActivation = false;
        }
        else
        {
            Debug.LogError($"Failed to start scene loading. Scene '{sceneToLoad}' is not in Build Settings!");
        }
    }

    // Called when the New Game button is tapped
    public void LoadScene()
    {
        if (sceneLoadingOperation != null)
        {
            if (loadingOverlay != null)
                loadingOverlay.gameObject.SetActive(true);

            sceneLoadingOperation.allowSceneActivation = true;
        }
        else
        {
            Debug.LogError("Scene loading operation is null. Cannot load scene.");
        }
    }

    // Helper function to check if a scene is in Build Settings
    bool IsSceneInBuildSettings(string sceneName)
    {
        for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
        {
            string path = SceneUtility.GetScenePathByBuildIndex(i);
            string name = System.IO.Path.GetFileNameWithoutExtension(path);
            if (name == sceneName)
                return true;
        }
        return false;
    }

    
}
