using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneFader : MonoBehaviour
{
    [Header("Fade Settings")]
    public Image fadeImage;
    public float fadeDuration = 0.7f; // lite snabbare för mobilen

    private void Start()
    {
        // Startar fade-in när scenen öppnas
        if (fadeImage != null)
            StartCoroutine(FadeIn());
    }

    public void FadeToScene(string sceneName)
    {
        if (fadeImage != null)
            StartCoroutine(FadeOut(sceneName));
        else
            SceneManager.LoadScene(sceneName);
    }

    IEnumerator FadeIn()
    {
        fadeImage.gameObject.SetActive(true);
        float t = 1f;
        while (t > 0f)
        {
            t -= Time.deltaTime / fadeDuration;
            fadeImage.color = new Color(0, 0, 0, t);
            yield return null;
        }
        fadeImage.gameObject.SetActive(false);
    }

    IEnumerator FadeOut(string sceneName)
    {
        fadeImage.gameObject.SetActive(true);
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / fadeDuration;
            fadeImage.color = new Color(0, 0, 0, t);
            yield return null;
        }

        SceneManager.LoadScene(sceneName);
    }
}