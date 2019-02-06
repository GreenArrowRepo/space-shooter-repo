using UnityEngine;
using System.Collections;


public class GameController : MonoBehaviour
{
    [SerializeField]
    private GameObject hazard;
    [SerializeField]
    private Vector3 spawnValues;
    [SerializeField]
    private int hazardCount;
    [SerializeField]
    private float startWait = 1f;
    [SerializeField]
    private float spawnWait = 0.5f;

    [SerializeField]
    private TMPro.TextMeshProUGUI scoreText;

    private float waveWait = 4f;
    private int score;


    private void Start()
    {
        score = 0;
        UpdateScore();
        StartCoroutine(spawnWaves());
    }

    private IEnumerator spawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    public void UpdateScore()
    {
        scoreText.text = "Score " + score;
    }
}
