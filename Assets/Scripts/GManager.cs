using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GManager : MonoBehaviour
{
    private GameObject gameclearText, gameoverText, retryButtion;
    public GameObject player;
    public GameObject particle;
    public Text scoreText;
    private int score;
    void Start()
    {
        gameclearText = GameObject.FindGameObjectWithTag("ClearText");
        gameoverText = GameObject.FindGameObjectWithTag("GameOverText");
        retryButtion = GameObject.FindGameObjectWithTag("RetryButtion");
        gameclearText.SetActive(false);
        gameoverText.SetActive(false);
        retryButtion.SetActive(false);
        score = 500;
        Application.targetFrameRate = 60;
        Screen.SetResolution(1920, 1080, false);
    }

    void Update()
    {
        scoreText.text = "Score : " + score;
        if (score < 0)
        {
            gameoverText.SetActive(true);
            retryButtion.SetActive(true);
            scoreText.text = "‚¨‘O‚Í‚à‚¤Ž€‚ñ‚Å‚¢‚é";
            Destroy(player);
            GameObject[] bullet = GameObject.FindGameObjectsWithTag("Bullet");
            for (int i = 0; i < bullet.Length; i++)
            {
                Destroy(bullet[i]);
            }
        }
    }

    public void GameClear()
    {
        gameclearText.SetActive(true);
        retryButtion.SetActive(true);
        Destroy(player.GetComponent<Bomb>());
    }

    public void ReloadScene() { SceneManager.LoadScene("SampleScene"); }
    public void KillEnemy() { score += 250; }
    public void PlayerDamage()
    {
        score -= 50;
        Instantiate(particle, player.transform.position, Quaternion.identity);
        GetComponent<AudioSource>().Play();
    }
    public void UseBomb() { score -= 250; }
}
