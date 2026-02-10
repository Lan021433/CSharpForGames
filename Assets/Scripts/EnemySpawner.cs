using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject m_EnemyType;

    [SerializeField] private float m_WaveTimer = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnEnemies(m_WaveTimer, m_EnemyType));
    }

    //The function controlling the spawning of the enemies using instantiate and setting the timer using the coroutine
    private IEnumerator SpawnEnemies(float Timer, GameObject Enemy)
    {
        yield return new WaitForSeconds(Timer);
        GameObject SpawnedEnemy = Instantiate(Enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(SpawnEnemies(Timer, Enemy));
    }
}
