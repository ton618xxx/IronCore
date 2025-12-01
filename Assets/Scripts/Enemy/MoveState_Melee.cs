using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class MoveState_Melee : EnemyState
{

    private Enemy_Melee enemy;
    private Vector3 destination; 
    
    public MoveState_Melee(Enemy enemyBase, EnemyStateMachine stateMachine, string animBoolName) : base(enemyBase, stateMachine, animBoolName)
    {

    {
        base.Exit(); 
    }

    public override void Update()
    {
        base.Update();

        if (enemy.PlayerInAggressionRange())
        {
            stateMachine.Cha
        
            
        



        
