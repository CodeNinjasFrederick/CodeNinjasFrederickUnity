using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject bombPrefab;
    public float delay = 2.0f;
    public bool active = true;
    public Vector2 delayRange = new Vector2(1, 2);

    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;

    // Start is called before the first frame update
    void Start()
    {
        ResetDelay();
        StartCoroutine(EnemyGenerator());

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        objectWidth = bombPrefab.GetComponent<MeshRenderer>().bounds.size.x / 2;
        objectHeight = bombPrefab.GetComponent<MeshRenderer>().bounds.size.y / 2;
    }

    IEnumerator EnemyGenerator()
    {
        yield return new WaitForSeconds(delay);
        if (active)
        {
            float randomX = Random.Range(screenBounds.x - objectWidth, screenBounds.x * -1 + objectWidth);
            float spawnY = (screenBounds.y + objectHeight) + 5;

            Instantiate(bombPrefab, new Vector3(randomX, spawnY, 0), bombPrefab.transform.rotation);
            ResetDelay();
        }

        StartCoroutine(EnemyGenerator());
    }

    void ResetDelay() 
    {
        delay = Random.Range(delayRange.x, delayRange.y);
    }

}
