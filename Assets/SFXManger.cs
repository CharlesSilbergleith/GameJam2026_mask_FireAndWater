using UnityEngine;
using UnityEngine.SceneManagement;

public class SFXManger : MonoBehaviour
{
    public static SFXManger instance;

    public AudioClip drumHit;

    private AudioSource audioSource;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();
    }
    

    public void drum()
    {
        if (audioSource != null)
            audioSource.PlayOneShot(drumHit);
    }
}
