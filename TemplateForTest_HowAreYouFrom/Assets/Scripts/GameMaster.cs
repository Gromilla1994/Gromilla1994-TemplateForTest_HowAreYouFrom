using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class GameMaster : MonoBehaviour
{
    public Button[] buttons;
    public questionsLists[] answers;
    public TextMeshProUGUI TextField;

    public string[] rightAnswers;
    public string[] questionsList;

    public int CounterRightAnswers;
    private int _limitOfQuestions;

    public int currentQuestion;

    [System.Serializable] 
    public struct questionsLists 
    {
        public string[] questions;
    }

    // Start is called before the first frame update
    void Start()
    {
        _limitOfQuestions = questionsList.Length;
        ChangeCurrentQuestions();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ValidateAnswer(int numberOfButton)
    {
        // get text of button
        Button button = buttons[numberOfButton];
        string text = button.GetComponentInChildren<TMP_Text>().text;

        Debug.Log($"a - {text}, r - {rightAnswers[currentQuestion]}");

        if(text == rightAnswers[currentQuestion])
        {
            CounterRightAnswers++;
        }

        currentQuestion++;
        if (currentQuestion == _limitOfQuestions)
        {
            PlayerPrefs.SetInt("RightAnswers", CounterRightAnswers);
            SceneManager.LoadScene(1);
        }

        ChangeCurrentQuestions();    
        Debug.Log(CounterRightAnswers);
    }

    public string[] GetCurrentQuestions()
    {
        return answers[currentQuestion].questions;
    }

    public void ChangeCurrentQuestions()
    {
        TextField.text = questionsList[currentQuestion];

        string[] questions = GetCurrentQuestions();

        for(int i = 0; i < 4; i++)
        {
            Button button = buttons[i];
            button.GetComponentInChildren<TMP_Text>().text = questions[i];
        }
    }
}
