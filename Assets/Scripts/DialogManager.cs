using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour {

    private string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quis erat nulla. Mauris eget accumsan turpis. Ut ac dignissim lectus. Mauris pretium lobortis placerat. Nunc sagittis dignissim erat sed faucibus. Pellentesque orci dui, interdum in erat quis, ullamcorper molestie nulla. Praesent commodo elit tortor, quis auctor eros rhoncus ac. Praesent ut mollis est, ac bibendum quam. Quisque facilisis mollis lobortis. Pellentesque non mauris dolor. Proin aliquet aliquam risus ut ultrices. Quisque et convallis massa. Curabitur vitae pulvinar justo. Nullam hendrerit mauris sed tellus vehicula, id lobortis lectus ultrices. Integer ac augue auctor, volutpat purus nec, pretium justo.\r\n\r\n";
    public Text dialog_text;


    public float writeSpeed;
    private protected float timer = 0;

    private int currentChar = 0;

    void Start() {

    }

    void Update() {
        if(currentChar <= text.Length) {            
            if(timer > writeSpeed) {
                
                switch(text[currentChar]) {
                    case '\a': Debug.Log("a");
                        dialog_text.text += text[currentChar];
                        break;

                    default:
                        dialog_text.text += text[currentChar];
                        break;
                }

                currentChar++;
                timer = 0;
            } else {
                timer += Time.deltaTime;
            }
        }
    }
}
