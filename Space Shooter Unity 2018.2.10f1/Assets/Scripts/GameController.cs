using System.Collections;
using UnityEngine;

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
    private float waveWait = 4f;

    private void Start()
    {
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
}
