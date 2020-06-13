﻿using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Projectile")]
public class ProjectileObject : ScriptableObject
{
    public GameObject prefab;
    public Sprite sprite;
    public float scale = 1f;
    public int damage = 1;
    public float speed = 5f;
    public float range = 10f;
    public float duration = 0f;
}
