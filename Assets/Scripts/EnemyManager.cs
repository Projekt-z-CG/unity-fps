using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Transform[] m_SpawnPoints;
    public GameObject m_EnemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        SpawnNewEnemy();
    }

    private void OnEnable()
    {
        Health.OnEnemyKilled += SpawnNewEnemy;
    }

    // Update is called once per frame
    void SpawnNewEnemy()
    {
        int randomNumber = Mathf.RoundToInt(Random.Range(1f, m_SpawnPoints.Length-1));

        Instantiate(m_EnemyPrefab, m_SpawnPoints[randomNumber].transform.position, Quaternion.identity);
    }
}
