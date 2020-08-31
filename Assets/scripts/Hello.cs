using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A teddy bear spawner
/// </summary>
public class Hello : MonoBehaviour
{
	// needed for spawning
	public GameObject prefabTeddyBear0 = default;
	public GameObject prefabTeddyBear1 = default;
	public GameObject prefabTeddyBear2 = default;


	// spawn control
	const float MinSpawnDelay = 1;
	const float MaxSpawnDelay = 2;
	Timer spawnTimer;

	// spawn location support
	const int SpawnBorderSize = 100;
	int minSpawnX;
	int maxSpawnX;
	int minSpawnY;
	int maxSpawnY;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
		// save spawn boundaries for efficiency
		minSpawnX = SpawnBorderSize;
		maxSpawnX = Screen.width - SpawnBorderSize;
		minSpawnY = SpawnBorderSize;
		maxSpawnY = Screen.height - SpawnBorderSize;

		// create and start timer
		spawnTimer = gameObject.AddComponent<Timer>();
		spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
		spawnTimer.Run();
	}

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
		// check for time to spawn a new teddy bear
		if (spawnTimer.finished)
		{
			SpawnBear();

			// change spawn timer duration and restart
			spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
			spawnTimer.Run();
		}
	}

	/// <summary>
	/// Spawns a new teddy bear at a random location
	/// </summary>
	void SpawnBear()
	{
		// generate random location and create new teddy bear
		Vector3 location = new Vector3(Random.Range(minSpawnX, maxSpawnX),
									   Random.Range(minSpawnY, maxSpawnY),
									   -Camera.main.transform.position.z);
		Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);
		
		// set random Prefab for new teddy bear
		int spriteNumber = Random.Range(0, 1);
		if (spriteNumber == 0)
		{
			GameObject teddyBear = Instantiate(prefabTeddyBear0) as GameObject;
			teddyBear.transform.position = worldLocation;
		}
		else if (spriteNumber == 1)
		{
			GameObject teddyBear = Instantiate(prefabTeddyBear1) as GameObject;
			teddyBear.transform.position = worldLocation;
		}
		else
		{
			GameObject teddyBear = Instantiate(prefabTeddyBear2) as GameObject;
			teddyBear.transform.position = worldLocation;
		}
	}
}
