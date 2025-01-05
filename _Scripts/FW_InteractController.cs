using UnityEngine;
using TMPro;

public class FW_InteractController : MonoBehaviour {

    [Header("Settings:")]
    public SoundController sc;
    public ScoreManager sm;
    public Color activeWordColor;

    private TextMeshPro currentTMP;
    private char currentChar;


    private void Update() {
        if (transform.childCount > 0) {
            if (currentTMP == null) { //Get new word if possible
                GetCurrentTMP(); //Get new word
                GetNextChar(); //Init first char of new word
            }

            if (Input.inputString == "" + currentChar) {

                if (!IsWordFinished()) {
                    //Success Tap:
                    sc.PlayTapSuccessSound();
                    //Reduce the word without the inputed key:
                    SetNewText();
                    //Get next char to input:
                    GetNextChar();

                    sm.SuccessTap();
                } else {
                    //Destoy finished word:
                    DestroyCurrentTMP();
                    sm.DoneWord();
                }
            }else if(Input.inputString != "" && Input.anyKeyDown) {
                sc.PlayTapFailSound();
                sm.FailedTap();
            }
        }
    }

    
    private void GetCurrentTMP() {
        currentTMP = transform.GetChild(0).GetComponent<TextMeshPro>();
        currentTMP.color = activeWordColor;
    }

    private bool IsWordFinished() {
        return currentTMP.text.Length == 2;
    }

    private void SetNewText() {
        currentTMP.text = currentTMP.text.Substring(1);
    }

    private void GetNextChar() {
        currentChar = currentTMP.text[0];
    }

    private void DestroyCurrentTMP() {
        Destroy(currentTMP.gameObject);
    }
}
