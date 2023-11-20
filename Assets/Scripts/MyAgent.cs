using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;

public class MyAgent : Agent
{
    [SerializeField]
    Vector3 enemyPosition; 

    public override void CollectObservations(VectorSensor sensor)
    {
        //RayCasting shit which results to a bool value (sees me or doesnt)
        bool enemyInSight = false;
        //Custom shit which if I am in enemy's sight
        bool heheImInDanger = true;
        sensor.AddObservation(enemyInSight);
        sensor.AddObservation(heheImInDanger);

        //as many AddObservation as we think we need
    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        float confidenceToShoot = actions.ContinuousActions[0];
        float weaponSelection = actions.ContinuousActions[1];
        if (confidenceToShoot < 0)
        {
            //Don't shoot
        }
        else
        {
            //Shoot
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
