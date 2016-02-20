using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {

	public string name;
	public string cardClass;
	public int manaCost;
	public int attack;
	public int health;
	public int codeDeathRattle;
	public int codeBattleCry;
	public bool taunt;
	public bool charge;
	public bool stealth;
	public bool legendary;

	public Card(){
		this.name = "Unknown card";
		this.cardClass = "";
		this.manaCost = 0;
		this.attack = 0;
		this.health = 1;
		this.codeDeathRattle = 0;
		this.codeBattleCry = 0;
		this.taunt = false;
		this.charge = false;
		this.stealth = false;
		this.legendary = false;
	}

}
