using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public Button[] buttons;

    // Start is called before the first frame update
    void Start()
    {
        
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

        Debug.Log(text);
    }
}
