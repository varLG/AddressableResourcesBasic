using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; 

[CustomEditor(typeof(AddressableManager))]
public class AddressableManager_Editor : Editor
{ 
	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI();
		AddressableManager addressableReference = (AddressableManager)target;

		EditorGUILayout.Space(10);
		EditorGUILayout.BeginHorizontal(); 

		if (GUILayout.Button("Load Reference"))
		{
			addressableReference.LoadAssetReference();
		}

		if (GUILayout.Button("Release Reference"))
		{
			addressableReference.ReleaseAssetReference();
		}
		EditorGUILayout.EndHorizontal();

		EditorGUILayout.BeginHorizontal();
		if (GUILayout.Button("Download Reference"))
		{
			addressableReference.DownloadAssetReference();
		}
		if (GUILayout.Button("Release Downloaded Reference"))
		{
			addressableReference.ReleaseDownloadedAssetReference();
		}
		EditorGUILayout.EndHorizontal();
	}
}
