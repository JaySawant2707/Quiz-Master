using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CategoryMenu : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void BackToMainMenu()
    {
        StartCoroutine(_PlayClickSound());
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void PythonBtn()
    {
        StartCoroutine(_PlayClickSound());
        SceneManager.LoadScene("Python");
    }

    public void PhpBtn()
    {
        StartCoroutine(_PlayClickSound());
        SceneManager.LoadScene("Php");
    }

    public void CppBtn()
    {
        StartCoroutine(_PlayClickSound());
        SceneManager.LoadScene("Cpp");
    }

    public void HtmlBtn()
    {
        StartCoroutine(_PlayClickSound());
        SceneManager.LoadScene("Html");
    }

    public void CssBtn()
    {
        StartCoroutine(_PlayClickSound());
        SceneManager.LoadScene("Css");
    }

    public void JavascriptBtn()
    {
        StartCoroutine(_PlayClickSound());
        SceneManager.LoadScene("Javascript");
    }

    IEnumerator _PlayClickSound()
    {
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);   
    }
}
