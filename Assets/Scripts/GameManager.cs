using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Quiz quiz;
    EndScreen endScreen;
    AudioSource audioSource;

    void Awake()
    {
        quiz = FindObjectOfType<Quiz>();
        endScreen = FindObjectOfType<EndScreen>();
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        quiz.gameObject.SetActive(true);
        endScreen.gameObject.SetActive(false);
    }

    void Update()
    {
        if (quiz.isComplete)
        {
            quiz.gameObject.SetActive(false);
            endScreen.gameObject.SetActive(true);
            endScreen.ShowFinalScore();
        }
    }

    public void OnRelodeLevel()
    {
        StartCoroutine(_PlayClickSound());
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BackToCategoryMenu()
    {
        StartCoroutine(_PlayClickSound());
        SceneManager.LoadScene(1);
    }

    IEnumerator _PlayClickSound()
    {
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);   
    }
}
