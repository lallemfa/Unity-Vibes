﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class MainObject : MonoBehaviour {

    public readonly bool is3D;
    private int id = -1;
    public ObjectType type;
    private Material material;

    private void Start() {
        material = GetComponent<Material>();
    }

    public int GetId() {
        return id;
    }

    public void SetId(int id) {
        this.id = id;
    }

    public void SetPosition(float x, float y, float z) {
        SetPosition(new Vector3(x, y, z));
    }

    public void SetPosition(Vector3 newPosition) {
        transform.position = newPosition;
    }

    public void SetEulerRotation(float rx, float ry, float rz) {
        transform.rotation = Quaternion.Euler(rx, ry, rz);
    }

    public void SetSize(float sx, float sy, float sz) {
        SetSize(new Vector3(sx, sy, sz));
    }

    public void SetColor(float r, float g, float b, float a) {
        material.color = new Color(r, g, b, a);
    }

    public void SetSize(Vector3 newSize) {
        transform.localScale = newSize;
    }
}

public enum ObjectType : int {
    Plane, Cube, Sphere, Capsule, Cylinder, Boat, Submarine, DeathStar, Plane2D
}
