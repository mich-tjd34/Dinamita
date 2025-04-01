using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImageTransitionController : MonoBehaviour
{
    // Referencia al componente Image para cambiar el fondo
    public Image backgroundImage;

    // Imágenes que se usarán para cada escena
    public Sprite playImage;
    public Sprite settingsImage;
    public Sprite storyImage;

    // Función para cambiar la imagen del fondo
    public void ChangeBackgroundImage(string scene)
    {
        switch (scene)
        {
            case "Play":
                backgroundImage.sprite = playImage;
                break;
            case "Settings":
                backgroundImage.sprite = settingsImage;
                break;
            case "Story":
                backgroundImage.sprite = storyImage;
                break;
            default:
                Debug.LogError("Escena no definida para cambiar la imagen");
                break;
        }
    }

    // Función para cargar nuevas escenas
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Función para volver al menú principal
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
