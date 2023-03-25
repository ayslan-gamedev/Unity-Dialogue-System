using UnityEngine;
using System.IO;

public class DialogFileStream : MonoBehaviour {
    private protected string currentDialogFile; // current dialog in using
    private protected string[] currentLines = new string[0];

    private protected const string DEFAULT_DIALOG_PATH = "/DialogSystemAssets/"; // Path of dialogs files in streamAsset folder
    private protected const string EXTENCION_PATH = ".dialogFile"; 

    private protected const char LINE_SEPARETE_CHAR = ';';
    private protected const char CELL_SEPARETE_CHAR = '/';

    // Read the file .dialogPath
    private void LoadDialogPath(string _dialogFile) {
        var dialogLocate = Application.streamingAssetsPath + DEFAULT_DIALOG_PATH + _dialogFile + EXTENCION_PATH; // Set path
        StreamReader reader = new StreamReader(dialogLocate); // open the file and read data

        currentLines = reader.ReadToEnd().Split(LINE_SEPARETE_CHAR); // Get lines
        reader.Close(); // close de file
    }

    public string[] ReadDialog(string dialogFile,int lineID) {
        // Check if the file change
        if(dialogFile != currentDialogFile) {
            LoadDialogPath(dialogFile);
            currentDialogFile = dialogFile;
        }

        // Set the data
        return new string[2] { NameText(lineID), DialogText(lineID) };
    }

    private protected const int CELL_NAME_NUM = 0;
    private protected const int CELL_DIALOG_NUM = 1;

    // Get the name in current line
    private protected string NameText(int _lineID) { 
        return currentLines[_lineID].Split(CELL_SEPARETE_CHAR)[CELL_NAME_NUM]; 
    }

    // Get the dialogs lines in current line
    private protected string DialogText(int _lineID) { 
        return currentLines[_lineID].Split(CELL_SEPARETE_CHAR)[CELL_SEPARETE_CHAR]; 
    }
}