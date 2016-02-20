using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardsDictionary : MonoBehaviour {

	private Dictionary<string, Card> cards = new Dictionary<string, Card>();

	public void generateCards(){
		//Ajout carte Mandytoh
		Card cardMandytoh = new Card ();
		cardMandytoh.name = "Super Mandytoh";
		cardMandytoh.attack = 10;
		cardMandytoh.health = 10;
		cardMandytoh.legendary = true;
		cardMandytoh.cardClass = "Developer";
		cardMandytoh.manaCost = 9;
		cardMandytoh.codeDeathRattle = 0;
		cardMandytoh.codeBattleCry = 0;
		cardMandytoh.taunt = true;
		cardMandytoh.charge = false;
		this.cards.Add ("mandytoh", cardMandytoh);

		//Ajout carte SeazeR
		Card cardSeazeR = new Card ();
		cardSeazeR.name = "SeazeR";
		cardSeazeR.attack = 2;
		cardSeazeR.health = 25;
		cardSeazeR.legendary = true;
		cardSeazeR.cardClass = "Developer";
		cardSeazeR.manaCost = 5;
		//Donne 15 points de vie a chaque serviteurs et immunise le joueurs pendant 2 tours
		cardSeazeR.codeDeathRattle = 1;
		//Donne +4 attaque a chaque serviteurs (dont lui meme) pour chaque points de vie perdu
		cardSeazeR.codeBattleCry= 1;
		cardSeazeR.taunt= false;
		cardSeazeR.charge= true;
		this.cards.Add ("seazer", cardSeazeR);

		//Ajout carte Ewilen
		Card cardEwilen = new Card ();
		cardEwilen.name = "Ewilen";
		cardEwilen.attack = 4;
		cardEwilen.health = 5;
		cardEwilen.legendary = false;
		cardEwilen.cardClass = "Viewer";
		cardEwilen.manaCost = 3;
		cardEwilen.codeDeathRattle = 0;
		//augmente de 1 son attaque pour chaque monstre sur le terrain
		cardEwilen.codeBattleCry = 2;
		cardEwilen.taunt = false;
		cardEwilen.charge = true;
		this.cards.Add ("ewilen", cardEwilen);

		//Ajout carte Glyci
		Card cardGlyci = new Card ();
		cardGlyci.name = "Glyci";
		cardGlyci.attack = 18;
		cardGlyci.health = 8;
		cardGlyci.legendary = true;
		cardGlyci.cardClass = "Viewer gagnant";
		cardGlyci.manaCost = 8;
		//Lache des spores qui soignent les alliés de +1 par unité sur le terrain
		cardGlyci.codeDeathRattle = 3;
		// donne un bonus d'attaque aux serviteurs alliés égaux à leur unité de mana
		cardGlyci.codeBattleCry = 3;
		cardGlyci.taunt = false;
		cardGlyci.charge = true;
		this.cards.Add ("glyci", cardGlyci);

		//Ajout carte Vulcairn
		Card cardVulcairn = new Card ();
		cardVulcairn.name = "Vulcairn, dieu de la forge";
		cardVulcairn.attack = 3;
		cardVulcairn.health = 8;
		cardVulcairn.legendary = true;
		cardVulcairn.manaCost = 9;
		//Fait une onde de choc faisant des degats à tous les serviteurs adversaires
		cardVulcairn.codeDeathRattle = 4;
		cardVulcairn.codeBattleCry = 0;
		cardVulcairn.taunt = true;
		cardVulcairn.charge = false;
		this.cards.Add ("vulcairn", cardVulcairn);
		
		//VieuxPapa
		Card cardVieuxPapa = new Card ();
		cardVieuxPapa.name = "Vieuxpapa";
		cardVieuxPapa.attack = 8;
		cardVieuxPapa.health = 2;
		cardVieuxPapa.legendary = false;
		cardVieuxPapa.manaCost = 7;
		//double les points de vie du héros
		cardVieuxPapa.codeDeathRattle = 4;
		cardVieuxPapa.codeBattleCry = 0;
		cardVieuxPapa.taunt = true;
		cardVieuxPapa.charge = false;
		this.cards.Add ("vieuxpapa", cardVieuxPapa);
	}

	public Card GetCard( string key){
		if (this.cards.ContainsKey (key)) {
			return this.cards [key];
		} else {
			Debug.Log("Il n'existe pas de carte \"" + key + "\"");
			return null;
		}
	}

}
