using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Rendering;

public class ResourcesManager : MonoBehaviour
{
	[SerializeField] Transform garbage;

	GameObject levelObject;
	string levelName;
	int garbageCount;
	 
	public void LoadLevel(int _levelIndex)
	{
		ClearGarbage();

		levelName = "Level_" + _levelIndex;
		levelObject = Resources.Load("Levels/" + levelName) as GameObject;
		
		Instantiate(levelObject,garbage);
	}

	void ClearGarbage()
	{
		garbageCount=garbage.childCount;
		for (int i = 0; i < garbageCount; i++)
		{
			DestroyImmediate(garbage.GetChild(0).gameObject);
		}

		Resources.UnloadUnusedAssets();
	}
}
