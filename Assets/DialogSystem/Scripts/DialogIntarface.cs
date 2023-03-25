using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogIntarface : MonoBehaviour {

    [SerializeField] private Text dialogText, nameText;

    public DialogFileStream fileStream;


    private void Start() {
        Debug.Log(fileStream.ReadDialog("test",1)[1]);
    }

    private void Update() {

    }

}