using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BallManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI finishText;
    public TextMeshProUGUI gameoverText;

    private float score = 0;

    private void Start()
    {
        finishText.enabled = false;
        gameoverText.enabled = false;
    }

    void Update()
    {
        if(!finishText.enabled && !gameoverText.enabled) 
        {
            score += 10 * Time.deltaTime;
            scoreText.text = score.ToString("0");
        }

        // RePlay
        if ((finishText.enabled || gameoverText.enabled) && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            GetComponent<BallMovement>().enabled = false;
            gameoverText.enabled = true;
        }

        if (other.CompareTag("Finish"))
        {
            GetComponent<BallMovement>().enabled = false;
            finishText.enabled = true;
        }
    }

}
