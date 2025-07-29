using UnityEngine;
using UnityEngine.UI;

public class TutorialUI : MonoBehaviour
{
    public GameObject popup;
    public Button openButton;
    public Button closeButton;

    void Start()
    {
        openButton.onClick.AddListener(() => popup.SetActive(true));
        closeButton.onClick.AddListener(() => popup.SetActive(false));
        popup.SetActive(false); // pastikan popup tidak muncul awal
    }
}
