using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour {

    public Text dialog_text;
    
    public float writeSpeed;
    private protected float writeTimer = 0;

    private string text = "Lorem ipsum dolor sit amet, /a consectetur adipiscing elit. Proin quis erat nulla. Mauris eget accumsan turpis. Ut ac dignissim lectus. Mauris pretium lobortis placerat. Nunc sagittis dignissim erat sed faucibus. Pellentesque orci dui, interdum in erat quis, ullamcorper molestie nulla. Praesent commodo elit tortor, quis auctor eros rhoncus ac.";

    private int currentChar = 0;

    private void Update() {
        if (currentChar < text.Length) {
            WriteText();
        } else {

        }
    }

    private void WriteText() {
        if(writeTimer >= writeSpeed) {
            CheckAlteration(text[currentChar]);
            dialog_text.text += text[currentChar];
            
            currentChar++;
            writeTimer = 0;
        } else {
            writeTimer += Time.deltaTime;
        }

        void CheckAlteration(char character) {
            if(character == '/') {
                currentChar++;
                switch(text[currentChar]) {
                    case 'a':
                        Debug.Log("a command");
                        break;

                    case 'b':
                        Debug.Log("b command");
                        break;
                    
                    default:
                        Debug.LogError("/" + text[currentChar] + " is not a valid command");         
                        break;
                }
                currentChar += 2;
            }
        }
    }
}