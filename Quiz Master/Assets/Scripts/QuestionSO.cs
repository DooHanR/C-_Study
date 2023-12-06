using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject 
{
    [TextArea(2, 6)]
    [SerializeField] string question = "Enter new text here";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;
    public string getQuestion()
    {
        return question;
    }

    public int GetCorrectAnswerIndex() {
        return correctAnswerIndex;
    }

    public string getAnswer(int index) {
        return answers[index];
    }

}
