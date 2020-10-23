using System;

namespace SimpleGameLib.Monstre {

    /// <summary>
    /// Classe abstraite pour configurer les Monstres
    /// </summary>
    public abstract class AMonstre {

        /// <summary>
        /// Point de vie des monstres, 100 par défauts
        /// </summary>
        protected int pv = 100;

        /// <summary>
        /// Force du monstres, Aucune valeur par défauts
        /// La valeur change en fonction du type de monstre
        /// </summary>
        protected int force;

        private bool _isDefend;

        /// <summary>
        /// Constructeur d'un monstre basique
        /// </summary>
        /// <param name="f">force du monstre</param>
        public AMonstre(int f) {
            this.force = f;
            this._isDefend = false;
        }

        /// <summary>
        /// Attaque un joueur
        /// Dans tous les cas, le joueur prends un coup.
        /// Des effets peuvent être rajouter suivant le monstre
        /// </summary>
        /// <param name="player">Joueur à attaquer</param>
        public virtual void Attack(Player player) {
            player.takeHit(this.force);
        }

        /// <summary>
        /// Returne le type de monstre
        /// </summary>
        /// <returns>String</returns>
        protected abstract String getMonsterType();

        /// <summary>
        /// Le monstre reçoit un coup
        /// En prennant un coup, sa vie va baisser
        /// </summary>
        /// <param name="deg">degat pris par le monstre</param>
        public void takeHit(int deg) {
            if (this._isDefend) {
                this.pv -= deg / 2;
                this._isDefend = false;
            }
            else {
                this.pv -= deg;
            }
        }

        /// <summary>
        /// Permet au monstre de se positionner en mode défense
        /// Le mode défense divise par 2 les dégat de la prochaine attaque subit
        /// </summary>
        public void defend() {
            this._isDefend = false;
        }

        /// <summary>
        /// Permets de savoir si le monstre est en vie ou pas
        /// </summary>
        /// <returns>bool</returns>
        public bool isAlive() {
            return this.pv <= 0;
        }

        /// <summary>
        /// Affiche le type, les PV et la force du monstre sur la console
        /// </summary>
        public void getDescription() {
            Console.WriteLine("+--------------------------------------------");
            Console.WriteLine("| "+ getMonsterType() + " PV : " + this.pv);
            Console.WriteLine("| "+ getMonsterType() + " Force : " + this.force);
            Console.WriteLine("+--------------------------------------------\n");
        }
    }
}
