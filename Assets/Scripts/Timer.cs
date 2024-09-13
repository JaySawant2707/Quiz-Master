using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteAnswer = 10f;
    //[SerializeField] float timeToShowCorrectAnswer = 10f;

    public bool isAnswering = false;
    public bool loadNextQuestion = true;
    public float fillFraction;
    public bool isTimerOn = true;

    float timerValue;

    Quiz quiz;

    void Awake()
    {
        quiz = FindObjectOfType<Quiz>();
    }

    private void Start() {
        isAnswering = true;
        timerValue = timeToCompleteAnswer;
        loadNextQuestion = true;
    }

    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    void UpdateTimer()
    {
        if (isTimerOn)
        {
            timerValue -= Time.deltaTime;
        }

        if (isAnswering)
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToCompleteAnswer;
            }
            else
            {
                isAnswering = false;
                isTimerOn = false;
                timerValue = timeToCompleteAnswer;
                quiz.nextQuestionButton.SetActive(true);

            }
        }
    }
}
