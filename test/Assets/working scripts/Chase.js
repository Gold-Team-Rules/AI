#pragma strict

    var target : Transform; //the enemy's target
    var moveSpeed = 3; //move speed
    var rotationSpeed = 3; //speed of turning
     private var moveDirection : Vector3 = Vector3.zero;
     private var speed = 3;
     var gravity : float = 100.0;
    var myTransform : Transform; //current transform data of this enemy
     
    function Awake()
    {
    myTransform = transform; //cache transform data for easy access/preformance
    }
     
    function Start()
    {
    target = GameObject.FindWithTag("Player").transform; //target the player
     
    }
     
    function Update () {
    //rotate to look at the player
    myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
    Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
     
    //move towards the player
    myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
 
     moveDirection = Vector3(Input.GetAxis("Horizontal"), 0,
			                        Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
     moveDirection.y -= gravity * Time.deltaTime;
    }