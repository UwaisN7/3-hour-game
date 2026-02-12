using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetScene : MonoBehaviour
{
    public GameObject WinText;
    public GameObject TutorialText;


    private void Start()
    {
        WinText.SetActive(false);
        TutorialText.SetActive(true);
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
        }

       
    }

    private void OnTriggerStay(Collider other)
    {
        

        if (other.CompareTag("Win"))
        {
            WinText.SetActive (true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Tutorial"))
        {
            TutorialText.SetActive(false);
        }
    }
}
