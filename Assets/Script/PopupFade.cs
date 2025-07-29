using UnityEngine;
using System.Collections;

public class PopupFade : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public float fadeDuration = 1f;
    public float displayDuration = 5f;

    void Start()
    {
        StartCoroutine(FadeInOut());
    }

    IEnumerator FadeInOut()
    {
        // Muncul pelan-pelan (fade in)
        yield return StartCoroutine(FadeCanvas(0f, 1f, fadeDuration));

        // Tunggu beberapa detik
        yield return new WaitForSeconds(displayDuration);

        // Menghilang pelan-pelan (fade out)
        yield return StartCoroutine(FadeCanvas(1f, 0f, fadeDuration));

        // Setelah selesai, sembunyikan
        gameObject.SetActive(false);
    }

    IEnumerator FadeCanvas(float from, float to, float duration)
    {
        float elapsed = 0f;
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(from, to, elapsed / duration);
            yield return null;
        }

        canvasGroup.alpha = to;
    }
}
