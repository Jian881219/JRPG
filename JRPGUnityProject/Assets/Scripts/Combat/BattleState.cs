﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Will be a private member of PlayerStateManager and a public member of ally sprites,
// enemy sprites, PlayerBattleController, allies in battle and enemies in battle.
[System.Serializable]
public class BattleState {

    public int level;

    public int strength;
    public int endurance;
    public int accuracy;
    public int speed;
    public int deadliness;

    public int attackRating;
    public int defenceRating;

    public int currentHealth;
    public int maximumHealth;
    public List<bool> statusEffects;
}