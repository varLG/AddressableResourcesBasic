using System.Collections;
using System.Collections.Generic;
using UnityEditor.AddressableAssets.Settings;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AddressableManager : MonoBehaviour
{
	[SerializeField] Transform garbage;
	[SerializeField] AssetReferenceGameObject dozerAssetReference;
	[SerializeField] AssetReferenceGameObject downloadedAssetReference;

	GameObject spawnedDozer, downloadedObject;
	public void LoadAssetReference()
	{
		if (spawnedDozer != null)
			Addressables.ReleaseInstance(spawnedDozer);

		Addressables.InstantiateAsync(dozerAssetReference).Completed +=
			(x) =>
			{
				spawnedDozer = x.Result; 
			};
	}
	public void ReleaseAssetReference()
	{
		if (spawnedDozer != null)
			Addressables.ReleaseInstance(spawnedDozer);
		else
			Debug.Log("Spawned Object not found.");
	}


	public void DownloadAssetReference()
	{ 

		if (downloadedObject != null)
			Addressables.ReleaseInstance(downloadedObject);

		Addressables.InstantiateAsync(downloadedAssetReference).Completed +=
			(x) =>
			{
				downloadedObject = x.Result; 
			};
	}

	public void ReleaseDownloadedAssetReference()
	{
		if (downloadedObject != null)
			Addressables.ReleaseInstance(downloadedObject);
		else
			Debug.Log("Downloaded Object not found.");
	}
}
