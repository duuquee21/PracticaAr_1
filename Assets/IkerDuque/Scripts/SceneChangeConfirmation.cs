using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeConfirmation : MonoBehaviour
{
    [SerializeField] private GameObject confirmationCanvas; // El Canvas de confirmaci�n
    [SerializeField] private string sceneToLoad; // La escena a cargar

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Muestra el Canvas de confirmaci�n al detectar la colisi�n
            confirmationCanvas.SetActive(true);
        }
    }

    public void ConfirmChangeScene()
    {
        // Carga la escena
        SceneManager.LoadScene(sceneToLoad);
    }

    public void CancelChangeScene()
    {
        // Oculta el Canvas de confirmaci�n sin hacer nada
        confirmationCanvas.SetActive(false);
    }
}
