using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour {

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI wordsText;
    public TextMeshProUGUI failsText;
    public int scorePerWord = 5;
    public int scorePerTapFail = -10;
    public int scorePerTapSuccess = 1;

    private int score = 0;
    private int fails = 0;
    private int wordsDone = 0;



    private void Awake() {
        scoreText.text = "Score: 0";
        wordsText.text = "OK: 0";
        failsText.text = "NOK: 0"; 
    }



    public void SuccessTap() {
        AddScore(scorePerTapSuccess);
    }


    public void FailedTap() {
        AddScore(scorePerTapFail);
        AddFail();
    }


    public void DoneWord() {
        AddScore(scorePerWord);
        AddDoneWord();
    }



    private void AddScore(int amount) {
        score += amount;
        scoreText.text = "Score: " + score;
    }


    private void AddDoneWord() {
        wordsDone++;
        wordsText.text = "OK: " + wordsDone;
    }


    private void AddFail() {
        fails++;
        failsText.text = "NOK: " + fails;
    }
}
