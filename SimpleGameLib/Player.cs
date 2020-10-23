using SimpleGameLib.Item.Potion;
using SimpleGameLib.Monstre;
using System;

namespace SimpleGameLib {

    /// <summary>
    /// Classe permettant de modéliser un joueur
    /// </summary>
    public class Player {

        private int _pv;
        private int _force;
        private bool _isDefend;
        private String _name;
        
        /// <summary>
        /// Constructeur de Player
        /// Force de base : 20
        /// PV de base : 100
        /// </summary>
        /// <param name="name">Nom du joueur</param>
        public Player(String name) {
            this._pv = 100;
            this._force = 20;
            this._name = name;
            this._isDefend = false;
        }
        
        /// <summary>
        /// Affiche le nom et les caractéristiques du joueurs sur la console
        /// </summary>
        public void getDescription() {
            Console.WriteLine("+--------------------------------------------");
            Console.WriteLine("| "+ this._name +" PV : " + this._pv);
            Console.WriteLine("| " + this._name + " Force : " + this._force);
            Console.WriteLine("+-------------------------------------------\n");
        }
        
        /// <summary>
        /// Ajoute des PV au joueur
        /// </summary>
        /// <param name="pv">nombre de PV à ajouter</param>
        public void addPv(int pv) {
            this._pv += pv;
        }

        /// <summary>
        /// Ajoute de la force au joueur
        /// </summary>
        /// <param name="f">nombre de point de force à ajouter</param>
        public void addForce(int f) {
            this._force += f;
        }

        /// <summary>
        /// Le joueur prends un coup qui vas faire baisser ses PV
        /// </summary>
        /// <param name="deg">dégat recut</param>
        public void takeHit(int deg) {
            if (this._isDefend) {
                this._pv -= deg / 2;
                this._isDefend = false;
            } else {
                this._pv -= deg;
            }
        }
        
        /// <summary>
        /// Permets de boire une potion
        /// </summary>
        /// <param name="potion">Potion à boire</param>
        public void drinkPotion(Potion potion) {
            potion.applyEffect(this);
        }

        /// <summary>
        /// Attaque normale
        /// </summary>
        /// <param name="monstre">Monstre a attaqué</param>
        public void NormalAttack(AMonstre monstre) {
            monstre.takeHit(this._force);
        }

        /// <summary>
        /// Se mets en position défensive
        /// En position défensive, les dégat recut lors de la prochaine attaque son diviser par 2
        /// </summary>
        public void defend() {
            this._isDefend = true;
        }

        /// <summary>
        /// Permet de savoir si le joueur est encore vivant
        /// </summary>
        /// <returns></returns>
        public bool isAlive() {
            return this._pv <= 0;
        }

    }
}
