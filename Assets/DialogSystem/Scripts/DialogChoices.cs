using UnityEngine;
using UnityEngine.UI;

public class DialogChoices : MonoBehaviour {
    public GameObject ButtonPrefab; // pre fab of button

    private GameObject[] currentButtons; // temp objects of buttons in scene
    private string[] choicesText; // text in current buttons

    private const double START_Y_BUTTON = 60;
    private const double Y_BUTTON_DECREASSE = 25;

    private protected int choiceSelected = 0; // referent of button selected by player

    private const char CHAR_SEPARATE_TEXTCHOICES = '*';

    // Choices text seted by FileStream
    public void GetChoices(string textChoices) {
        choicesText = textChoices.Split(CHAR_SEPARATE_TEXTCHOICES); // Divide the texts choices

        double yposition = START_Y_BUTTON; // set initial button position

        currentButtons = new GameObject[choicesText.Length]; // Set length of the arry of unity buttons
        Text[] buttonText = new Text[choicesText.Length]; // Set length of the arry of text of unity buttons

        // instatiate all buttons by the choices count
        for(int i = 0; i < choicesText.Length; i++) {
            currentButtons[i] = Instantiate(ButtonPrefab, new Vector2(0, (float)yposition), transform.rotation, GetComponent<Transform>()); // instatiate button
            
            buttonText[i] = currentButtons[i].GetComponentInChildren<Text>(); // get the text of the button
            buttonText[i].text = choicesText[i]; // Show the text of choices
            
            yposition -= Y_BUTTON_DECREASSE; // decreass the position y of the next button
        }
    }

    // Get the button selected by player in game
    public void SetChoice(int choiceID) {
        choiceSelected = choiceID; // set the choiceSelected

        // destroy the buttons of choices
        for(int i = 0; i < currentButtons.Length; i++) {
            Destroy(currentButtons[i]);
        }

        // TODO : send choice selected to event system
    }
}