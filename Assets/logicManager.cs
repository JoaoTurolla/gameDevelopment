using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logicManager : MonoBehaviour {
    
    public int playerScore = 0;
    public Text scoreNumber;    
    public GameObject gameOverScreen;
    
    [ContextMenu("Increase Score")]
    public void addScore(int scoreAdd) {
        playerScore += scoreAdd;
        scoreNumber.text = playerScore.ToString();
    }
    
    public void restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {
        gameOverScreen.SetActive(true);
    }

}
