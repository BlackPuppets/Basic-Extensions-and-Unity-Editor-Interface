using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Enemy))]
public class EnemyEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        Enemy myEnemy = (Enemy)target;

        myEnemy.enemyPrefab = (GameObject)EditorGUILayout.ObjectField("Base Enemy Prefab", myEnemy.enemyPrefab, typeof(GameObject), true);
        myEnemy.healthPoints = EditorGUILayout.IntField("Health Points", myEnemy.healthPoints);
        myEnemy.moveSpeed = EditorGUILayout.FloatField("Base Movement Speed", myEnemy.moveSpeed);
        myEnemy.movementDebuff = EditorGUILayout.FloatField("Movement Speed Debuff", myEnemy.movementDebuff);

        EditorGUILayout.LabelField("Current Movement Speed", myEnemy.GetTotalMovementSpeed().ToString());
        EditorGUILayout.HelpBox("Return the total movement speed using the following math: BaseMovementSpeed/MovementSpeedDebuff", MessageType.Info);

        if (GUILayout.Button("Spawn Enemy"))
        {
            myEnemy.InstatiateEnemy();
        }
    }
}
