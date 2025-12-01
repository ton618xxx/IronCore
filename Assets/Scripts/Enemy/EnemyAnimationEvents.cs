using UnityEngine;

public class EnemyAnimationEvents : MonoBehaviour
{

    public void StopManualMovement() => enemy.ActivateManualMovement(false);

    public void StartManualRotation() => enemy.ActivateManualRotation(true); 
    public void StopManualRotation() => enemy.ActivateManualRotation(false);    
}
