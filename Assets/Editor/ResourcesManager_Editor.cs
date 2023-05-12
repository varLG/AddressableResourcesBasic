using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; 

[CustomEditor(typeof(ResourcesManager))]
public class ResourcesManager_Editor : Editor
{
	int level;
	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI();
		ResourcesManager levelManager = (ResourcesManager)target;

		EditorGUILayout.Space(10); 
		EditorGUILayout.BeginHorizontal();
		level =EditorGUILayout.IntField("Load Level: ",level,GUILayout.Width(200));

		if (GUILayout.Button("Load Level"))
		{
			levelManager.LoadLevel(level);	
		}

		EditorGUILayout.EndHorizontal();
	}
}
