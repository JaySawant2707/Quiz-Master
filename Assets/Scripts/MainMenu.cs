using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void StartGame()
    {
        
        StartCoroutine(_PlayClickSound());
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void QuitGame()
    {
        StartCoroutine(_PlayClickSound());
        Application.Quit();
    }

    IEnumerator _PlayClickSound()
    {
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);   
    }
}


