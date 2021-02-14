﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Projectile projectilePrefab;
    public LayerMask mask;


    void shoot(RaycastHit hit){
  // 1
    var projectile = Instantiate(projectilePrefab).GetComponent<Projectile>();
    // 2
    var pointAboveFloor = hit.point + new Vector3(0, this.transform.position.y, 0);

    // 3
    var direction = pointAboveFloor - transform.position;

    // 4
    var shootRay = new Ray(this.transform.position, direction);

    // 5
    Physics.IgnoreCollision(GetComponent<Collider>(), projectile.GetComponent<Collider>());

    // 6
    projectile.FireProjectile(shootRay);
}

    void raycastOnMouseClick () {
        RaycastHit hit;
        Ray rayToFloor = Camera.main.ScreenPointToRay(Input.mousePosition);
        

        if(Physics.Raycast(rayToFloor, out hit, 100.0f, mask, QueryTriggerInteraction.Collide)) {
            shoot(hit);
        }
}

// 2
    void Update () {
        bool mouseButtonDown = Input.GetMouseButtonDown(0);
        if(mouseButtonDown) {
            raycastOnMouseClick();  
        }
    }
}
