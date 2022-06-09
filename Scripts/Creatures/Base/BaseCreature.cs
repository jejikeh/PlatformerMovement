using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCreature : Creature
{
    protected override Vector3 GetMovementInput()
    {
        return new Vector3(Input.GetAxis("Horizontal"),0f,Input.GetAxis("Vertical"));
    }
}
