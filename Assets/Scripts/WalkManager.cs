using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WalkManager : MonoBehaviour
{
    [Header("References")]
    public Animator lizardAnimator;
    public Button startButton;
    public Button stopButton;
    public GameObject timerPanel;
    public GameObject finalPanel;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI finalTimeText;

    private float timer;
    private bool isWalking;

    void Start()
    {
        timer = 0f;
        isWalking = false;

        // Visa bara startknappen i början
        startButton.gameObject.SetActive(true);
        stopButton.gameObject.SetActive(false);
        timerPanel.SetActive(false);
        finalPanel.SetActive(false);
    }

    void Update()
    {
        if (isWalking)
        {
            timer += Time.deltaTime;
            timerText.text = FormatTime(timer);
        }
    }

    // 🔹 Körs när man trycker på Start Timer
    public void StartWalk()
    {
        isWalking = true;
        lizardAnimator.SetBool("isWalking", true);

        startButton.gameObject.SetActive(false);
        stopButton.gameObject.SetActive(true);
        timerPanel.SetActive(true);
        finalPanel.SetActive(false);
    }

    // 🔹 Körs när man trycker på Stop Timer
    public void StopWalk()
    {
        isWalking = false;
        lizardAnimator.SetBool("isWalking", false);

        stopButton.gameObject.SetActive(false);
        timerPanel.SetActive(false);
        finalPanel.SetActive(true);

        finalTimeText.text = "Total Time: " + FormatTime(timer);
    }

    // 🔹 Formaterar tiden till mm:ss
    string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        return $"{minutes:00}:{seconds:00}";
    }
}