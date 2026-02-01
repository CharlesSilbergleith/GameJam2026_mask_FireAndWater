using System.Collections;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public AudioClip drumHit;
    public AudioSource audioSource;
    void Start() { 
        audioSource = GetComponent<AudioSource>();
    }
    public void StartButton()
    {
        StartCoroutine(LoadAfterDelay("playWorld"));
    }

    public void Creadits()
    {
        StartCoroutine(LoadAfterDelay("Creadits"));
    }

    public void Quit()
    {
        Drum();
        Invoke(nameof(QuitApp), 1f);
    }

    public void MainMenu()
    {
        StartCoroutine(LoadAfterDelay("mainMenu"));
    }

    IEnumerator LoadAfterDelay(string sceneName)
    {
        Drum();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }

    void QuitApp()
    {
        Application.Quit();
    }
    public void Drum() {
        audioSource.PlayOneShot(drumHit);
    }
}
