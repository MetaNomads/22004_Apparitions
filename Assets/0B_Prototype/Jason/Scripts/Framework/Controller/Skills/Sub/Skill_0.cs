using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;


public class Skill_0 : Skill
{
    [Header("Inspector")]
    public int projectileSpeed;
    public Projectile projectilePrefab;
    public int maxDistance;
    public float offset;
    
    //other parameters
    private Vector3 projectileDirection;
    private Vector3 startPosition;

    public void Start()
    {
        skillID = 0;
        init();
        
 
        

    }
    
    public override void OnCast()
    {
        var player = GameObject.FindGameObjectWithTag("Player"); //change when using multiplayer
        var hand = player.transform.Find("TrackerOffsets/MetaFrame_Hand_R");

        if (!hand) return;
        startPosition = hand.transform.position + hand.transform.forward*offset;
        projectileDirection = hand.transform.forward;
        
        var projectile = GameObject.Instantiate<Projectile>(projectilePrefab,startPosition, quaternion.identity);
        projectile.init(projectileSpeed, projectileDirection);
    }
}
